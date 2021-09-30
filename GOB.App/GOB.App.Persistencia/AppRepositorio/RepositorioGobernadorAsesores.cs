using System.Collections.Generic;
using GOB.App.Dominio;
using System.Linq;

namespace GOB.App.Persistencia
{
    public class RepositorioGobernadorAsesores : IRepositorioGobernadorAsesores
    {
        private readonly AppContext _appContext;

        public RepositorioGobernadorAsesores(AppContext appContext)
        {
            _appContext = appContext;
        }

        //CRUD
        //GetAllGobernadores
        IEnumerable<GobernadorAsesores> IRepositorioGobernadorAsesores.GetAllGobernadores()
        {
            return _appContext.gobernadores;
        }
        //GetGobernador
        GobernadorAsesores IRepositorioGobernadorAsesores.GetGobernador(int idGobernador)
        {
            var gobernadorEncontrado = _appContext.gobernadores.FirstOrDefault(p => p.id == idGobernador);
            return gobernadorEncontrado;
        }
        //AddGobernador
        GobernadorAsesores IRepositorioGobernadorAsesores.AddGobernador(GobernadorAsesores gobernador)
        {
            var gobernadorAdicionado = _appContext.gobernadores.Add(gobernador);
            _appContext.SaveChanges();
            return gobernadorAdicionado.Entity;
        }
        //UpdateGobernador
        GobernadorAsesores IRepositorioGobernadorAsesores.UpdateGobernador(GobernadorAsesores gobernador)
        {
            var gobernadorEncontrado = _appContext.gobernadores.FirstOrDefault(p => p.id == gobernador.id);
            if(gobernadorEncontrado != null)
            {
                gobernadorEncontrado.nombre = gobernador.nombre;
                gobernadorEncontrado.apellido = gobernador.apellido;
                gobernadorEncontrado.edad = gobernador.edad;
                gobernadorEncontrado.identificacion = gobernador.identificacion;
                gobernadorEncontrado.estadoSalud= gobernador.estadoSalud;

                _appContext.SaveChanges();
            }
            return gobernadorEncontrado;
        }
        //DeleteGobernador
        bool IRepositorioGobernadorAsesores.DeleteGobernador(int idGobernador)
        {
            var gobernadorEncontrado = _appContext.gobernadores.FirstOrDefault(p => p.id == idGobernador);
            if(gobernadorEncontrado == null)
            {
                return false;
            }
            _appContext.gobernadores.Remove(gobernadorEncontrado);
            _appContext.SaveChanges();
            return true;
        }

    }
}