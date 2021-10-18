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
    public class GobernadoresModel : PageModel
    {
        private static IRepositorioGobernadorAsesores _repoGobernador = new RepositorioGobernadorAsesores(new GOB.App.Persistencia.AppContext());
        public IEnumerable<GobernadorAsesores> Gobernadores{get;set;}
        public void OnGet()
        {
            Gobernadores = _repoGobernador.GetAllGobernadores();
        }
    }
}
