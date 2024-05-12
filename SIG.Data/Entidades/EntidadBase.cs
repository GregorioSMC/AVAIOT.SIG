using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG.Data.Entidades
{
    public class EntidadBase
    {
        public bool EsActivo {  get; set; } 
        public DateTime Creado { get; set; } 
        public string CreadoPor {  get; set; } = string.Empty;
        public DateTime Modificado { get; set; } 
        public string ModificadoPor { get; set; } = string.Empty;
    }
}
