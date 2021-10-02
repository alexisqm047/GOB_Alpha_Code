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
    public class SecretariosModel : PageModel
    {
        //prueba
        private static IRepositorioSecretarioDespacho _repoSecretarioDespacho = new RepositorioSecretarioDespacho(new GOB.App.Persistencia.AppContext());
        public IEnumerable<SecretariosDespacho> Secretarios{get;set;}

        public void OnGet()
        {
            Secretarios = _repoSecretarioDespacho.GetAllSecretarios();
        }
    }
}
