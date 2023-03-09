using BLL;
using BOL.Marca;
using BOL.Proveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.actualizarList
{
    public partial class frmAMarca : Form
    {
        MarcaBLL marcaBLL = MarcaBLL.Instance();
        ProveedorBLL proveedorBLL = ProveedorBLL.Instance();
        int idProveedor;
        int idMarca;
        public frmAMarca()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(cboxProveedor.Text)
                || String.IsNullOrEmpty(cboxMarca.Text))
            {
                MessageBox.Show("Llene los campos", "Ferropapus");
            }
            else
            { 
                if (!cboxProveedor.Text.Equals(""))
                {
                    idProveedor = proveedorBLL.getByName(new Proveedor()
                    {
                        Nombre_Proveedor = cboxProveedor.Text
                    }).ID_Proveedor;
                }
                if (!cboxMarca.Text.Equals(""))
                {
                    idMarca = marcaBLL.getByName(new Marca()
                    {
                        Nombre_Marca = cboxMarca.Text
                    }).ID_Marca;
                }

                if (marcaBLL.Update(new Marca()
                {
                    ID_Marca= idProveedor,
                    Nombre_Marca = txtNombre.Text,
                    ID_Proveedor = idProveedor
                }))
                {
                    MessageBox.Show("Marca Actualizada Correctamente", "FerroPapus",
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

        private void frmAMarca_Enter(object sender, EventArgs e)
        {
            reload();
        }
        public void reload() {
            Proveedores proveedores = proveedorBLL.GetAll();
            cboxProveedor.Items.Clear();
            foreach (Proveedor proveedor in proveedores)
            {
                cboxProveedor.Items.Add(proveedor.Nombre_Proveedor);
            }

            Marcas marcas = marcaBLL.GetAll();
            cboxMarca.Items.Clear();
            foreach (Marca marca in marcas)
            {
                cboxMarca.Items.Add(marca.Nombre_Marca);
            }

            txtNombre.Clear();
            cboxMarca.SelectedIndex= -1;
            cboxProveedor.SelectedIndex= -1;
            dgvMarca.DataSource = marcaBLL.GetAll();
            dgvMarca.Columns["ID_Marca"].Visible = false;
            dgvMarca.Columns["activo"].Visible = false;
            dgvMarca.Columns["ID_Proveedor"].Visible = false;
        }
    }
}
