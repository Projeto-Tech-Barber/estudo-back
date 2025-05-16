using Microsoft.EntityFrameworkCore;
using Surferbot.Infrastructure.Data;

namespace Surferbot.Test.Infrastucture;

public class DatabaseConnectionTests
{
    [Fact]
    public void ConectarComBancoDeDados()
    {
        var options = new DbContextOptionsBuilder<SurferbotContext>()
            .UseNpgsql("Host=localhost;Port=5432;Database=surf_bot;Username=admin;Password=admin123")
            .Options;

        using var context = new SurferbotContext(options);

        bool conectado = context.Database.CanConnect();

        Assert.True(conectado, "Não foi possível conectar ao banco de dados.");
    }
}
