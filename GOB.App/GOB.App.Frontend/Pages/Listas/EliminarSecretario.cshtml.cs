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
    public class EliminarSecretarioModel : PageModel
    {

        private static IRepositorioSecretarioDespacho _repoSecretarioDespacho = new RepositorioSecretarioDespacho(new GOB.App.Persistencia.AppContext());
        [BindProperty]
        public SecretariosDespacho secretario{get;set;}
        public IActionResult OnGet(int secretarioId)
        {
            secretario = _repoSecretarioDespacho.GetSecretario(secretarioId);       
            return Page();
        }

        public IActionResult OnPost()
        {
            _repoSecretarioDespacho.DeleteSecretario(secretario.id);
            return RedirectToPage("./Secretarios");
        }
    }
}
