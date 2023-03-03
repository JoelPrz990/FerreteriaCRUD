using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Cliente
{
    public class Cliente
    {
        public int ID_Cliente { get; set; }
        public String Nombre_Cliente { get; set; }
        public String Direccion_Cliente { get; set; }
        public String Telefono_Cliente { get; set; }
        public String Email_Cliente { get; set; }
        public bool activo { get; set; }
    }
}
