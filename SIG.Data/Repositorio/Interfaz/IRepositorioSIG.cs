using SIG.Data.Entidades;
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
        public Task<List<Usuarios>> ObtenerUsuariosAsync();
        public Task<Usuarios> AgregarUsuariosAsync(Usuarios usuario);
        public Task<Usuarios> ActualizarUsuariosAsync(Usuarios usuario);
    }
}
