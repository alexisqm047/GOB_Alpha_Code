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
    public class DetallesGobernadorModel : PageModel
    {
        private static IRepositorioGobernadorAsesores _repoGobernador = new RepositorioGobernadorAsesores(new GOB.App.Persistencia.AppContext());
        public GobernadorAsesores gobernador;

        public IActionResult OnGet(int gobernadorId)
        {
            gobernador = _repoGobernador.GetGobernador(gobernadorId);
            if (gobernador == null)
            {
                return RedirectToPage("./Gobernadores");
            }
            else
                return Pages();
        }
    }
}