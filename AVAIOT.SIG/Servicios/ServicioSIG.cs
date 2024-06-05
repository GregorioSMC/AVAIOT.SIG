using AVAIOT.SIG.Servicios.Interfaces;
using Microsoft.EntityFrameworkCore;
using SIG.Data.Entidades;
using SIG.Data.Repositorio.Interfaz;
using SIG.Data.SigDbContext;
using SIG.ModeloDeNegocios.ModeloDeNegocios;

namespace AVAIOT.SIG.Servicios
{
    public class ServicioSIG : IServicioSIG
    {

        private readonly IRepositorioSIG _repositorioSIG;
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

        public ServicioSIG(IRepositorioSIG repositorioSIG, IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            _repositorioSIG = repositorioSIG ?? throw new ArgumentNullException(nameof(repositorioSIG));
            _contextFactory = contextFactory ?? throw new ArgumentNullException(nameof(contextFactory));
        }


        public async Task<List<Usuarios>> ObtenerUsuariosAsync() 
        {
            return await _repositorioSIG.ObtenerUsuariosAsync();
        }

        public async Task<Usuarios> AgregarUsuariosAsync(Usuarios usuario) 
        {
            return await _repositorioSIG.AgregarUsuariosAsync(usuario);
        }
        public async Task<Usuarios> ActualizarUsuariosAsync(Usuarios usuario) 
        {
            return await _repositorioSIG.ActualizarUsuariosAsync(usuario);
        }
    }
}
