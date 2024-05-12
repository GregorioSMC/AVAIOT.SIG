using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG.ModeloDeNegocios.ModeloDeNegocios
{
    public class RegistroDeBienes
    {
        public int Id { get; set; }
        public string NumeroDeInventario { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public int IdCatalogoTipoDeBien {  get; set; }
        public string TipoDeBien { get; set; } = string.Empty;
        public int IdCatalogoSituacion {get; set; }
        public string Situacion { get; set; } = string.Empty;
        public int IdCatalogoDependencia { get; set; }
        public string NombreDependencia { get; set; } = string.Empty;
        public int IdCatalogoDepartamento { get; set; }
        public string NombreDepartamento { get; set; } = string.Empty;
        public string Observaciones {  get; set; } = string.Empty;
        public int IdRegistrofacturas {  get; set; } 
        public string UUID { get; set; } = string.Empty;
        public string NumeroSerie { get; set; } = string.Empty;
        public int IdCatalogoEmpleados { get; set; }        
        public string NombreEmpleado { get; set; } = string.Empty;

    }
}
