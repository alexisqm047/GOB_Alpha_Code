using System;
using GOB.App.Dominio;
using GOB.App.Persistencia;
using System.Collections.Generic;

namespace GOB.App.Consola
{
    class Program
    {
        //probando 
        private static IRepositorioGobernadorAsesores _repoGobernador = new RepositorioGobernadorAsesores(new Persistencia.AppContext());
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());
        private static IRepositorioSecretarioDespacho _repoSecretarioDespacho = new RepositorioSecretarioDespacho(new Persistencia.AppContext());
        private static IRepositorioProveedor _repoProveedor = new RepositorioProveedor(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AdicionarProveedor();
            //AdicionarGobernador();
            //AdicionarPersonalAseo();
            //AdicionarSecretarioDespacho();
            //ActualizarGobernador(1);
            //ActualizarProveedor(1);
            //EncontrarGobernador(2);
            //EncontrarGobernadores();
            //EncontrarProveedor(1);
            //EliminarGobernador(3);
            //EliminarProveedor(1);
        }
        //CRUD
        //AdicionarGobernadores
        private static void AdicionarGobernador()
        {
            var gobernador = new GobernadorAsesores
            {
                nombre     = "Sara",
                apellido   = "Corredor",
                edad       =  35,
                identificacion = 100002,
                estadoSalud = EstadoSalud.Enfermo
            };
            _repoGobernador.AddGobernador(gobernador);
        }
        //ActualizarGobernador
        private static void ActualizarGobernador(int idGobernador)
        {
            var gobernador = new GobernadorAsesores
            {
                id = idGobernador,
                nombre     = "Santiago",
                apellido   = "Murillo",
                edad       =  47,
                identificacion = 100000,
                estadoSalud = EstadoSalud.Enfermo
            };
            GobernadorAsesores gobernadorActualizado= _repoGobernador.UpdateGobernador(gobernador);
            if(gobernadorActualizado != null)
            {
                Console.WriteLine("Se actualizo el profesor");
            }
        }

        //EncontrarGobernador
        private static void EncontrarGobernador(int idGobernador)
        {
            var gobernadorEncontrado = _repoGobernador.GetGobernador(idGobernador);
            Console.WriteLine(gobernadorEncontrado.nombre);
        }
        //EncontrarGobernadores
        private static void EncontrarGobernadores()
        {
            IEnumerable<GobernadorAsesores> gobernadores = _repoGobernador.GetAllGobernadores();
            foreach (var gobernador in gobernadores)
            {
                Console.WriteLine(gobernador.nombre+" "+gobernador.apellido);
            }
        }
        //EliminarGobernador
        private static void EliminarGobernador(int idGobernador)
        {
            bool bandera = _repoGobernador.DeleteGobernador(idGobernador);
            if(bandera)
            {
                Console.WriteLine("Se elimino profesor");
            }else
            {
                Console.WriteLine("Error en base de datos");
            }
        }

        //CRUD PersonalAseo
        // AdicionarPersonalAseo
        private static void AdicionarPersonalAseo()
        {
            var EmpleadoAseo = new PersonalAseo
            {
                nombre      = "Camilo",
                apellido    = "Correal",
                edad        = 39,
                identificacion = 0223,
                estadoSalud = EstadoSalud.Saludable,
                turno = "Diurno" // Comentar
            };
            _repoPersonalAseo.AddEmpleadoAseo(EmpleadoAseo);
        }

        // ActualizarPersonal
        private static void ActualizarPersonal(int idEmpleadoAseo)
        {
            var personal = new PersonalAseo
            {
                id = idEmpleadoAseo,
                nombre     = "Julian",
                apellido   = "Perez",
                edad       = 35,
                identificacion = 687263,
                estadoSalud = EstadoSalud.Enfermo,
                turno = "Noche" // Comentar
            };
            PersonalAseo empleadoAseoActualizado = _repoPersonalAseo.UpdateEmpleadoAseo(personal);
            if(empleadoAseoActualizado != null)
            {
                Console.WriteLine("Se actualizo el empleado del aseo");
            }
        }

