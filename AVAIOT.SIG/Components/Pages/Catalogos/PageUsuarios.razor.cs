using AVAIOT.SIG.Servicios.Interfaces;
using Microsoft.AspNetCore.Components;
using Radzen.Blazor;
using Radzen;
using SIG.ModeloDeNegocios.ModeloDeNegocios;
using SIG.Data.Entidades;

namespace AVAIOT.SIG.Components.Pages.Catalogos
{
    public partial class PageUsuarios
    {
        [Inject] IServicioSIG _servicioSIG { get; set; } = null!;
        public List<Usuarios> usuarios { get; set; } = new();
        LogicalFilterOperator logicalFilterOperator = LogicalFilterOperator.And;
        FilterCaseSensitivity filterCaseSensitivity = FilterCaseSensitivity.CaseInsensitive;
        RadzenDataGrid<Usuarios> grid = new();
        protected override async Task OnInitializedAsync()
        {
            usuarios = await _servicioSIG.ObtenerUsuariosAsync();
            await base.OnInitializedAsync();         
        }
    }
}
