using Microsoft.EntityFrameworkCore;
using ProjetoDanielEx.Core.Domain.Entities;
using System.Linq;

namespace ProjetoDanielEx.Core.Data
{
    public class MeuContextoBDs : DbContext
    {
        #region Constructor

        public MeuContextoBDs(DbContextOptions options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        #endregion

        #region DBSets

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Documento> Documentos { get; set; }

        #endregion

        #region ModelBuilder e SaveChanges

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(255)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuContextoBDs).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging(false);
        }

        #endregion
    }
}
