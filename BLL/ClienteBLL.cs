using BOL.Categoria;
using BOL.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteBLL
    {

        #region Singleton
        private static volatile ClienteBLL instance = null;
        private static readonly object padlock = new object();
        private ClienteDAL clienteDAL = ClienteDAL.Instance();
        private ClienteBLL() { }
        public static ClienteBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new ClienteBLL();
            return instance;
        }
        #endregion
        public bool Add(Cliente cliente)
        {
            return clienteDAL.Add(cliente) > 0;
        }
        public bool Delete(Cliente cliente)
        {
            return clienteDAL.Delete(cliente) > 0;
        }
        public Clientes GetAll()
        {
            return clienteDAL.getAll();
        }
        public Cliente GetById(Cliente cliente)
        {
            return clienteDAL.GetById(cliente);
        }
        public bool Update(Cliente cliente)
        {
            if (clienteDAL.Update(cliente) > 0)
            {
                return true;
            }
            else
                return false;
        }
        public Cliente getByName(Cliente cliente)
        {
            return clienteDAL.GetByNombre(cliente);
        }
    }
}
