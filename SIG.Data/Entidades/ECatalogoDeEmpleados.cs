using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG.Data.Entidades
{
    public class ECatalogoDeEmpleados
    {
        public int Id { get; set; }
        public int NumeroDeControl {  get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int IdCatalogoDepartamento { get; set; }
        [ForeignKey("IdCatalogoDepartamento")]
        public virtual ECatalogoDepartamento CatalogoDepartamento { get; set; } = new();
    }
}
