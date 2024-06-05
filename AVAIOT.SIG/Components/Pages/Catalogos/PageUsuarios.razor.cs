using AVAIOT.SIG.Servicios.Interfaces;
using Microsoft.AspNetCore.Components;
using Radzen.Blazor;
using Radzen;
using SIG.ModeloDeNegocios.ModeloDeNegocios;
using SIG.Data.Entidades;
using AVAIOT.SIG.Components.Pages.Modal;

namespace AVAIOT.SIG.Components.Pages.Catalogos
{
    public partial class PageUsuarios 
    {
        [Inject] IServicioSIG _servicioSIG { get; set; } = null!;
        Dictionary<string, object> ParametrosDelComponenteFormulario { get; set; } = null!;
        ConfirmOptions OpcionesDeConfirmacion { get; set; } = null!;
        public List<Usuarios> usuarios { get; set; } = new();
        LogicalFilterOperator logicalFilterOperator = LogicalFilterOperator.And;
        FilterCaseSensitivity filterCaseSensitivity = FilterCaseSensitivity.CaseInsensitive;
        RadzenDataGrid<Usuarios> grid = new();
        protected override async Task OnInitializedAsync()
        {
            usuarios = await _servicioSIG.ObtenerUsuariosAsync();
            await base.OnInitializedAsync();
        }

        public void test()
        {
            Console.WriteLine("GSMC ===> Hello World!");
        }


        int orderID = 10248;

        public async Task ActualizarUsuario(Usuarios? _usuarios)
        {

            Usuarios usuario = _usuarios != null ? _usuarios : new();

            ParametrosDelComponenteFormulario = new(){
                {"usuario", usuario }               
            };

            try
            {
                await _dialogService.OpenAsync<DialogNuevoUsuarioPage>(
                    title: $"Editar usuario",
                    parameters: ParametrosDelComponenteFormulario,
                    options: OpcionesDeConfirmacion);

            }
            catch (Exception ex) { Console.WriteLine(ex); }

            await grid.Reload();        
        }

        public async Task AgregarUsuario(Usuarios? _usuarios)
        {

            Usuarios usuario = _usuarios != null ? _usuarios : new();

            ParametrosDelComponenteFormulario = new(){
                {"usuario", usuario }
            };

            try
            {
                await _dialogService.OpenAsync<DialogNuevoUsuarioPage>(
                    title: $"Nuevo Usuario",
                    parameters: ParametrosDelComponenteFormulario,
                    options: OpcionesDeConfirmacion);

            }
            catch (Exception ex) { Console.WriteLine(ex); }

            await grid.Reload();
        }
    }
}
