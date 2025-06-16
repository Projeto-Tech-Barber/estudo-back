using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Core;
using Serilog.Settings.Configuration;
using Surferbot.Api.Middleware;
using Surferbot.Application;
using Surferbot.Application.Interface.InterfaceContato;
using Surferbot.Application.UseCases.Clientes;
using Surferbot.Application.UseCases.Contato;
using Surferbot.Application.Validators.ContatoValidador;
using Surferbot.Core.Entidades.SurferBotCliente;
using Surferbot.Infrastructure.Data;
using Surferbot.Infrastructure.Repositories.Clientes;
using Surferbot.Infrastructure.Repositories.ContatoRepositorories;

var builder = WebApplication.CreateBuilder(args);

var loggerOptions = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration);

Log.Logger = loggerOptions.CreateLogger();


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddDbContext<SurferbotContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection"),
        x => x.MigrationsAssembly("Surferbot.Infrastructure")));

// Add services to the container.
builder.Services.AddValidatorsFromAssemblyContaining<ContatoValidador>();
builder.Services.AddAutoMapper(x =>
{
    x.AddMaps(typeof(ApplicationAssemblyReference).Assembly);
});
builder.Services.AddScoped<IClienteUseCase, ClienteUseCase>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IContatoService, ContatoService>();
builder.Services.AddScoped<IContatoRepository, ContatoRepository>();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<RequestResponseLoggingMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();
