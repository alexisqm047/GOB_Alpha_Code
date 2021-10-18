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
    public class DetallesPersonalModel : PageModel
    {
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new GOB.App.Persistencia.AppContext());
        public PersonalAseo personal;

        public IActionResult OnGet(int personalId)
        {
            personal = _repoPersonalAseo.GetEmpleadoAseo(personalId);
            if (personal == null)
            {
                return RedirectToPage("./Personal");
            }
            else
                return Page();
        }
    }
}