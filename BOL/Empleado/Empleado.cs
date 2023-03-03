using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Empleado
{
    public class Empleado
    {
        public int ID_Empleado { get; set; }
        public string Nombre_Empleado { get; set; }
        public string Direccion_Empleado { get; set; }
        public string Telefono_Empleado { get; set; }
        public string Email_Empleado { get; set; }
        public string Cargo_Empleado { get; set; }
        public bool activo { get; set; }
        public string password { get; set; }
        public string Nombre_Usuario { get; set; }
    }
}
