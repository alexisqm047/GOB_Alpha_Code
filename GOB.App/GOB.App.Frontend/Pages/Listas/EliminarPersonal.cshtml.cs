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
    public class EliminarPersonalModel : PageModel
    {

        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new GOB.App.Persistencia.AppContext());
        [BindProperty]
        public PersonalAseo personal{get;set;}
        public IActionResult OnGet(int personalId)
        {
            personal = _repoPersonalAseo.GetEmpleadoAseo(personalId);
            return Page();
        }

        public IActionResult OnPost()
        {
            _repoPersonalAseo.DeleteEmpleadoAseo(personal.id);
            return RedirectToPage("./Personal");
        }
    }
}
