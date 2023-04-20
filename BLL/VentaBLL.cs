using BOL.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VentaBLL
    {

        #region Singleton
        private static volatile VentaBLL instance = null;
        private static readonly object padlock = new object();
        private VentaDAL ventaDAL = VentaDAL.Instance();
        private VentaBLL() { }
        public static VentaBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new VentaBLL();
            return instance;
        }
        #endregion
        public bool Add(Venta venta)
        {
            return ventaDAL.Add(venta) > 0;
        }
        public bool Delete(Venta venta)
        {
            return ventaDAL.Delete(venta) > 0;
        }
        public Ventas GetAll()
        {
            return ventaDAL.getAll();
        }
        public Venta GetById(Venta venta)
        {
            return ventaDAL.GetById(venta);
        }
        public bool Update(Venta venta)
        {
            if (ventaDAL.Update(venta) > 0)
            {
                return true;
            }
            else
                return false;
        }
        public Ventas GetArchivo()
        {
            return ventaDAL.getArchivo();
        }
    }
}
