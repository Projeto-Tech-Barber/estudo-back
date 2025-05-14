using Microsoft.EntityFrameworkCore;
using Surferbot.Infrastructure.Data;

namespace Surferbot.Tests.Fixtures
{
    public static class ContextFixture
    {
        public static SurferbotContext CreateContext()
        {
            var options = new DbContextOptionsBuilder<SurferbotContext>()
                .UseInMemoryDatabase(databaseName: "SurferbotTestDb")
                .Options;

            var context = new SurferbotContext(options);

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            return context;
        }
    }
}