using System.Collections.Generic;
using GOB.App.Dominio;

namespace GOB.App.Persistencia
{
    public interface IRepositorioPersonalAseo
    {
        //CRUD...
        //Julian
        //GetAllPersonalAseo, metodo que nos recupera la info relacionada al personal de aseo
        IEnumerable<PersonalAseo> GetAllPersonalAseo(); //Firma del metodo, Estructura de datos que almacena elementos de la clase personal de aseo

        //GetEmpleadoAseo, metodo para obtener un unico empleado del aseo
        PersonalAseo GetEmpleadoAseo(int idEmpleadoAseo); //Pasamos el id del empleado

        //AddEmpleadoAseo, metodo para agregar un nuevo empleado del aseo
        PersonalAseo AddEmpleadoAseo(PersonalAseo empleadoAseo); //Pasamos el empleado del aseo construido

        //UpdateEmpleadoAseo, metodo para actualizar info de un empleado aseo
        PersonalAseo UpdateEmpleadoAseo(PersonalAseo empleadoAseo);

        //DeleteEmpleadoAseo, metodo para borrar a un empleado del aseo
        bool DeleteEmpleadoAseo(int idEmpleadoAseo);
    }
}