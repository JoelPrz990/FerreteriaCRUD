using BOL.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProveedorBLL
    {

        #region Singleton
        private static volatile ProveedorBLL instance = null;
        private static readonly object padlock = new object();
        private ProveedorDAL proveedorDAL = ProveedorDAL.Instance();
        private ProveedorBLL() { }
        public static ProveedorBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new ProveedorBLL();
            return instance;
        }
        #endregion
        public bool Add(Proveedor proveedor)
        {
            return proveedorDAL.Add(proveedor) > 0;
        }
        public bool Delete(Proveedor proveedor)
        {
            return proveedorDAL.Delete(proveedor) > 0;
        }
        public Proveedores GetAll()
        {
            return proveedorDAL.getAll();
        }
        public Proveedor GetById(Proveedor proveedor)
        {
            return proveedorDAL.GetById(proveedor);
        }
        public bool Update(Proveedor proveedor)
        {
            if (proveedorDAL.Update(proveedor) > 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
