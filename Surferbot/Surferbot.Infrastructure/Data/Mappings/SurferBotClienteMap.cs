using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Surferbot.Core.Entidades.SurferBotCliente;

namespace Surferbot.Infrastructure.Data.Mappings
{
    public class SurferBotClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.Email)
                    .IsRequired()
                    .HasMaxLength(150);

            builder.Property(p => p.Cpf)
                    .IsRequired()
                    .HasMaxLength(150);

            builder.Property(p => p.Endereco)
                    .IsRequired()
                    .HasMaxLength(150);

            builder.Property(p => p.Estado)
                    .IsRequired()
                    .HasMaxLength(150);

            builder.Property(p => p.Cidade)
                    .IsRequired()
                    .HasMaxLength(150);

            builder.Property(p => p.Cep)
                    .IsRequired()
                    .HasMaxLength(150);

            builder.Property(p => p.Plano)
                    .IsRequired()
                    .HasMaxLength(150);
        }
    }
}
