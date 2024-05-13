using Microsoft.EntityFrameworkCore;
using SIG.ModeloDeNegocios.ModeloDeNegocios;

namespace AVAIOT.SIG.Components.Pages
{
    public partial class PageNuevoBien
    {
        public RegistroNuevoBien registroBien { get; set; } = new RegistroNuevoBien();


        List<CatalogoDependecias> catalogoDependecias;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            catalogoDependecias = new ()
            {
                new CatalogoDependecias 
                {
                    Id = 1,
                    Nombre = "CIS",
                    Descripcion = "CIS"
                },
                new CatalogoDependecias
                {
                    Id = 2,
                    Nombre = "CERI-CAS",
                    Descripcion = "CERI-CAS"
                },
                new CatalogoDependecias
                {
                    Id = 3,
                    Nombre = "CAS",
                    Descripcion = "CAS"
                }
            };

        }

        void Submit(RegistroNuevoBien arg)
        {
            //
        }

        void Cancel()
        {
            //
        }

        string valueDepartamento = "";
        string valueDependencia = "";
        int valueEsVehiculo = 0;

    }
}
