using Microsoft.EntityFrameworkCore;
using Surferbot.Infrastructure.Data;
using Surferbot.Application;
using Surferbot.Application.UseCases.Clientes;
using Surferbot.Application.Validadores.Clientes;
using Surferbot.Core.Entidades.SurferBotCliente;
using Surferbot.Infrastructure.Repositories.Clientes;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SurferbotContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection"),
        x => x.MigrationsAssembly("Surferbot.Infrastructure")));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(x =>
{
    x.AddMaps(typeof(ApplicationAssemblyReference).Assembly);
});
builder.Services.AddScoped<IClienteUseCase, ClienteUseCase>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<CriarClienteDtoValidator>();
var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<SurferbotContext>();
    db.Database.Migrate();
}

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
