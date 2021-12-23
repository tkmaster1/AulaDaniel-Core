using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoDanielEx.Core.Domain.Entities;

namespace ProjetoDanielEx.Core.Data.EntityConfig
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("endereco");

            builder
                 .Property(e => e.Codigo)
                 .HasColumnName("id");

            builder.HasKey(e => e.Codigo);

            builder
                 .Property(e => e.Logradouro)
                 .IsRequired()
                 .HasColumnType("varchar(200)");

            builder
                 .Property(e => e.Numero)
                 .IsRequired()
                 .HasColumnType("varchar(50)");

            builder
                 .Property(e => e.Cep)
                 .IsRequired()
                 .HasColumnType("varchar(8)");

            builder
                 .Property(e => e.Complemento)
                 .HasColumnType("varchar(250)");

            builder.Property(e => e.Bairro)
                 .IsRequired()
                 .HasColumnType("varchar(100)");

            builder
                 .Property(e => e.Cidade)
                 .IsRequired()
                 .HasColumnType("varchar(100)");

            builder
                 .Property(e => e.Estado)
                 .IsRequired()
                 .HasColumnType("varchar(50)");

            builder
                 .Property(e => e.CodigoCliente)
                 .HasColumnName("idCliente");

            builder
                 .Ignore(e => e.Nome);

            builder
                 .Ignore(e => e.DataCadastro);

            builder
                 .Ignore(e => e.DataAlteracao);

            builder
                 .Ignore(e => e.DataExclusao);

            builder
                 .Ignore(e => e.Status);

            // 1 : 1 => Cliente : Endereco
            builder
                 .HasOne(c => c.Cliente)
                 .WithOne(e => e.Endereco)
                 .HasForeignKey<Endereco>(e => e.CodigoCliente);
        }
    }
}
