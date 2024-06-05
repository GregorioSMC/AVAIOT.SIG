using AVAIOT.SIG.Servicios.Interfaces;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor.Rendering;
using SIG.ModeloDeNegocios.ModeloDeNegocios;
using System.Globalization;

namespace AVAIOT.SIG.Components.Pages.Modal
{
    public partial class DialogNuevoUsuarioPage
    {
        [Inject] IServicioSIG _servicioSIG { get; set; } = null!;
        [Parameter] public Usuarios usuario { get; set; } = null!;

        public string NombreUsuario { get; set; } = string.Empty;
        public string ApUsuario { get; set; } = string.Empty;
        public string AmUsuario { get; set; } = string.Empty;


        protected override async Task OnInitializedAsync()
        {
            NombreUsuario = usuario.Nombre;            
            ApUsuario = usuario.ApellidoPaterno;
            AmUsuario = usuario.ApellidoMaterno;
            await base.OnInitializedAsync();

        }

        public async Task ModificarRegistroUsuario() 
        {

            if (usuario.Id == 0)
            {
                usuario.Nombre = NombreUsuario;
                usuario.ApellidoPaterno = ApUsuario;
                usuario.ApellidoMaterno = AmUsuario;
                var auxAgregar = await _servicioSIG.AgregarUsuariosAsync(usuario);
                if (usuario != null)
                {
                    NotificationService.Notify(new NotificationMessage
                    {
                        Severity = NotificationSeverity.Success,
                        Summary = "Exito",
                        Detail = "El usuario se agrego correctamente",
                        Duration = 4000
                    });

                    dialogService.Close();
                }
            }
            else 
            {
                usuario.Nombre = NombreUsuario;
                usuario.ApellidoPaterno = ApUsuario;
                usuario.ApellidoMaterno = AmUsuario;
                var auxActualizar = await _servicioSIG.ActualizarUsuariosAsync(usuario);
                if (usuario != null)
                {
                    NotificationService.Notify(new NotificationMessage
                    {
                        Severity = NotificationSeverity.Success,
                        Summary = "Exito",
                        Detail = "El usuario se agrego correctamente",
                        Duration = 4000
                    });

                    dialogService.Close();
                }

            }

            
        }

        public async Task Cancel()
        {
            dialogService.Close();
        }
    }
}
