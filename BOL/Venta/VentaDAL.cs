using BOL.Marca;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Venta
{
    public class VentaDAL
    {
        #region Singleton
        private static volatile VentaDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();
        private VentaDAL() { }
        public static VentaDAL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new VentaDAL();
            return instance;
        }
        #endregion
        #region add venta
        public int Add(Venta venta)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[4];
                parameters[0] = new SqlParameter("@Fecha_Venta", venta.Fecha_Venta);
                parameters[1] = new SqlParameter("@Total_Venta", venta.Total_Venta);
                parameters[2] = new SqlParameter("@ID_Cliente", venta.ID_Cliente);
                parameters[3] = new SqlParameter("@ID_Empleado", venta.ID_Empleado);
                string query = "stp_venta_add";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region Delete
        public int Delete(Venta venta)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@ID_Venta", venta.ID_Venta);
                string query = "stp_venta_delete";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region getall venta
        public Ventas getAll()
        {
            try
            {
                string query = "stp_venta_getall";
                DataTable resultado = dataAccess.Query(query);
                Ventas venta = new Ventas();
                foreach (DataRow item in resultado.Rows)
                {
                    venta.Add(new Venta()
                    {
                        ID_Venta = (int)item["ID_Venta"],
                        Fecha_Venta = (DateTime)item["Fecha_Venta"],
                        Total_Venta = (decimal)item["Total_Venta"],
                        ID_Cliente= (int)item["ID_Cliente"],
                        ID_Empleado= (int)item["ID_Empleado"],
                        activo = (bool)item["activo"]
                    });
                }
                return venta;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region getbyid
        public Venta GetById(Venta venta)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@ID_Venta", venta.ID_Venta);
                string query = "stp_venta_getbyid";
                DataTable resultado = dataAccess.Query(query, parameters);
                if (resultado.Rows.Count > 0)
                {
                    venta = new Venta()
                    {
                        ID_Venta = (int)resultado.Rows[0]["ID_Venta"],
                        Fecha_Venta = (DateTime)resultado.Rows[0]["Fecha_Venta"],
                        Total_Venta = (decimal)resultado.Rows[0]["Total_Venta"],
                        ID_Cliente= (int)resultado.Rows[0]["ID_Cliente"],
                        ID_Empleado = (int)resultado.Rows[0]["ID_Empleado"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };
                }
                return venta;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region update
        public int Update(Venta venta)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@ID_Venta", venta.ID_Venta);
                parameters[1] = new SqlParameter("@Fecha_Venta", venta.Fecha_Venta);
                parameters[2] = new SqlParameter("@Total_Venta", venta.Total_Venta);
                parameters[3] = new SqlParameter("@ID_Cliente", venta.ID_Cliente);
                parameters[4] = new SqlParameter("@ID_Empleado", venta.ID_Empleado);
                string query = "stp_venta_update";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region
        public Ventas getArchivo()
        {
            try
            {
                string query = "stp_venta_getarchivo";
                DataTable resultado = dataAccess.Query(query);
                Ventas venta = new Ventas();
                foreach (DataRow item in resultado.Rows)
                {
                    venta.Add(new Venta()
                    {
                        ID_Venta = (int)item["ID_Venta"],
                        Fecha_Venta = (DateTime)item["Fecha_Venta"],
                        Total_Venta = (decimal)item["Total_Venta"],
                        ID_Cliente = (int)item["ID_Cliente"],
                        ID_Empleado = (int)item["ID_Empleado"],
                        activo = (bool)item["activo"]
                    });
                }
                return venta;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
    }
}
