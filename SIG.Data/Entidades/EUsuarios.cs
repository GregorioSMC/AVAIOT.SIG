using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG.Data.Entidades
{
    public class EUsuarios : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string ApellidoPaterno { get; set; } = string.Empty;
        public string ApellidoMaterno {  get; set; } = string.Empty;   
        public string Usuario {  get; set; } = string.Empty;
        public string Contraseña {  get; set; } = string.Empty; 
    }
}
