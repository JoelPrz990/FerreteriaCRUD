using BLL;
using BOL.Cliente;
using BOL.Proveedor;
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
    public partial class frmAProveedor : Form
    {
        ProveedorBLL proveedorBLL = ProveedorBLL.Instance();
        int idProveedor;
        public frmAProveedor()
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
            else
            {
                idProveedor = proveedorBLL.getByName(new Proveedor()
                {
                    Nombre_Proveedor = cboxProveedor.Text
                }).ID_Proveedor;

                if (proveedorBLL.Update(new Proveedor()
                {
                    ID_Proveedor = idProveedor,
                    Nombre_Proveedor = txtNombre.Text,
                    Direccion_Proveedor = txtDireccion.Text,
                    Email_Proveedor = txtEmail.Text,
                    Telefono_Proveedor = txtTelefono.Text
                }))
                {
                    MessageBox.Show("Proveedor Actualizado Correctamente", "FerroPapus",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reload();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campos limpiados", "FerroPapus",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboxProveedor.SelectedIndex = -1;
            reload();
        }

        private void frmAProveedor_Enter(object sender, EventArgs e)
        {
            reload();
        }
        public void reload() {
            Proveedores proveedores =   proveedorBLL.GetAll();
            cboxProveedor.Items.Clear();
            foreach (Proveedor proveedor in proveedores)
            {
                cboxProveedor.Items.Add(proveedor.Nombre_Proveedor);
            }
            cboxProveedor.SelectedIndex = -1;
            txtNombre.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            dgvProveedor.DataSource = proveedorBLL.GetAll();
            dgvProveedor.Columns["ID_Proveedor"].Visible = false;
            dgvProveedor.Columns["activo"].Visible = false;
        }
    }
}
