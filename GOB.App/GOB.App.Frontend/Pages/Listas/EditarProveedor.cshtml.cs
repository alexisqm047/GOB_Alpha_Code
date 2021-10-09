using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GOB.App.Dominio;
using GOB.App.Persistencia;

namespace GOB.AppFrontend.Pages
{
    public class EditarProveedorModel : PageModel
    {
        private static IRepositorioProveedor _repoproveedor = new RepositorioProveedor(new GOB.App.Persistencia.AppContext());
        [BindProperty]
        public Proveedor proveedor{get;set;}

        public IActionResult OnGet(int? proveedorId)
        {
            if(proveedorId.HasValue)
            {
                proveedor = _repoproveedor.GetProveedor(proveedorId.Value);
            }else 
            {
                proveedor = new Proveedor();

            }
            
            if(proveedor==null)
            {
                return RedirectToPage("./Proveedores");
            }
            return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }else 
            {
                if (proveedor.id>0)
                {
                    _repoproveedor.UpdateProveedor(proveedor);
                }else
                {
                    _repoproveedor.AddProveedor(proveedor);
                }
            }
            
            return RedirectToPage("./Proveedores");
        }
    }
}
