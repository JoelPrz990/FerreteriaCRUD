using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Producto
{
    public class Producto
    {
        public int ID_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion_Producto { get; set; }
        public string Marca_Producto { get; set; }
        public SqlMoney Precio_Producto { get; set; }
        public int ID_Categoria { get; set; }
        public string Stock_Disponible { get; set; }
        public int ID_Marca { get; set; }
        public bool activo { get; set; }
    }
}
