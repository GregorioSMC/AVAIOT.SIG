using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG.ModeloDeNegocios.ModeloDeNegocios
{
    public class Inventario
    {
        public int IdCatalogoEmpleados {  get; set; }
        public string NumeroDeControl {  get; set; } = string.Empty;
        public string NombreEmpleado { get; set; } = string.Empty;
        public int IdCatalogoPuestos { get; set; }
        public string Puesto {  get; set; } = string.Empty;
        public int IdCatalogoUbicaciones { get; set; }
        public string Ubicacion {  get; set; } = string.Empty;
        public int IdCatalogoDependecia { get; set; }
        public string Dependencia {  get; set; } = string.Empty;
        public int IdCatalogoDepartamento { get; set; }
        public string Departamento { get; set; } = string.Empty; 
    }
}
