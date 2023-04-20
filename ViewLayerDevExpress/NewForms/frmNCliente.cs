using BLL;
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

namespace ViewLayerDevExpress.NewForms
{
    public partial class frmNCliente : DevExpress.XtraEditors.XtraForm
    {
        ClienteBLL clienteBLL = ClienteBLL.Instance();
        public frmNCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtdireccion.Text) || String.IsNullOrEmpty(txtNombre.Text)
                || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtTelefono.Text))
            {
                XtraMessageBox.Show("Llene todos los campos", Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else {
                if (clienteBLL.Add(new BOL.Cliente.Cliente() { 
                    Nombre_Cliente= txtNombre.Text,
                    Direccion_Cliente = txtdireccion.Text,
                    Telefono_Cliente= txtTelefono.Text,
                    Email_Cliente= txtEmail.Text
                })) {
                    XtraMessageBox.Show("Cliente Añadido Correctamente", Application.ProductName, MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea Cancelar?", Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}