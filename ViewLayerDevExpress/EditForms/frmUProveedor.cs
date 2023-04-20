using BLL;
using BOL.Cliente;
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

namespace ViewLayerDevExpress.EditForms
{
    public partial class frmUProveedor : DevExpress.XtraEditors.XtraForm
    {
        ProveedorBLL proveedorBLL = ProveedorBLL.Instance();
        private int IdProveedor;
        public frmUProveedor()
        {
            InitializeComponent();
        }
        public frmUProveedor(int idProveedor)
        {
            InitializeComponent();
            this.IdProveedor = idProveedor;
        }

        private void frmUProveedor_Load(object sender, EventArgs e)
        {
            Proveedor proveedor = proveedorBLL.GetById(new Proveedor() { 
                ID_Proveedor = this.IdProveedor
            });
            txtNombre.Text = proveedor.Nombre_Proveedor;
            txtEmail.Text = proveedor.Email_Proveedor;
            txtTelefono.Text = proveedor.Telefono_Proveedor;
            txtdireccion.Text = proveedor.Direccion_Proveedor;
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
                if (proveedorBLL.Update(new Proveedor()
                {
                    ID_Proveedor = this.IdProveedor,
                    Nombre_Proveedor = txtNombre.Text,
                    Direccion_Proveedor = txtdireccion.Text,
                    Telefono_Proveedor = txtTelefono.Text,
                    Email_Proveedor = txtEmail.Text
                }))
                {
                    XtraMessageBox.Show("Proveedor Modificado Correctamente", Application.ProductName, MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
        }
    }
}