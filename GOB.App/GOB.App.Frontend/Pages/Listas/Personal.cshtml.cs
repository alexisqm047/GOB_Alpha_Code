using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using GOB.App.Persistencia;
using GOB.App.Dominio;
// Julian 
namespace GOB.AppFrontend.Pages
{
    [Authorize]
    public class PersonalModel : PageModel
    {
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new GOB.App.Persistencia.AppContext());
        public IEnumerable<PersonalAseo> Personal{get;set;}
        public void OnGet()
        {
            Personal = _repoPersonalAseo.GetAllPersonalAseo();
        }
    }
}