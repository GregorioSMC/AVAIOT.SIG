using Microsoft.EntityFrameworkCore;
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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<EUsuarios> Usuarios { get; set; }
        public DbSet<ECatalogoRolesUsuarios> catalogoUsuarios { get; set; }
    }
}
