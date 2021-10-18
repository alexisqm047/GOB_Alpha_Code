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
    public class EliminarGobernadorModel : PageModel
    {
        private static IRepositorioGobernadorAsesores _repoGobernador = new RepositorioGobernadorAsesores(new GOB.App.Persistencia.AppContext());
        [BindProperty]
        public GobernadorAsesores gobernador {get;set;}
        public IActionResult OnGet(int gobernadorId)
        {
            gobernador = _repoGobernador.GetGobernador(gobernadorId);
            return Page();
        }

        public IActionResult OnPost()
        {
            _repoGobernador.DeleteGobernador(gobernador.id);
            return RedirectToPage("./Gobernadores");
        }
    }
}