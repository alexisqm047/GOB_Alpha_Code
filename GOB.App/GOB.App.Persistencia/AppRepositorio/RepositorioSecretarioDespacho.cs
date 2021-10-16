using System.Collections.Generic;
using GOB.App.Dominio;
using System.Linq;

namespace GOB.App.Persistencia
{
    public class RepositorioSecretarioDespacho : IRepositorioSecretarioDespacho
    {
        private static AppContext _appContext;

        public RepositorioSecretarioDespacho(AppContext appContext)
        {
            _appContext = appContext;
        }

        //CRUD
        //GetAllSecretarios
        IEnumerable<SecretariosDespacho> IRepositorioSecretarioDespacho.GetAllSecretarios()
        {
            return _appContext.SecretariosDespacho;
        }
        //GetSecretario
        SecretariosDespacho IRepositorioSecretarioDespacho.GetSecretario(int idSecretario)
        {
            var secretarioEncontrado = _appContext.SecretariosDespacho.FirstOrDefault(p => p.id == idSecretario);
            return secretarioEncontrado;
        }
        //AddSecretario
        SecretariosDespacho IRepositorioSecretarioDespacho.AddSecretario(SecretariosDespacho Secretario)
        {
            var SecretarioAdicionado = _appContext.SecretariosDespacho.Add(Secretario);
            _appContext.SaveChanges();
            return SecretarioAdicionado.Entity;
        }
        //UpdateSecretario
        SecretariosDespacho IRepositorioSecretarioDespacho.UpdateSecretario(SecretariosDespacho Secretario)
        {
            var secretarioEncontrado = _appContext.SecretariosDespacho.FirstOrDefault(p => p.id == Secretario.id);
            if(secretarioEncontrado != null)
            {
                secretarioEncontrado.nombre = Secretario.nombre;
                secretarioEncontrado.apellido = Secretario.apellido;
                secretarioEncontrado.edad = Secretario.edad;
                secretarioEncontrado.identificacion = Secretario.identificacion;
                secretarioEncontrado.estadoSalud= Secretario.estadoSalud;
                secretarioEncontrado.despacho = Secretario.despacho;

                _appContext.SaveChanges();
            }
            return secretarioEncontrado;
        }
        //DeleteSecretario
        bool IRepositorioSecretarioDespacho.DeleteSecretario(int idSecretario)
        {
            var secretarioEncontrado = _appContext.SecretariosDespacho.FirstOrDefault(p => p.id == idSecretario);
            if(secretarioEncontrado == null)
            {
                return false;
            }
            _appContext.SecretariosDespacho.Remove(secretarioEncontrado);
            _appContext.SaveChanges();
            return true;
        }

    }
}