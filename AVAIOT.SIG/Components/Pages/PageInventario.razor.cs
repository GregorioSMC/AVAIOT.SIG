using Radzen;
using Radzen.Blazor;
using SIG.ModeloDeNegocios.ModeloDeNegocios;

namespace AVAIOT.SIG.Components.Pages
{
    public partial class PageInventario
    {
        LogicalFilterOperator logicalFilterOperator = LogicalFilterOperator.And;
        FilterCaseSensitivity filterCaseSensitivity = FilterCaseSensitivity.CaseInsensitive;
        RadzenDataGrid<Inventario> grid;
        List<Inventario> inventario = new();
        protected override async Task OnInitializedAsync()
        {

            await base.OnInitializedAsync();

            inventario = new()
            {
                new Inventario 
                {
                    IdCatalogoEmpleados = 1,
                    NumeroDeControl = "**000123456",
                    NombreEmpleado = "CAMBIO DE RESGUARDO DIRECCION DE TURISMO",
                    IdCatalogoPuestos  = 1, 
                    Puesto = "AUXILIAR",
                    IdCatalogoUbicaciones = 1,
                    Ubicacion = "0805 DIRECCION DE ARMONIZACION CONTABLE",             
                    IdCatalogoDependecia = 1,
                    Dependencia = "TESORERIA MUNICIPAL",                 
                    IdCatalogoDepartamento = 1,
                    Departamento  = "2 PLAZA CRYSTAL LOCAL 01 \"B\""
                },
                new Inventario
                {
                    IdCatalogoEmpleados = 1,
                    NumeroDeControl = "**000123456",
                    NombreEmpleado = "CAMBIO DE RESGUARDO DIRECCION DE TURISMO",
                    IdCatalogoPuestos  = 1,
                    Puesto = "AUXILIAR",
                    IdCatalogoUbicaciones = 1,
                    Ubicacion = "0805 DIRECCION DE ARMONIZACION CONTABLE",
                    IdCatalogoDependecia = 1,
                    Dependencia = "TESORERIA MUNICIPAL",
                    IdCatalogoDepartamento = 1,
                    Departamento  = "2 PLAZA CRYSTAL LOCAL 01 \"B\""
                },
                new Inventario
                {
                    IdCatalogoEmpleados = 1,
                    NumeroDeControl = "**000123456",
                    NombreEmpleado = "CAMBIO DE RESGUARDO DIRECCION DE TURISMO",
                    IdCatalogoPuestos  = 1,
                    Puesto = "AUXILIAR",
                    IdCatalogoUbicaciones = 1,
                    Ubicacion = "0805 DIRECCION DE ARMONIZACION CONTABLE",
                    IdCatalogoDependecia = 1,
                    Dependencia = "TESORERIA MUNICIPAL",
                    IdCatalogoDepartamento = 1,
                    Departamento  = "2 PLAZA CRYSTAL LOCAL 01 \"B\""
                },
                new Inventario
                {
                    IdCatalogoEmpleados = 1,
                    NumeroDeControl = "**000123456",
                    NombreEmpleado = "CAMBIO DE RESGUARDO DIRECCION DE TURISMO",
                    IdCatalogoPuestos  = 1,
                    Puesto = "AUXILIAR",
                    IdCatalogoUbicaciones = 1,
                    Ubicacion = "0805 DIRECCION DE ARMONIZACION CONTABLE",
                    IdCatalogoDependecia = 1,
                    Dependencia = "TESORERIA MUNICIPAL",
                    IdCatalogoDepartamento = 1,
                    Departamento  = "2 PLAZA CRYSTAL LOCAL 01 \"B\""
                }
            };
        }
    }
}
