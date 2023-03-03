using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Marca
{
    public class Marca
    {
        public int ID_Marca { get; set; }
        public int ID_Proveedor { get; set; }
        public string Nombre_Marca { get; set; }
        public bool activo { get; set; }
    }
}
