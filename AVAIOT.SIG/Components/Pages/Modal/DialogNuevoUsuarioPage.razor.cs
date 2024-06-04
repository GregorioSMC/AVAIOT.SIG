using Microsoft.AspNetCore.Components;
using SIG.ModeloDeNegocios.ModeloDeNegocios;

namespace AVAIOT.SIG.Components.Pages.Modal
{
    public partial class DialogNuevoUsuarioPage
    {
        [Parameter] public Usuarios usuario { get; set; } = null!;
        protected override async Task OnInitializedAsync()
        {         
            await base.OnInitializedAsync();
        }

    }
}
