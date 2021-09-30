using System.Collections.Generic;
using GOB.App.Dominio;

namespace GOB.App.Persistencia
{
    public interface IRepositorioSecretarioDespacho
    {
        //CRUD
        //GetAllSecretarios
        IEnumerable<SecretariosDespacho> GetAllSecretarios();
        //GetSecretario
        SecretariosDespacho GetSecretario(int idSecretario);
        //AddSecretario
        SecretariosDespacho AddSecretario(SecretariosDespacho Secretario);
        //UpdateSecretario
        SecretariosDespacho UpdateSecretario(SecretariosDespacho Secretario);
        //DeleteSecretario
        bool DeleteSecretario(int idSecretario);
    }
}