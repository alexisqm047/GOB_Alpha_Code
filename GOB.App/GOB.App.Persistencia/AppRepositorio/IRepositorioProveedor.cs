using System.Collections.Generic;
using GOB.App.Dominio;

namespace GOB.App.Persistencia
{
    public interface IRepositorioProveedor
    {
        //CRUD
        //GetAllProveedores
        IEnumerable<Proveedor> GetAllProveedores();
        //GetProveedor
        Proveedor GetProveedor(int idProveedor);
        //AddProveedor
        Proveedor AddProveedor(Proveedor proveedor);
        //UpdateProveedor
        Proveedor UpdateProveedor(Proveedor proveedor);
        //DeleteProveedor
        bool DeleteProveedor(int idProveedor);
    }
}