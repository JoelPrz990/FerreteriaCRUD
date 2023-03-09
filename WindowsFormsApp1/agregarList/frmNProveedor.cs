using BLL;
using BOL.Proveedor;
using BOL.Venta;
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
    public partial class frmNProveedor : Form
    {
        ProveedorBLL proveedorBLL = ProveedorBLL.Instance();
        public frmNProveedor()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDireccion.Text) || String.IsNullOrEmpty(txtEmail.Text)
                || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Llene los campos", "Ferrepapus");
            }
            else {

                if (proveedorBLL.Add(new Proveedor()
                {
                    Nombre_Proveedor = txtNombre.Text,
                    Direccion_Proveedor = txtDireccion.Text,
                    Telefono_Proveedor = txtTelefono.Text,
                    Email_Proveedor = txtEmail.Text
                }))
                {
                    MessageBox.Show("Proveedor Ingresado Correctamente", "FerroPapus",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProveedor.DataSource = proveedorBLL.GetAll();
                    dgvProveedor.Columns["activo"].Visible = false;
                    dgvProveedor.Columns["ID_Proveedor"].Visible = false;
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

        private void frmNProveedor_Enter(object sender, EventArgs e)
        {
            dgvProveedor.DataSource = proveedorBLL.GetAll();
            dgvProveedor.Columns["activo"].Visible = false;
            dgvProveedor.Columns["ID_Proveedor"].Visible = false;
        }
    }
}
