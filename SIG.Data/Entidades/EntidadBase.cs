using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG.Data.Entidades
{
    public class EntidadBase
    {
        public bool EsActivo {  get; set; } = true;
        public DateTime Creado { get; set; } = DateTime.Now;
        public string CreadoPor {  get; set; } = string.Empty;
        public DateTime Modificado { get; set; } = new DateTime();
        public string ModificadoPor { get; set; } = string.Empty;
    }
}
