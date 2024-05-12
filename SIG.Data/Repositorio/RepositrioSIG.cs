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
    public class RepositrioSIG : IRepositorioSIG
    {
       private readonly ApplicationDbContext _dbContext;

        public RepositrioSIG(ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public List<RegistroDeBienes> ObtenerRegistroDeBienesAsync ()
        {
            return new List<RegistroDeBienes>();
        }
    }
}
