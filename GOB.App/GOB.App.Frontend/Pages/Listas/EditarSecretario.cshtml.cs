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
    public class EditarSecretarioModel : PageModel
    {
        private static IRepositorioSecretarioDespacho _repoSecretarioDespacho = new RepositorioSecretarioDespacho(new GOB.App.Persistencia.AppContext());
        [BindProperty]
        public SecretariosDespacho secretario{get;set;}

        public IActionResult OnGet(int? secretarioId)
        {
            if(secretarioId.HasValue)
            {
                secretario = _repoSecretarioDespacho.GetSecretario(secretarioId.Value);
            }else 
            {
                secretario = new SecretariosDespacho();
            }
            
            if(secretario==null)
            {
                return RedirectToPage("./Secretarios");
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
                if (secretario.id>0)
                {
                    _repoSecretarioDespacho.UpdateSecretario(secretario);
                }else
                {
                    _repoSecretarioDespacho.AddSecretario(secretario);
                }
            }
            
            return RedirectToPage("./Secretarios");
        }
    }
}
