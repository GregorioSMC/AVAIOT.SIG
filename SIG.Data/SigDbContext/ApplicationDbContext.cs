using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SIG.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG.Data.SigDbContext
{
    public class ApplicationDbContext : DbContext
    {
        private string ConnectionString { get; set; } = string.Empty;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configuración para cuando se necesite instanciar el DbContext, en lugar de una inyección de dependencia.
            if (!optionsBuilder.IsConfigured && !string.IsNullOrEmpty(ConnectionString))
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }   

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public override int SaveChanges()
        {
            TrackChanges(ChangeTracker);

            return base.SaveChanges();
        }

        // Se sobrescribe el método TrackChangeAsync
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            TrackChanges(ChangeTracker);

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        // Identifica si el cambio es una actualización o un nuevo registro.
        // Modifica los respectivos atributos (Creado, Modificado) de la entidad.
        private void TrackChanges(ChangeTracker changeTracker)
        {
            IEnumerable<EntityEntry> entries = changeTracker
                .Entries()
                .Where(e => e.Entity is EntidadBase &&
                        (e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                if (entityEntry.State == EntityState.Modified)
                    ((EntidadBase)entityEntry.Entity).Modificado = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                    ((EntidadBase)entityEntry.Entity).Creado = DateTime.Now;
            }
        }

        public DbSet<ECatalogoDeEmpleados> CatalogoDeEmpleados { get; set; }
        public DbSet<ECatalogoDepartamento> CatalogoDepartamentos { get; set; }
        public DbSet<ECatalogoDependecia> CatalogoDependecias { get; set; }
        public DbSet<ECatalogoPuestosEmpleado> CatalogoPuestoEmpleados { get; set; }
        public DbSet<ECatalogoRolesUsuarios> catalogoRolesUsuarios { get; set; }
        public DbSet<ECatalogoTipoDeBien> CatalogoTipoDeBienes {  get; set; }
        public DbSet <ECatalogoUbicaciones> CatalogoUbicaciones { get; set; }
        public DbSet<ERegistroFacturas> RegistroFacturas { get; set; }
        public DbSet<EUsuarios> Usuarios { get; set; }
    }
}
