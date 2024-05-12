using Microsoft.EntityFrameworkCore;
using Radzen.Blazor;
using Radzen;
using SIG.ModeloDeNegocios.ModeloDeNegocios;

namespace AVAIOT.SIG.Components.Pages
{
    public partial class LayoutRegistroDeBienes
    {
        RadzenDataGrid<RegistroDeBienes> grid = new ();

        LogicalFilterOperator logicalFilterOperator = LogicalFilterOperator.And;
        FilterCaseSensitivity filterCaseSensitivity = FilterCaseSensitivity.CaseInsensitive;

        List<RegistroDeBienes> registroDeBienes = new ();

        protected override async Task OnInitializedAsync()
        {
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

                }
            };
            await base.OnInitializedAsync();

        }
    }
}
