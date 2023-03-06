using BOL.Cliente;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Cliente
{
    public class ClienteDAL
    {
        #region Singleton
        private static volatile ClienteDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();
        private ClienteDAL() { }
        public static ClienteDAL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new ClienteDAL();
            return instance;
        }
        #endregion

        #region add cliente
        public int Add(Cliente cliente)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[4];
                parameters[0] = new SqlParameter("@Nombre_Cliente", cliente.Direccion_Cliente);
                parameters[1] = new SqlParameter("@Direccion_Cliente", cliente.Direccion_Cliente);
                parameters[2] = new SqlParameter("@Telefono_Cliente", cliente.Telefono_Cliente);
                parameters[3] = new SqlParameter("@Email_Cliente", cliente.Email_Cliente);
                string query = "stp_cliente_add";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region Delete
        public int Delete(Cliente cliente)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@ID_Cliente", cliente.ID_Cliente);
                string query = "stp_cliente_delete";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region getall cliente
        public Clientes getAll()
        {
            try
            {
                string query = "stp_cliente_getall";
                DataTable resultado = dataAccess.Query(query);
                Clientes cliente = new Clientes();
                foreach (DataRow item in resultado.Rows)
                {
                    cliente.Add(new Cliente()
                    {
                        ID_Cliente = (int)item["ID_Cliente"],
                        Nombre_Cliente = (string)item["Nombre_Cliente"],
                        Direccion_Cliente= (string)item["Direccion_Cliente"],
                        Telefono_Cliente= (string)item["Telefono_Cliente"],
                        Email_Cliente   = (string)item["Email_Cliente"],
                        activo = (bool)item["activo"]
                    });
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region getbyid
        public Cliente GetById(Cliente cliente)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@ID_Cliente", cliente.ID_Cliente);
                string query = "stp_cliente_getbyid";
                DataTable resultado = dataAccess.Query(query, parameters);
                if (resultado.Rows.Count > 0)
                {
                    cliente = new Cliente()
                    {
                        ID_Cliente = (int)resultado.Rows[0]["ID_Cliente"],
                        Nombre_Cliente = (string)resultado.Rows[0]["Nombre_Cliente"],
                        Direccion_Cliente= (string)resultado.Rows[0]["Direccion_Cliente"],
                        Telefono_Cliente= (string)resultado.Rows[0]["Telefono_Cliente"],
                        Email_Cliente= (string)resultado.Rows[0]["Email_Cliente"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };
                }
                return cliente;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region update
        public int Update(Cliente cliente)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[4];
                parameters[0] = new SqlParameter("@ID_Cliente", cliente.ID_Cliente);
                parameters[1] = new SqlParameter("@Nombre_Categoria", cliente.Nombre_Cliente);
                parameters[2] = new SqlParameter("@Direccion_Cliente", cliente.Direccion_Cliente);
                parameters[3] = new SqlParameter("@Telefono_Cliente", cliente.Telefono_Cliente);
                parameters[4] = new SqlParameter("@Email_Cliente", cliente.Email_Cliente);
                string query = "stp_cliente_update";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region
        public Cliente GetByNombre(Cliente cliente)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@Nombre_Cliente", cliente.Nombre_Cliente);
                string query = "stp_clientes_getbyname";
                DataTable resultado = dataAccess.Query(query, parameters);
                if (resultado.Rows.Count > 0)
                {
                    cliente = new Cliente()
                    {
                        ID_Cliente = (int)resultado.Rows[0]["ID_Cliente"],
                        Nombre_Cliente = (string)resultado.Rows[0]["Nombre_Cliente"],
                        Direccion_Cliente = (string)resultado.Rows[0]["Direccion_Cliente"],
                        Telefono_Cliente = (string)resultado.Rows[0]["Telefono_Cliente"],
                        Email_Cliente = (string)resultado.Rows[0]["Email_Cliente"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };
                }
                return cliente;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
