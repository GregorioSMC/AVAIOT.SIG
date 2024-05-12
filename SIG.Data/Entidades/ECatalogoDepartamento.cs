using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG.Data.Entidades
{
    public class ECatalogoDepartamento : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public int IdCatalogoDependecia { get; set; }
        [ForeignKey("IdCatalogoDependecia")]
        public virtual ECatalogoDependecia CatalogoDependecia { get; set; } = new ();
    }
}
