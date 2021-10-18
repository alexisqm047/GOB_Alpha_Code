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
    public class DetallesSecretarioModel : PageModel
    {
        private static IRepositorioSecretarioDespacho _repoSecretarioDespacho = new RepositorioSecretarioDespacho(new GOB.App.Persistencia.AppContext());
        public SecretariosDespacho secretario;

        public IActionResult OnGet(int secretarioId)
        {

            secretario = _repoSecretarioDespacho.GetSecretario(secretarioId);
            if (secretario == null)
            {
                return RedirectToPage("./Secretarios");
            }
            else
                return Page();

        }
    }
}
