using Microsoft.EntityFrameworkCore;
using SIG.Data.Entidades;
using SIG.Data.Repositorio.Interfaz;
using SIG.Data.SigDbContext;
using SIG.ModeloDeNegocios.ModeloDeNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG.Data.Repositorio
{
    public class RepositorioSIG : IRepositorioSIG
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

        public RepositorioSIG(IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            _contextFactory = contextFactory ?? throw new ArgumentNullException(nameof(contextFactory));
        }

        /// <summary>
        /// Metodo Asincrono que se encarga de obtener una lista de los usuarios activos
        /// </summary>
        /// <returns> Retorna una lista de la clase Usuario </returns>
        public async Task<List<Usuarios>> ObtenerUsuariosAsync()
        {
            using ApplicationDbContext _context = _contextFactory.CreateDbContext();
            try
            {
                return await (from u in _context.Usuarios
                              where u.EsActivo == true
                              select new Usuarios
                              {
                                  Id = u.Id,
                                  Nombre = u.Nombre,
                                  ApellidoPaterno = u.ApellidoPaterno,
                                  ApellidoMaterno = u.ApellidoMaterno,
                                  EsActivo = u.EsActivo
                              }).ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
