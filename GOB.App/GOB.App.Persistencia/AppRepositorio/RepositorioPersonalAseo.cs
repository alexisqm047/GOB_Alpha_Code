using System.Collections.Generic;
using GOB.App.Dominio;
using System.Linq;

namespace GOB.App.Persistencia
{
    public class RepositorioPersonalAseo : IRepositorioPersonalAseo
    {
        private static AppContext _appContext;

        public RepositorioPersonalAseo(AppContext appContext)
        {
            _appContext = appContext;
        }

        //CRUD
        //GetAllPersonalAseo
        IEnumerable<PersonalAseo> IRepositorioPersonalAseo.GetAllPersonalAseo()
        {
            return _appContext.personal;
        }

        //GetEmpleadoAseo
        PersonalAseo IRepositorioPersonalAseo.GetEmpleadoAseo(int idEmpleadoAseo)
        {
            var empleadoAseoEncontrado = _appContext.personal.FirstOrDefault(p => p.id == idEmpleadoAseo);
            return empleadoAseoEncontrado;
        }

        //AddEmpleadoAseo
        PersonalAseo IRepositorioPersonalAseo.AddEmpleadoAseo(PersonalAseo EmpleadoAseo)
        {
            var empleadoAseoAdicionado = _appContext.personal.Add(EmpleadoAseo);
            _appContext.SaveChanges();
            return empleadoAseoAdicionado.Entity;
        }

        //UpdateEmpleadoAseo
        PersonalAseo IRepositorioPersonalAseo.UpdateEmpleadoAseo(PersonalAseo EmpleadoAseo)
        {
            var empleadoAseoEncontrado = _appContext.personal.FirstOrDefault(p => p.id == EmpleadoAseo.id);
            if(empleadoAseoEncontrado != null)
            {
                empleadoAseoEncontrado.nombre = EmpleadoAseo.nombre;
                empleadoAseoEncontrado.apellido = EmpleadoAseo.apellido;
                empleadoAseoEncontrado.edad = EmpleadoAseo.edad;
                empleadoAseoEncontrado.identificacion = EmpleadoAseo.identificacion;
                empleadoAseoEncontrado.estadoSalud = EmpleadoAseo.estadoSalud;
                empleadoAseoEncontrado.turno = EmpleadoAseo.turno;

                _appContext.SaveChanges();
            }
            return empleadoAseoEncontrado;
        }

        //DeleteEmpleadoAseo
        bool IRepositorioPersonalAseo.DeleteEmpleadoAseo(int idEmpleadoAseo)
        {
            var empleadoAseoEncontrado = _appContext.personal.FirstOrDefault(p => p.id == idEmpleadoAseo);
            if(empleadoAseoEncontrado == null)
            {
                return false;
            }
            _appContext.personal.Remove(empleadoAseoEncontrado);
            _appContext.SaveChanges();
            return true;
        }

    }
}