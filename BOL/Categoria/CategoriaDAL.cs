using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BOL.Categoria
{
    public class CategoriaDAL
    {
        #region Singleton
        private static volatile CategoriaDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();
        private CategoriaDAL() { }
        public static CategoriaDAL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new CategoriaDAL();
            return instance;
        }
        #endregion

        #region add categoria
        public int Add(Categoria categoria)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@Nombre_Categoria", categoria.Nombre_Categoria);
                string query = "stp_categoria_add";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region Delete
        public int Delete(Categoria categoria)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@ID_Categoria", categoria.ID_Categoria);
                string query = "stp_categoria_delete";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region getall categoria
        public Categorias getAll()
        {
            try
            {
                string query = "stp_categoria_getall";
                DataTable resultado = dataAccess.Query(query);
                Categorias categoria = new Categorias();
                foreach (DataRow item in resultado.Rows)
                {
                    categoria.Add(new Categoria()
                    {
                        ID_Categoria = (int)item["ID_Categoria"],
                        Nombre_Categoria = (string)item["Nombre_Categoria"],
                        activo = (bool)item["activo"]
                    });
                }
                return categoria;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region getbyid
        public Categoria GetById(Categoria categoria)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@ID_Categoria", categoria.ID_Categoria);
                string query = "stp_categoria_getbyid";
                DataTable resultado = dataAccess.Query(query, parameters);
                if (resultado.Rows.Count > 0)
                {
                    categoria = new Categoria()
                    {
                        ID_Categoria = (int)resultado.Rows[0]["ID_Categoria"],
                        Nombre_Categoria = (string)resultado.Rows[0]["Nombre_Categoria"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };
                }
                return categoria;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region update
        public int Update(Categoria categoria)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@ID_Categoria", categoria.ID_Categoria);
                parameters[1] = new SqlParameter("@Nombre_Categoria", categoria.Nombre_Categoria);
                string query = "stp_categoria_update";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region getByName
        public Categoria GetByNombre(Categoria categoria)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@Nombre_Categoria", categoria.Nombre_Categoria);
                string query = "stp_categoria_getbydescripcion";
                DataTable resultado = dataAccess.Query(query, parameters);
                if (resultado.Rows.Count > 0)
                {
                    categoria = new Categoria()
                    {
                        ID_Categoria = (int)resultado.Rows[0]["ID_Categoria"],
                        Nombre_Categoria = (string)resultado.Rows[0]["Nombre_Categoria"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };
                }
                return categoria;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
