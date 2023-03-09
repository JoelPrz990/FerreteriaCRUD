using BOL.Categoria;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Marca
{
    public class MarcaDAL
    {
        #region Singleton
        private static volatile MarcaDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();
        private MarcaDAL() { }
        public static MarcaDAL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new MarcaDAL();
            return instance;
        }
        #endregion

        #region add marca
        public int Add(Marca marca)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@ID_Proveedor", marca.ID_Proveedor);
                parameters[1] = new SqlParameter("@Nombre_Marca", marca.Nombre_Marca);
                string query = "stp_marcas_add";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region Delete
        public int Delete(Marca marca)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@ID_Marca", marca.ID_Marca);
                string query = "stp_marcas_delete";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region getall marca
        public Marcas getAll()
        {
            try
            {
                string query = "stp_marcas_getall";
                DataTable resultado = dataAccess.Query(query);
                Marcas marca = new Marcas();
                foreach (DataRow item in resultado.Rows)
                {
                    marca.Add(new Marca()
                    {
                        ID_Marca = (int)item["ID_Marca"],
                        ID_Proveedor = (int)item["ID_Proveedor"],
                        Nombre_Marca = (string)item["Nombre_Marca"],
                        activo = (bool)item["activo"]
                    });
                }
                return marca;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region getbyid
        public Marca GetById(Marca marca)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@ID_Marca", marca.ID_Marca);
                string query = "stp_marcas_getbyid";
                DataTable resultado = dataAccess.Query(query, parameters);
                if (resultado.Rows.Count > 0)
                {
                    marca = new Marca()
                    {
                        ID_Marca = (int)resultado.Rows[0]["ID_Marca"],
                        ID_Proveedor = (int)resultado.Rows[0]["ID_Proveedor"],
                        Nombre_Marca = (string)resultado.Rows[0]["Nombre_Marca"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };
                }
                return marca;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region update
        public int Update(Marca marca)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@ID_Marca", marca.ID_Marca);
                parameters[1] = new SqlParameter("@ID_Proveedor", marca.ID_Proveedor);
                parameters[2] = new SqlParameter("@Nombre_Marca", marca.Nombre_Marca);
                string query = "stp_marcas_update";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        public Marca GetByNombre(Marca marca)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@Nombre_Marca", marca.Nombre_Marca);
                string query = "stp_marca_getbynombre";
                DataTable resultado = dataAccess.Query(query, parameters);
                if (resultado.Rows.Count > 0)
                {
                    marca = new Marca()
                    {
                        ID_Marca = (int)resultado.Rows[0]["ID_Marca"],
                        ID_Proveedor = (int)resultado.Rows[0]["ID_Proveedor"],
                        Nombre_Marca = (string)resultado.Rows[0]["Nombre_Marca"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };
                }
                return marca;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
