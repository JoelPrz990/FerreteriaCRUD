using BOL.Empleado;
using BOL.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductoBLL
    {
        #region Singleton
        private static volatile ProductoBLL instance = null;
        private static readonly object padlock = new object();
        private ProductoDAL productoDAL = ProductoDAL.Instance();
        private ProductoBLL() { }
        public static ProductoBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new ProductoBLL();
            return instance;
        }
        #endregion
        public bool Add(Producto producto)
        {
            return productoDAL.Add(producto) > 0;
        }
        public bool Delete(Producto producto)
        {
            return productoDAL.Delete(producto) > 0;
        }
        public Productos GetAll()
        {
            return productoDAL.getAll();
        }
        public Producto GetById(Producto producto)
        {
            return productoDAL.GetById(producto);
        }
        public bool Update(Producto producto)
        {
            if (productoDAL.Update(producto) > 0)
            {
                return true;
            }
            else
                return false;
        }
        public Producto getByName(Producto producto)
        {
            return productoDAL.GetByName(producto);
        }
    }
}
