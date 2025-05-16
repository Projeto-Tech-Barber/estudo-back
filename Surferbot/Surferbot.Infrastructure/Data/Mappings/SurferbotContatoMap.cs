using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Surferbot.Core.Entities.SurferbotContatos;

namespace Surferbot.Infrastructure.Data.Mappings;

class SurferbotContatoMap : IEntityTypeConfiguration<SurferbotContato>
{
    public void Configure(EntityTypeBuilder<SurferbotContato> builder)
    {
        builder.ToTable("Contatos");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nome)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(150);

        builder.Property(c => c.Mensagem)
               .IsRequired()
               .HasMaxLength(1000);
    }
}
