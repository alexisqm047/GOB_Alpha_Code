using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using GOB.App.Dominio;
using GOB.App.Persistencia;

namespace GOB.AppFrontend.Pages
{
    public class EliminarProveedorModel : PageModel
    {
        private static IRepositorioProveedor _repoProveedor = new RepositorioProveedor(new GOB.App.Persistencia.AppContext());
        [BindProperty]
        public Proveedor proveedor{get;set;}
        public IActionResult OnGet(int proveedorId)
        {
            proveedor = _repoProveedor.GetProveedor(proveedorId);       
            return Page();
        }

        public IActionResult OnPost()
        {
            _repoProveedor.DeleteProveedor(proveedor.id);
            return RedirectToPage("./Proveedores");
        }
    }
}
