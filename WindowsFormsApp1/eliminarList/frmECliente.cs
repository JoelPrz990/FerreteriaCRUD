using BLL;
using BOL.Categoria;
using BOL.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.eliminarList
{
    public partial class frmECliente : Form
    {
        ClienteBLL clienteBLL = ClienteBLL.Instance();
        int idCliente;
        public frmECliente()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            idCliente = clienteBLL.getByName(new BOL.Cliente.Cliente()
            {
                Nombre_Cliente = cboxClientes.Text
            }).ID_Cliente;

            if (clienteBLL.Delete(new Cliente()
            {
                ID_Cliente = idCliente
            }))
            {
                MessageBox.Show("Cliente Eliminado Correctamente", "FerroPapus",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvClientes.DataSource = clienteBLL.GetAll();
                dgvClientes.Columns["ID_Cliente"].Visible = false;
                dgvClientes.Columns["ID_Cliente"].Visible = false;
                dgvClientes.Columns["activo"].Visible = false;
                cboxClientes.SelectedIndex = -1;
                reload();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campos limpiados", "FerroPapus",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboxClientes.SelectedIndex = -1;
        }

        private void frmECliente_Enter(object sender, EventArgs e)
        {
            reload();
        }
        public void reload() {
            Clientes clientes = clienteBLL.GetAll();
            foreach (Cliente cliente in clientes)
            {
                cboxClientes.Items.Add(cliente.Nombre_Cliente);
            }
            dgvClientes.DataSource = clienteBLL.GetAll();
            dgvClientes.Columns["ID_Cliente"].Visible = false;
            dgvClientes.Columns["ID_Cliente"].Visible = false;
            dgvClientes.Columns["activo"].Visible = false;
        }
    }
}