        // EncontrarEmpleadoAseo
        private static void EncontrarEmpleadoAseo(int idEmpleadoAseo)
        {
            var empleadoAseoEncontrado = _repoPersonalAseo.GetEmpleadoAseo(idEmpleadoAseo);
            Console.WriteLine(empleadoAseoEncontrado.nombre);
        }
        // EncontrarPersonalAseo
        private static void EncontrarPersonalAseo()
        {
            IEnumerable<PersonalAseo> personal =_repoPersonalAseo.GetAllPersonalAseo();
            foreach(var empleado in personal)
            {
                Console.WriteLine(empleado.nombre + " " + empleado.apellido);
            }
        }

        //EliminarEmpleadoAseo
        private static void EliminarEmpleadoAseo(int idEmpleadoAseo)
        {
            bool bandera = _repoPersonalAseo.DeleteEmpleadoAseo(idEmpleadoAseo);
            if(bandera)
            {
                Console.WriteLine("Se elimino el empleado del aseo");
            }else
            {
                Console.WriteLine("Error en base de datos");
            }
        }
        //CRUD
        //AdicionarSecretarioDespacho
        private static void AdicionarSecretarioDespacho()
        {
            var Secretario = new SecretariosDespacho
            {
                nombre      = "David",
                apellido    = "Morales",
                edad        = 55,
                identificacion = 0026,
                estadoSalud = EstadoSalud.Saludable,
                despacho = "A19" // Comentar
            };
            _repoSecretarioDespacho.AddSecretario(Secretario);
        }

        // ActualizarSecretarioDespacho
        private static void ActualizarSecretarioDespacho(int idSecretario)
        {
            var Secretario = new SecretariosDespacho
            {
                id = idSecretario,
                nombre      = "David",
                apellido    = "Morales",
                edad        = 56,
                identificacion = 0026,
                estadoSalud = EstadoSalud.Saludable,
                despacho = "A22" // Comentar
            };
            SecretariosDespacho secretarioActualizado = _repoSecretarioDespacho.UpdateSecretario(Secretario);
            if(secretarioActualizado != null)
            {
                Console.WriteLine("Se actualizo el Secretario ");
            }
        }
        // EncontrarSecretarioDespacho
        private static void EncontrarSecretarioDespacho(int idSecretario)
        {
            var secretarioEncontrado = _repoSecretarioDespacho.GetSecretario(idSecretario);
            Console.WriteLine(secretarioEncontrado.nombre);
        }
        // EncontrarSecretariosDespacho
        private static void EncontrarSecretariosDespacho()
        {
            IEnumerable<SecretariosDespacho> secretarios =_repoSecretarioDespacho.GetAllSecretarios();
            foreach(var secretario in secretarios)
            {
                Console.WriteLine(secretario.nombre + " " + secretario.apellido);
            }
        }

        //Adicionar Proveedor
        private static void AdicionarProveedor()
        {
            var proveedor = new Proveedor
            {
                nombre      = "Camilo",
                apellido    = "Marin",
                edad        = 30,
                identificacion = 105387645,
                servicio = "Plomeria",
                lugarServicio = "Baño gobernador"
                
            };
            _repoProveedor.AddProveedor(proveedor);
        }

        private static void ActualizarProveedor(int idProveedor)
        {
            var proveedor = new Proveedor
            {
                id = idProveedor,
                nombre      = "Camilo",
                apellido    = "Marin",
                edad        = 30,
                identificacion = 105387645,
                servicio = "Electridad",
                lugarServicio = "Oficina Gobernador"
            };
            Proveedor proveedorActualizado = _repoProveedor.UpdateProveedor(proveedor);
            if(proveedorActualizado != null)
            {
                Console.WriteLine("Se actualizo el Proveedor ");
            }
        }

        // EncontrarProveedor
        private static void EncontrarProveedor(int idProveedor)
        {
            var proveedorEncontrado = _repoProveedor.GetProveedor(idProveedor);
            Console.WriteLine(proveedorEncontrado.nombre);
        }

        //EliminarProveedor
        private static void EliminarProveedor(int idProveedor)
        {
            bool bandera = _repoProveedor.DeleteProveedor(idProveedor);
            if(bandera)
            {
                Console.WriteLine("Se elimino el Proveedor");
            }else
            {
                Console.WriteLine("Error en base de datos");
            }
        }
        
    }
}
