using System.Collections.Generic;
using GOB.App.Dominio;
using System.Linq;

namespace GOB.App.Persistencia
{
    public class RepositorioProveedor : IRepositorioProveedor
    {
        private static AppContext _appContext;

        public RepositorioProveedor(AppContext appContext)
        {
            _appContext = appContext;
        }

        //CRUD
        //GetAllProveedores
        IEnumerable<Proveedor> IRepositorioProveedor.GetAllProveedores()
        {
            return _appContext.proveedor;            
        }

        //GetProveedor
        Proveedor IRepositorioProveedor.GetProveedor(int idProveedor)
        {
            var proveedorEncontrado = _appContext.proveedor.FirstOrDefault (p => p.id == idProveedor);
            return proveedorEncontrado;
        }

        //AddProveedor
        Proveedor IRepositorioProveedor.AddProveedor(Proveedor proveedor)
        {
            var proveedorAdicionado = _appContext.proveedor.Add(proveedor);
            _appContext.SaveChanges();
            return proveedorAdicionado.Entity;
        }

        //UpdateProveedor
        Proveedor IRepositorioProveedor.UpdateProveedor(Proveedor proveedor)
        {
            var proveedorEncontrado = _appContext.proveedor.FirstOrDefault (p => p.id == proveedor.id);
            if(proveedorEncontrado != null)
            {
                proveedorEncontrado.nombre = proveedor.nombre;
                proveedorEncontrado.apellido = proveedor.apellido;
                proveedorEncontrado.edad = proveedor.edad;
                proveedorEncontrado.identificacion = proveedor.identificacion;
                proveedorEncontrado.estadoSalud= proveedor.estadoSalud;
                proveedorEncontrado.servicio = proveedor.servicio;
                proveedorEncontrado.lugarServicio = proveedor.lugarServicio;

                _appContext.SaveChanges();
            }
            return proveedorEncontrado;
        }
        
        //DeleteProveedor
        bool IRepositorioProveedor.DeleteProveedor(int idProveedor)
        {
            var proveedorEncontrado = _appContext.proveedor.FirstOrDefault (p => p.id == idProveedor);
            if(proveedorEncontrado == null)
            {
                return false;
            }
            _appContext.proveedor.Remove(proveedorEncontrado);
            _appContext.SaveChanges();
            return true;
        }
    }
}