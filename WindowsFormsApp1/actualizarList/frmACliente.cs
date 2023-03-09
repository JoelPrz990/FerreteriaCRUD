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

namespace WindowsFormsApp1.actualizarList
{
    public partial class frmACliente : Form
    {
        ClienteBLL clienteBLL = ClienteBLL.Instance();
        int idCliente;
        public frmACliente()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDireccion.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Llene los campos", "Ferrepapus");
            }
            else {
                idCliente = clienteBLL.getByName(new Cliente()
                {
                    Nombre_Cliente = cboxCliente.Text
                }).ID_Cliente;

                if (clienteBLL.Update(new Cliente()
                {
                    ID_Cliente = idCliente,
                    Direccion_Cliente = txtDireccion.Text,
                    Nombre_Cliente = txtNombre.Text,
                    Email_Cliente = txtEmail.Text,
                    Telefono_Cliente = txtTelefono.Text

                }))
                {
                    MessageBox.Show("Cliente Actualizado Correctamente", "FerroPapus",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reload();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campos limpiados", "FerroPapus",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboxCliente.SelectedIndex = -1;
            reload();
        }

        private void frmACliente_Enter(object sender, EventArgs e)
        {
            reload();
        }
        public void reload() {
            Clientes clientes = clienteBLL.GetAll();
            cboxCliente.Items.Clear();
            foreach (Cliente cliente in clientes)
            {
                cboxCliente.Items.Add(cliente.Nombre_Cliente);
            }
            cboxCliente.SelectedIndex = -1;
            txtNombre.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            dgvCliente.DataSource = clienteBLL.GetAll();
            dgvCliente.Columns["ID_Cliente"].Visible = false;
            dgvCliente.Columns["ID_Cliente"].Visible = false;
            dgvCliente.Columns["activo"].Visible = false;
        }

        private void cboxCliente_Leave(object sender, EventArgs e)
        {
        }
    }
}
