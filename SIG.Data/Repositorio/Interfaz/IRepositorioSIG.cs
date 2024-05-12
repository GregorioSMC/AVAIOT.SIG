using SIG.ModeloDeNegocios.ModeloDeNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG.Data.Repositorio.Interfaz
{
    public interface IRepositorioSIG
    {
        public List<RegistroDeBienes> ObtenerRegistroDeBienesAsync();
    }
}
