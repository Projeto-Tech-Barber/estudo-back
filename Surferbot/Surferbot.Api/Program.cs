using Microsoft.EntityFrameworkCore;
using FluentValidation;
using Surferbot.Application.UseCases.Contato;
using Surferbot.Application.Validators.ContatoValidador;
using Surferbot.Infrastructure.Data;
using Surferbot.Application.Interface.InterfaceContato;
using Surferbot.Infrastructure.Repositories.ContatoRepositorories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddDbContext<SurferbotContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection"),
        x => x.MigrationsAssembly("Surferbot.Infrastructure")));

// Add services to the container.
builder.Services.AddValidatorsFromAssemblyContaining<ContatoValidador>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
