using System.Collections.Generic;
using GOB.App.Dominio;

namespace GOB.App.Persistencia
{
    public interface IRepositorioGobernadorAsesores
    {
        //CRUD
        //GetAllGobernadores
        IEnumerable<GobernadorAsesores> GetAllGobernadores();
        //GetGobernador
        GobernadorAsesores GetGobernador(int idGobernador);
        //AddGobernador
        GobernadorAsesores AddGobernador(GobernadorAsesores gobernador);
        //UpdateGobernador
        GobernadorAsesores UpdateGobernador(GobernadorAsesores gobernador);
        //DeleteGobernador
        bool DeleteGobernador(int idGobernador);
    }
}