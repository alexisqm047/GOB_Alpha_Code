using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using GOB.App.Persistencia;
using GOB.App.Dominio;

namespace GOB.AppFrontend.Pages
{
    [Authorize]
    public class ProveedoresModel : PageModel
    {
        private static IRepositorioProveedor _repoProveedor = new RepositorioProveedor(new GOB.App.Persistencia.AppContext());
        public IEnumerable<Proveedor> Proveedores{get;set;}
        public void OnGet()
        {
            Proveedores = _repoProveedor.GetAllProveedores();
        }
    }
}
