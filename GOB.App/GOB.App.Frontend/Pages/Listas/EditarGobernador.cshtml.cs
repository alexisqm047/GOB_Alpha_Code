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
    public class EditarGobernadorModel : PageModel
    {
        private static IRepositorioGobernadorAsesores _repoGobernador = new RepositorioGobernadorAsesores(new GOB.App.Persistencia.AppContext());
        [BindProperty]
        public GobernadorAsesores gobernador{get;set;}

        public IActionResult OnGet(int? gobernadorId)
        {
            if(gobernadorId.HasValue)
            {
                gobernador = _repoGobernador.GetGobernador(gobernadorId.Value);
            }else
            {
                gobernador = new GobernadorAsesores();
            }

            if(gobernador==null)
            {
                return RedirectToPage("./Gobernadores");
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
                if (gobernador.id>0)
                {
                    _repoGobernador.UpdateGobernador(gobernador);
                }else
                {
                    _repoGobernador.AddGobernador(gobernador);
                }
            }

            return RedirectToPage("./Gobernadores");
        }
    }
}