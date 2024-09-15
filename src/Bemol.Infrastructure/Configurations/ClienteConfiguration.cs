using Bemol.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bemol.Infrastructure.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable(nameof(Cliente))
             .HasKey(x => x.Id);

            builder.Property(x => x.Id);

            builder.Property(x => x.Nome)
               .HasColumnType("varchar(150)")
               .HasColumnName("Nome")
               .IsRequired()
               .HasMaxLength(150)
               .IsUnicode(false);

            builder.Property(x => x.Cpf)
              .HasColumnType("varchar(11)")
              .HasColumnName("Cpf")
              .IsRequired()
              .HasMaxLength(11)
              .IsUnicode(false);

            builder.Property(x => x.Cep)
              .HasColumnType("varchar(9)")
              .HasColumnName("Cep")
              .IsRequired()
              .HasMaxLength(9)
              .IsUnicode(false);

            builder.Property(x => x.Rua)
              .HasColumnType("varchar(100)")
              .HasColumnName("Rua")
              .IsRequired()
              .HasMaxLength(100)
              .IsUnicode(false);

            builder.Property(x => x.Email)
              .HasColumnType("varchar(50)")
              .HasColumnName("Email")
              .IsRequired()
              .HasMaxLength(50)
              .IsUnicode(false);
        }
    }
}
