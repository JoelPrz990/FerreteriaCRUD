using BLL;
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

namespace WindowsFormsApp1.agregarList
{
    public partial class frmNCliente : Form
    {
        ClienteBLL clienteBLL = ClienteBLL.Instance();
        public frmNCliente()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtDireccion.Text)
                || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Llene los campos", "Ferropapus");
            }
            else {
                if (clienteBLL.Add(new Cliente()
                {
                    Nombre_Cliente = txtNombre.Text,
                    Direccion_Cliente = txtDireccion.Text,
                    Telefono_Cliente = txtTelefono.Text,
                    Email_Cliente = txtEmail.Text
                }))
                {
                    MessageBox.Show("Cliente Ingresado Correctamente", "FerroPapus",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCliente.DataSource = clienteBLL.GetAll();
                    dgvCliente.Columns["activo"].Visible = false;
                    dgvCliente.Columns["ID_Cliente"].Visible = false;
                    txtDireccion.Clear();
                    txtTelefono.Clear();
                    txtEmail.Clear();
                    txtNombre.Clear();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campos limpiados", "FerroPapus",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private void frmNCliente_Enter(object sender, EventArgs e)
        {
            dgvCliente.DataSource = clienteBLL.GetAll();
            dgvCliente.Columns["activo"].Visible = false;
            dgvCliente.Columns["ID_Cliente"].Visible = false;
        }
    }
}
