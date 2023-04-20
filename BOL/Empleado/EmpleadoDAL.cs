using BOL.Cliente;
using DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Empleado
{
    public class EmpleadoDAL
    {
        #region Singleton
        private static volatile EmpleadoDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();
        private EmpleadoDAL() { }
        public static EmpleadoDAL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new EmpleadoDAL();
            return instance;
        }
        #endregion

        #region add empleado
        public int Add(Empleado empleado)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[7];
                parameters[0] = new SqlParameter("@Nombre_Empleado",empleado.Nombre_Empleado);
                parameters[1] = new SqlParameter("@Direccion_Empleado", empleado.Direccion_Empleado);
                parameters[2] = new SqlParameter("@Telefono_Empleado", empleado.Telefono_Empleado);
                parameters[3] = new SqlParameter("@Email_Empleado", empleado.Email_Empleado);
                parameters[4] = new SqlParameter("@Cargo_Empleado", empleado.Cargo_Empleado);
                parameters[5] = new SqlParameter("@password", empleado.password);
                parameters[6] = new SqlParameter("@Nombre_Usuario", empleado.Nombre_Usuario);

                string query = "stp_empleado_add";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region Delete
        public int Delete(Empleado empleado)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@ID_Empleado", empleado.ID_Empleado);
                string query = "stp_empleado_delete";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region getall cliente
        public Empleados getAll()
        {
            try
            {
                string query = "stp_empleado_getall";
                DataTable resultado = dataAccess.Query(query);
                Empleados empleados = new Empleados();
                foreach (DataRow item in resultado.Rows)
                {
                    empleados.Add(new Empleado()
                    {
                        ID_Empleado = (int)item["ID_Empleado"],
                        Nombre_Empleado = (string)item["Nombre_Empleado"],
                        Direccion_Empleado = (string)item["Direccion_Empleado"],
                        Telefono_Empleado = (string)item["Telefono_Empleado"],
                        Email_Empleado = (string)item["Email_Empleado"],
                        Cargo_Empleado = (string)item["Cargo_Empleado"],
                        activo = (bool)item["activo"],
                        password = (string)item["Password"],
                        Nombre_Usuario = (string)item["Nombre_Usuario"]
                    });
                }
                return empleados;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region getbyid
        public Empleado GetById(Empleado empleado)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@ID_Empleado", empleado.ID_Empleado);
                string query = "stp_empleado_getbyid";
                DataTable resultado = dataAccess.Query(query, parameters);
                if (resultado.Rows.Count > 0)
                {
                    empleado = new Empleado()
                    {
                        ID_Empleado = (int)resultado.Rows[0]["ID_Empleado"],
                        Nombre_Empleado = (string)resultado.Rows[0]["Nombre_Empleado"],
                        Direccion_Empleado = (string)resultado.Rows[0]["Direccion_Empleado"],
                        Telefono_Empleado = (string)resultado.Rows[0]["Telefono_Empleado"],
                        Email_Empleado = (string)resultado.Rows[0]["Email_Empleado"],
                        Cargo_Empleado = (string)resultado.Rows[0]["Cargo_Empleado"],
                        activo = (bool)resultado.Rows[0]["activo"],
                        password = (string)resultado.Rows[0]["password"],
                        Nombre_Usuario = (string)resultado.Rows[0]["Nombre_Usuario"]
                    };
                }
                return empleado;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region update
        public int Update(Empleado empleado)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[8];
                parameters[0] = new SqlParameter("@ID_Empleado", empleado.ID_Empleado);
                parameters[1] = new SqlParameter("@Nombre_Empleado", empleado.Nombre_Empleado);
                parameters[2] = new SqlParameter("@Direccion_Empleado", empleado.Direccion_Empleado);
                parameters[3] = new SqlParameter("@Telefono_Empleado", empleado.Telefono_Empleado);
                parameters[4] = new SqlParameter("@Email_Empleado", empleado.Email_Empleado);
                parameters[5] = new SqlParameter("@Cargo_Empleado", empleado.Cargo_Empleado);
                parameters[6] = new SqlParameter("@password", empleado.password);
                parameters[7] = new SqlParameter("@Nombre_Usuario", empleado.Nombre_Usuario);
                string query = "stp_empleado_update";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region login
        public Empleado Login(Empleado empleado)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@Nombre_Usuario", empleado.Nombre_Usuario);
                parameters[1] = new SqlParameter("@password", empleado.password);
                String query = "stp_empleado_login";
                DataTable resultado = dataAccess.Query(query, parameters);
                if (resultado.Rows.Count > 0)
                {
                    Empleado empleadoLog = new Empleado()
                    {
                        ID_Empleado = (int)resultado.Rows[0]["ID_Empleado"],
                        Nombre_Usuario = (string)resultado.Rows[0]["Nombre_Usuario"],
                        password = (string)resultado.Rows[0]["password"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };
                    return empleadoLog;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return null;
        }
        #endregion
        #region
        public Empleado GetByNombre(Empleado empleado)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@Nombre_Usuario", empleado.Nombre_Usuario);
                string query = "stp_empleado_getbynombre";
                DataTable resultado = dataAccess.Query(query, parameters);
                if (resultado.Rows.Count > 0)
                {
                    empleado = new Empleado()
                    {
                        ID_Empleado = (int)resultado.Rows[0]["ID_Empleado"],
                        Nombre_Empleado = (string)resultado.Rows[0]["Nombre_Empleado"],
                        Direccion_Empleado = (string)resultado.Rows[0]["Direccion_Empleado"],
                        Telefono_Empleado = (string)resultado.Rows[0]["Telefono_Empleado"],
                        Email_Empleado = (string)resultado.Rows[0]["Email_Empleado"],
                        Cargo_Empleado = (string)resultado.Rows[0]["Cargo_Empleado"],
                        activo = (bool)resultado.Rows[0]["activo"],
                        password = (string)resultado.Rows[0]["password"],
                        Nombre_Usuario = (string)resultado.Rows[0]["Nombre_Usuario"]
                    };
                }
                return empleado;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
