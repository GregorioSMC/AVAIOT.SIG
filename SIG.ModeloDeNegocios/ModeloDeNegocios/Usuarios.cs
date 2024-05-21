using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG.ModeloDeNegocios.ModeloDeNegocios
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string ApellidoPaterno { get; set; } = string.Empty;
        public string ApellidoMaterno { get; set; } = string.Empty;
        public string Usuario { get; set; } = string.Empty;
        public string Contraseña { get; set; } = string.Empty;
        public bool EsActivo { get; set; } = false;
    }
}
