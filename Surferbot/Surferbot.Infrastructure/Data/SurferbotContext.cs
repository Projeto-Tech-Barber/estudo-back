using Microsoft.EntityFrameworkCore;
using Surferbot.Application.Modelos.SurferbotContatos;
using Surferbot.Infrastructure.Data.Mappings;

namespace Surferbot.Infrastructure.Data;

public class SurferbotContext : DbContext
{
   public SurferbotContext(DbContextOptions options) : base(options)
    {
    }

    private DbSet<SurferbotContato> Contatos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SurferbotContatoMap).Assembly);
    }
}
