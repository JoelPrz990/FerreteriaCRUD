using BLL;
using BOL.Proveedor;
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
    public partial class frmNProveedor : DevExpress.XtraEditors.XtraForm
    {
        ProveedorBLL proveedorBLL = ProveedorBLL.Instance();
        public frmNProveedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea Cancelar?", Application.ProductName,
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtdireccion.Text) || String.IsNullOrEmpty(txtNombre.Text)
                || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtTelefono.Text))
            {
                XtraMessageBox.Show("Llene todos los campos", Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                if (proveedorBLL.Add(new Proveedor()
                {
                    Nombre_Proveedor = txtNombre.Text,
                    Direccion_Proveedor = txtdireccion.Text,
                    Telefono_Proveedor = txtTelefono.Text,
                    Email_Proveedor = txtEmail.Text
                }))
                {
                    XtraMessageBox.Show("Proveedor Añadido Correctamente", Application.ProductName, MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
        }
    }
}