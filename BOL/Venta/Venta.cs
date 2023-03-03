using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Venta
{
    public class Venta
    {
        public int ID_Venta { get; set; }
        public string Fecha_Venta { get; set; }
        public SqlMoney Total_Venta { get; set;}
        public int ID_Cliente { get; set; }
        public int ID_Empleado { get; set; }
        public bool activo { get; set; }
    }
}
