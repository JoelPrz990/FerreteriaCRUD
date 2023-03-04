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

namespace BOL.Producto
{
    public class ProductoDAL
    {
        #region Singleton
        private static volatile ProductoDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();
        private ProductoDAL() { }
        public static ProductoDAL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new ProductoDAL();
            return instance;
        }
        #endregion

        #region add producto
        public int Add(Producto producto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[7];
                parameters[0] = new SqlParameter("@Nombre_Producto", producto.Nombre_Producto);
                parameters[1] = new SqlParameter("@Descripcion_Producto", producto.Descripcion_Producto);
                parameters[2] = new SqlParameter("@Marca_Producto", producto.Marca_Producto);
                parameters[3] = new SqlParameter("@Precio_Producto", producto.Precio_Producto);
                parameters[4] = new SqlParameter("@ID_Categoria", producto.ID_Categoria);
                parameters[5] = new SqlParameter("@Stock_Disponible", producto.Stock_Disponible);
                parameters[6] = new SqlParameter("@ID_Marca", producto.ID_Marca);
                string query = "stp_producto_add";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region Delete
        public int Delete(Producto producto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@ID_Producto", producto.ID_Producto);
                string query = "stp_producto_delete";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region getall producto
        public Productos getAll()
        {
            try
            {
                string query = "stp_producto_getall";
                DataTable resultado = dataAccess.Query(query);
                Productos producto = new Productos();
                foreach (DataRow item in resultado.Rows)
                {
                    producto.Add(new Producto()
                    {
                        ID_Producto = (int)item["ID_Producto"],
                        Nombre_Producto = (string)item["Nombre_Producto"],
                        Descripcion_Producto = (string)item["Descripcion_Producto"],
                        Marca_Producto = (string)item["Marca_Producto"],
                        Precio_Producto = (SqlMoney)item["Precio_Producto"],
                        ID_Categoria = (int)item["ID_Categoria"],
                        Stock_Disponible = (int)item["Stock_Disponible"],
                        ID_Marca = (int)item["ID_Marca"],
                        activo = (bool)item["activo"]
                    });
                }
                return producto;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
        #endregion
        #region getbyid
        public Producto GetById(Producto producto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@ID_Producto", producto.ID_Producto);
                string query = "stp_producto_getbyid";
                DataTable resultado = dataAccess.Query(query, parameters);
                if (resultado.Rows.Count > 0)
                {
                    producto = new Producto()
                    {
                        ID_Producto = (int)resultado.Rows[0]["ID_Producto"],
                        Nombre_Producto = (string)resultado.Rows[0]["Nombre_Producto"],
                        Descripcion_Producto = (string)resultado.Rows[0]["Descripcion_Producto"],
                        Marca_Producto = (string)resultado.Rows[0]["Marca_Producto"],
                        Precio_Producto = (SqlMoney)resultado.Rows[0]["Precio_Producto"],
                        ID_Categoria = (int)resultado.Rows[0]["ID_Categoria"],
                        Stock_Disponible = (int)resultado.Rows[0]["Stock_Disponible"],
                        ID_Marca = (int)resultado.Rows[0]["ID_Marca"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };
                }
                return producto;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region update
        public int Update(Producto producto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[7];
                parameters[0] = new SqlParameter("@Nombre_Producto", producto.Nombre_Producto);
                parameters[1] = new SqlParameter("@Descripcion_Producto", producto.Descripcion_Producto);
                parameters[2] = new SqlParameter("@Marca_Producto", producto.Marca_Producto);
                parameters[3] = new SqlParameter("@Precio_Producto", producto.Precio_Producto);
                parameters[4] = new SqlParameter("@ID_Categoria", producto.ID_Categoria);
                parameters[5] = new SqlParameter("@Stock_Disponible", producto.Stock_Disponible);
                parameters[6] = new SqlParameter("@ID_Marca", producto.ID_Marca);
                string query = "stp_producto_update";
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
