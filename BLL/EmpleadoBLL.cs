using BOL;
using BOL.Cliente;
using BOL.Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmpleadoBLL
    {

        #region Singleton
        private static volatile EmpleadoBLL instance = null;
        private static readonly object padlock = new object();
        private EmpleadoDAL empleadoDAL = EmpleadoDAL.Instance();
        private EmpleadoBLL() { }
        public static EmpleadoBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new EmpleadoBLL();
            return instance;
        }
        #endregion
        public bool Add(Empleado empleado)
        {
            return empleadoDAL.Add(empleado) > 0;
        }
        public bool Delete(Empleado empleado)
        {
            return empleadoDAL.Delete(empleado) > 0;
        }
        public Empleados GetAll()
        {
            return empleadoDAL.getAll();
        }
        public Empleado GetById(Empleado empleado)
        {
            return empleadoDAL.GetById(empleado);  
        }
        public bool Update(Empleado empleado)
        {
            if (empleadoDAL.Update(empleado) > 0)
            {
                return true;
            }
            else
                return false;
        }
        public bool Login(Empleado empleado)
        {
            if (empleadoDAL.Login(empleado) != null)
                return true;
            else
                return false;
        }
        public Empleado getByName(Empleado empleado)
        {
            return empleadoDAL.GetByNombre(empleado);
        }
    }
}
