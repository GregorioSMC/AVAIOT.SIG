using AVAIOT.SIG.Servicios.Interfaces;
using SIG.Data.Repositorio.Interfaz;
using SIG.ModeloDeNegocios.ModeloDeNegocios;

namespace AVAIOT.SIG.Servicios
{
    public class ServicioSIG : IServicioSIG
    {
        
        public readonly IRepositorioSIG _repositorio;
   
        public ServicioSIG(IRepositorioSIG repositorio)
        {
            _repositorio = repositorio;
        }   

        public List<RegistroDeBienes> ObtenerRegistroDeBienesAsync()
        {
            return _repositorio.ObtenerRegistroDeBienesAsync();
        }
    }
}
