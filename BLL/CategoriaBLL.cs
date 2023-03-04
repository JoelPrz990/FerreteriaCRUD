using BOL.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaBLL
    {
        #region Singleton
        private static volatile CategoriaBLL instance = null;
        private static readonly object padlock = new object();
        private CategoriaDAL categoriaDAL = CategoriaDAL.Instance();
        private CategoriaBLL() { }
        public static CategoriaBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new CategoriaBLL();
            return instance;
        }
        #endregion
        public bool Add(Categoria categoria)
        {
            return categoriaDAL.Add(categoria) > 0;
        }
        public bool Delete(Categoria categoria)
        {
            return categoriaDAL.Delete(categoria) > 0;
        }
        public Categorias GetAll()
        {
            return categoriaDAL.getAll();
        }
        public Categoria GetById(Categoria categoria)
        {
            return categoriaDAL.GetById(categoria);
        }
        public bool Update(Categoria categoria)
        {
            if (categoriaDAL.Update(categoria) > 0)
            {
                return true;
            }
            else
                return false;
        }
        public Categoria getByDescripcion(Categoria categoria)
        {
            return categoriaDAL.GetByNombre(categoria);
        }
    }
}

