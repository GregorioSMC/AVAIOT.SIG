

using Radzen.Blazor;
using Radzen;
using SIG.ModeloDeNegocios.ModeloDeNegocios;
using Microsoft.AspNetCore.Components;

namespace AVAIOT.SIG.Components.Pages
{
    public partial class LayoutRegistroDeBienes
    {
        
        RadzenDataGrid<RegistroDeBienes> grid;

        LogicalFilterOperator logicalFilterOperator = LogicalFilterOperator.And;
        FilterCaseSensitivity filterCaseSensitivity = FilterCaseSensitivity.CaseInsensitive;

        List<RegistroDeBienes> registroDeBienes = new();

        protected override async Task OnInitializedAsync()
        {

            await base.OnInitializedAsync();

            registroDeBienes = new()
            {
                new RegistroDeBienes
                {
                    Id = 1,
                    NumeroDeInventario = "000001",
                    Descripcion = "STAND MURO EXPANDIBLE PUBLICITARIO",
                    Marca = "SIN MARCA ",
                    IdCatalogoTipoDeBien = 1,
                    TipoDeBien = "BASE",
                    IdCatalogoSituacion = 1,
                    Situacion = "MODIFICADO",
                    IdCatalogoDependencia = 1,
                    NombreDependencia = "PRESIDENCIA MUNICIPAL",
                    IdCatalogoDepartamento = 1,
                    NombreDepartamento = "DIRECCION DE PROMOCION INSTITUCIONAL Y LOGISTICA",
                    Observaciones = "",
                    IdRegistrofacturas = 1,
                    UUID = "XXXXX",
                    NumeroSerie = "xxxxxxxxx",
                    IdCatalogoEmpleados = 1,
                    NombreEmpleado = "GIOVANNI PINELO PEREZ"

                },
                new RegistroDeBienes
                {
                    Id = 2,
                    NumeroDeInventario = "000002",
                    Descripcion = "STAND MURO EXPANDIBLE PUBLICITARIO",
                    Marca = "SIN MARCA ",
                    IdCatalogoTipoDeBien = 1,
                    TipoDeBien = "BASE",
                    IdCatalogoSituacion = 1,
                    Situacion = "MODIFICADO",
                    IdCatalogoDependencia = 1,
                    NombreDependencia = "PRESIDENCIA MUNICIPAL",
                    IdCatalogoDepartamento = 1,
                    NombreDepartamento = "DIRECCION DE PROMOCION INSTITUCIONAL Y LOGISTICA",
                    Observaciones = "",
                    IdRegistrofacturas = 1,
                    UUID = "XXXXX",
                    NumeroSerie = "xxxxxxxxx",
                    IdCatalogoEmpleados = 1,
                    NombreEmpleado = "GIOVANNI PINELO PEREZ"

                },
                new RegistroDeBienes
                {
                    Id = 3,
                    NumeroDeInventario = "000003",
                    Descripcion = "STAND MURO EXPANDIBLE PUBLICITARIO",
                    Marca = "SIN MARCA ",
                    IdCatalogoTipoDeBien = 1,
                    TipoDeBien = "BASE",
                    IdCatalogoSituacion = 1,
                    Situacion = "MODIFICADO",
                    IdCatalogoDependencia = 1,
                    NombreDependencia = "PRESIDENCIA MUNICIPAL",
                    IdCatalogoDepartamento = 1,
                    NombreDepartamento = "DIRECCION DE PROMOCION INSTITUCIONAL Y LOGISTICA",
                    Observaciones = "",
                    IdRegistrofacturas = 1,
                    UUID = "XXXXX",
                    NumeroSerie = "xxxxxxxxx",
                    IdCatalogoEmpleados = 1,
                    NombreEmpleado = "GIOVANNI PINELO PEREZ"

                },
                new RegistroDeBienes
                {
                    Id = 4,
                    NumeroDeInventario = "000004",
                    Descripcion = "STAND MURO EXPANDIBLE PUBLICITARIO",
                    Marca = "SIN MARCA ",
                    IdCatalogoTipoDeBien = 1,
                    TipoDeBien = "BASE",
                    IdCatalogoSituacion = 1,
                    Situacion = "MODIFICADO",
                    IdCatalogoDependencia = 1,
                    NombreDependencia = "PRESIDENCIA MUNICIPAL",
                    IdCatalogoDepartamento = 1,
                    NombreDepartamento = "DIRECCION DE PROMOCION INSTITUCIONAL Y LOGISTICA",
                    Observaciones = "",
                    IdRegistrofacturas = 1,
                    UUID = "XXXXX",
                    NumeroSerie = "xxxxxxxxx",
                    IdCatalogoEmpleados = 1,
                    NombreEmpleado = "GIOVANNI PINELO PEREZ"

                },
                new RegistroDeBienes
                {
                    Id = 5,
                    NumeroDeInventario = "000005",
                    Descripcion = "STAND MURO EXPANDIBLE PUBLICITARIO",
                    Marca = "SIN MARCA ",
                    IdCatalogoTipoDeBien = 1,
                    TipoDeBien = "BASE",
                    IdCatalogoSituacion = 1,
                    Situacion = "MODIFICADO",
                    IdCatalogoDependencia = 1,
                    NombreDependencia = "PRESIDENCIA MUNICIPAL",
                    IdCatalogoDepartamento = 1,
                    NombreDepartamento = "DIRECCION DE PROMOCION INSTITUCIONAL Y LOGISTICA",
                    Observaciones = "",
                    IdRegistrofacturas = 1,
                    UUID = "XXXXX",
                    NumeroSerie = "xxxxxxxxx",
                    IdCatalogoEmpleados = 1,
                    NombreEmpleado = "GIOVANNI PINELO PEREZ"

                },
                new RegistroDeBienes
                {
                    Id = 6,
                    NumeroDeInventario = "000006",
                    Descripcion = "STAND MURO EXPANDIBLE PUBLICITARIO",
                    Marca = "SIN MARCA ",
                    IdCatalogoTipoDeBien = 1,
                    TipoDeBien = "BASE",
                    IdCatalogoSituacion = 1,
                    Situacion = "MODIFICADO",
                    IdCatalogoDependencia = 1,
                    NombreDependencia = "PRESIDENCIA MUNICIPAL",
                    IdCatalogoDepartamento = 1,
                    NombreDepartamento = "DIRECCION DE PROMOCION INSTITUCIONAL Y LOGISTICA",
                    Observaciones = "",
                    IdRegistrofacturas = 1,
                    UUID = "XXXXX",
                    NumeroSerie = "xxxxxxxxx",
                    IdCatalogoEmpleados = 1,
                    NombreEmpleado = "GIOVANNI PINELO PEREZ"

                }
            };


        }

        private void CrearNuevoBien()
        {
            Console.WriteLine("GSMC ==> Clic!!!");
            NavigationManager.NavigateTo("/NuevoBien");
        }
        void OnLoadData(LoadDataArgs args)
        {
            // Aquí puedes realizar la carga de datos desde tu servidor o servicio.
            // Utiliza los argumentos 'args' para aplicar filtros, ordenación y paginación.
        }
    }
}
