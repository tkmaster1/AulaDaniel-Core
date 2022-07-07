using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoDanielEx.Core.Domain.Entities;

namespace ProjetoDanielEx.Core.Data.EntityConfig
{
    public class DocumentoConfiguration : IEntityTypeConfiguration<Documento>
    {
        public void Configure(EntityTypeBuilder<Documento> builder)
        {
            builder.ToTable("documento", "dbo");

            builder
                .Property(d => d.Codigo)
                .HasColumnName("id");

            builder
                .HasKey(d => d.Codigo)
                .HasName("PK_Documento");

            builder
                .Property(d => d.Nome)
                .IsRequired()
                .HasColumnName("nome");

            builder
                .Property(d => d.Descricao)
                .IsRequired()
                .HasColumnType("varchar(1000)")
                .HasColumnName("descricao");

            builder
                .Property(d => d.Status)
                .IsRequired()
                .HasColumnName("status");

            builder
                .Property(d => d.DataCadastro)
                .IsRequired()
                .HasColumnName("dt_inclusao");

            builder
                .Property(d => d.DataAlteracao)
                .HasColumnName("dt_alteracao");

            builder
                .Property(d => d.DataExclusao)
                .HasColumnName("dt_exclusao");

            builder
                .Property(d => d.CodigoCliente)
                .HasColumnName("idCliente");

            // 1 : * => Cliente : Documento
            builder
                .HasOne(c => c.Cliente)
                .WithMany(d => d.Documentos)
                .HasForeignKey(d => d.CodigoCliente);
        }
    }
}
