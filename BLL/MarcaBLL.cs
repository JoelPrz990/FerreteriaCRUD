using BOL.Marca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MarcaBLL
    {
        #region Singleton
        private static volatile MarcaBLL instance = null;
        private static readonly object padlock = new object();
        private MarcaDAL marcaDAL = MarcaDAL.Instance();
        private MarcaBLL() { }
        public static MarcaBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new MarcaBLL();
            return instance;
        }
        #endregion
        public bool Add(Marca marca)
        {
            return marcaDAL.Add(marca) > 0;
        }
        public bool Delete(Marca marca)
        {
            return marcaDAL.Delete(marca) > 0;
        }
        public Marcas GetAll()
        {
            return marcaDAL.getAll();
        }
        public Marca GetById(Marca marca)
        {
            return marcaDAL.GetById(marca);
        }
        public bool Update(Marca marca)
        {
            if (marcaDAL.Update(marca) > 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
