using BOL.Marca;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Proveedor
{
    public class ProveedorDAL
    {
        #region Singleton
        private static volatile ProveedorDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();
        private ProveedorDAL() { }
        public static ProveedorDAL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new ProveedorDAL();
            return instance;
        }
        #endregion

        #region add proveedor
        public int Add(Proveedor proveedor)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[4];
                parameters[0] = new SqlParameter("@Nombre_Proveedor", proveedor.Nombre_Proveedor);
                parameters[1] = new SqlParameter("@Direccion_Proveedor", proveedor.Direccion_Proveedor);
                parameters[2] = new SqlParameter("@Telefono_Proveedor", proveedor.Telefono_Proveedor);
                parameters[3] = new SqlParameter("@Email_Proveedor", proveedor.Email_Proveedor);
                string query = "stp_proveedor_add";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region Delete
        public int Delete(Proveedor proveedor)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@ID_Proveedor",proveedor.ID_Proveedor);
                string query = "stp_proveedor_delete";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region getall proveedor
        public Proveedores getAll()
        {
            try
            {
                string query = "stp_proveedor_getall";
                DataTable resultado = dataAccess.Query(query);
                Proveedores proveedor = new Proveedores();
                foreach (DataRow item in resultado.Rows)
                {
                    proveedor.Add(new Proveedor()
                    {
                        ID_Proveedor = (int)item["ID_Proveedor"],
                        Nombre_Proveedor = (string)item["Nombre_Proveedor"],
                        Direccion_Proveedor = (string)item["Direccion_Proveedor"],
                        Telefono_Proveedor = (string)item["Telefono_Proveedor"],
                        Email_Proveedor= (string)item["Email_Proveedor"],
                        activo = (bool)item["activo"]
                    });
                }
                return proveedor;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region getbyid
        public Proveedor GetById(Proveedor proveedor)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@ID_Proveedor", proveedor.ID_Proveedor);
                string query = "stp_proveedor_getbyid";
                DataTable resultado = dataAccess.Query(query, parameters);
                if (resultado.Rows.Count > 0)
                {
                    proveedor = new Proveedor()
                    {
                        ID_Proveedor = (int)resultado.Rows[0]["ID_Proveedor"],
                        Nombre_Proveedor = (string)resultado.Rows[0]["Nombre_Proveedor"],
                        Direccion_Proveedor = (string)resultado.Rows[0]["Direccion_Proveedor"],
                        Telefono_Proveedor = (string)resultado.Rows[0]["Telefono_Proveedor"],
                        Email_Proveedor= (string)resultado.Rows[0]["Email_Proveedor"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };
                }
                return proveedor;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region update
        public int Update(Proveedor proveedor)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@ID_Proveedor", proveedor.ID_Proveedor);
                parameters[1] = new SqlParameter("@Nombre_Proveedor", proveedor.Nombre_Proveedor);
                parameters[2] = new SqlParameter("@Direccion_Proveedor", proveedor.Direccion_Proveedor);
                parameters[3] = new SqlParameter("@Telefono_Proveedor", proveedor.Telefono_Proveedor);
                parameters[4] = new SqlParameter("@Email_Proveedor", proveedor.Email_Proveedor);
                string query = "stp_proveedor_update";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
