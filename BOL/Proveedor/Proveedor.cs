using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Proveedor
{
    public class Proveedor
    {
        public int ID_Proveedor { get; set; }
        public string Nombre_Proveedor { get; set; }
        public string Direccion_Proveedor { get; set; }
        public string Telefono_Proveedor{ get; set; }
        public string Email_Proveedor { get; set; }
        public bool activo { get; set; }
    }
}
