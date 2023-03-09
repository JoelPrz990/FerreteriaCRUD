using BLL;
using BOL.Cliente;
using BOL.Empleado;
using BOL.Marca;
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
    public partial class frmNMarca : Form
    {
        MarcaBLL marcaBLL = MarcaBLL.Instance();
        ProveedorBLL proveedorBLL = ProveedorBLL.Instance();
        int idProveedor;

        public frmNMarca()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(cboxProveedor.Text))
            {
                MessageBox.Show("Llene los campos", "Ferropapus");
            }
            else {

                if (!cboxProveedor.Text.Equals(""))
                {
                    idProveedor = proveedorBLL.getByName(new Proveedor()
                    {
                        Nombre_Proveedor = cboxProveedor.Text
                    }).ID_Proveedor;
                }

                if (marcaBLL.Add(new Marca()
                {
                    Nombre_Marca = txtNombre.Text,
                    ID_Proveedor = idProveedor
                }))
                {
                    MessageBox.Show("Marca Ingresada Correctamente", "FerroPapus",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvMarca.DataSource = marcaBLL.GetAll();
                    dgvMarca.Columns["ID_Marca"].Visible = false;
                    dgvMarca.Columns["activo"].Visible = false;
                    dgvMarca.Columns["ID_Proveedor"].Visible = false;
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campos limpiados", "FerroPapus",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombre.Clear();
            cboxProveedor.SelectedIndex= -1;
        }

        private void frmNMarca_Enter(object sender, EventArgs e)
        {
            Proveedores proveedores = proveedorBLL.GetAll();
            cboxProveedor.Items.Clear();
            foreach (Proveedor proveedor in proveedores)
            {
                cboxProveedor.Items.Add(proveedor.Nombre_Proveedor);
            }
            dgvMarca.DataSource = marcaBLL.GetAll();
            dgvMarca.Columns["ID_Marca"].Visible = false;
            dgvMarca.Columns["activo"].Visible=false;
            dgvMarca.Columns["ID_Proveedor"].Visible = false;
        }
    }
}
