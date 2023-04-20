using BLL;
using BOL.Cliente;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewLayerDevExpress.EditForms
{
    public partial class frmUCliente : DevExpress.XtraEditors.XtraForm
    {
        ClienteBLL clienteBLL = ClienteBLL.Instance();
        private int IdCliente;
        public frmUCliente()
        {
            InitializeComponent();
        }
        public frmUCliente(int idCliente)
        {
            InitializeComponent();
            this.IdCliente = idCliente;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtdireccion.Text) || String.IsNullOrEmpty(txtNombre.Text)
                || String.IsNullOrEmpty(txtTelefono.Text) || String.IsNullOrEmpty(txtEmail.Text))
            {
                XtraMessageBox.Show("Llene los campos", Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else {

                if (clienteBLL.Update(new Cliente() {
                    ID_Cliente = this.IdCliente,
                    Nombre_Cliente = txtNombre.Text,
                    Direccion_Cliente = txtdireccion.Text,
                    Telefono_Cliente= txtTelefono.Text,
                    Email_Cliente= txtEmail.Text
                })) {
                    XtraMessageBox.Show("Cliente Modificado Correctamente",ProductName,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea Cancelar?", Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmUCliente_Load(object sender, EventArgs e)
        {
            Cliente cliente = clienteBLL.GetById(new Cliente()
            {
                ID_Cliente = this.IdCliente
            });
            txtdireccion.Text = cliente.Direccion_Cliente;
            txtEmail.Text = cliente.Email_Cliente;
            txtTelefono.Text = cliente.Telefono_Cliente;
            txtNombre.Text = cliente.Nombre_Cliente;
        }
    }
}