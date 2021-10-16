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
    public class EditarPersonalModel : PageModel
    {
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new GOB.App.Persistencia.AppContext());
        [BindProperty]
        public PersonalAseo personal{get;set;}

        public IActionResult OnGet(int? personalId)
        {
            if(personalId.HasValue)
            {
                personal = _repoPersonalAseo.GetEmpleadoAseo(personalId.Value);
            }else
            {
                personal = new PersonalAseo();
            }

            if(personal==null)
            {
                return RedirectToPage("./Personal");
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
                if (personal.id>0)
                {
                    _repoPersonalAseo.UpdateEmpleadoAseo(personal);
                }else
                {
                    _repoPersonalAseo.AddEmpleadoAseo(personal);
                }
            }
            return RedirectToPage("./Personal");
        }
    }
}
