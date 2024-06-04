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

        public async Task CrearNuevoUsuario(Usuarios _usuarios)
        {
           
            ParametrosDelComponenteFormulario = new(){
                {"usuario", _usuarios }               
            };

            try
            {
                await _dialogService.OpenAsync<DialogNuevoUsuarioPage>(
                    title: $"Modificación de Captura",
                    parameters: ParametrosDelComponenteFormulario,
                    options: OpcionesDeConfirmacion);

            }
            catch (Exception ex) { Console.WriteLine(ex); }

            await grid.Reload();

        Console.WriteLine("GSMC ==> TEST CLIC");
        //    await DialogService.OpenAsync<DialogNuevoUsuarioPage>($"Order {orderID}",
        //       new Dictionary<string, object>() { { "OrderID", orderID } },
        //       new DialogOptions() { Width = "700px", Height = "512px", Resizable = true, Draggable = true });
        }

        public async Task CrearNuevoUsuario()
        {
            ParametrosDelComponenteFormulario = new(){
                {"usuario", new() }
            };

            try
            {
                await _dialogService.OpenAsync<DialogNuevoUsuarioPage>(
                    title: $"Modificación de Captura",
                    parameters: ParametrosDelComponenteFormulario,
                    options: OpcionesDeConfirmacion);

            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}
