using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GOB.App.Persistencia;
using GOB.App.Dominio;

namespace GOB.AppFrontend.Pages
{
    public class DetallesProveedorModel : PageModel
    {
        private static IRepositorioProveedor _repoProveedor = new RepositorioProveedor(new GOB.App.Persistencia.AppContext());
        public Proveedor proveedor;

        public IActionResult OnGet(int proveedorId)
        {

            proveedor = _repoProveedor.GetProveedor(proveedorId);
            if (proveedor == null)
            {
                return RedirectToPage("./Proveedores");
            }
            else
                return Page();

        }
    }
}
