
using SIG.Data.Entidades;
using SIG.ModeloDeNegocios.ModeloDeNegocios;

namespace AVAIOT.SIG.Servicios.Interfaces
{
    public interface IServicioSIG
    {        
        public Task<List<Usuarios>> ObtenerUsuariosAsync();
    }
}
