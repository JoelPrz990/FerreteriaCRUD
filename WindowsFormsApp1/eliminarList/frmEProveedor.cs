using BLL;
using BOL.Producto;
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

namespace WindowsFormsApp1.eliminarList
{
    public partial class frmEProveedor : Form
    {
        ProveedorBLL proveedorBLL = ProveedorBLL.Instance();
        int idProveedor;
        public frmEProveedor()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            idProveedor = proveedorBLL.getByName(new BOL.Proveedor.Proveedor()
            {
                Nombre_Proveedor = cboxProveedores.Text
            }).ID_Proveedor;

            if (proveedorBLL.Delete(new BOL.Proveedor.Proveedor()
            {
                ID_Proveedor = idProveedor
            }))
            {
                MessageBox.Show("Proveedor Eliminado Correctamente", "FerroPapus",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campos limpiados", "FerroPapus",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboxProveedores.SelectedIndex = -1;
        }

        private void frmEProveedor_Enter(object sender, EventArgs e)
        {
            reload();
        }
        public void reload() {
            cboxProveedores.SelectedIndex = -1;
            Proveedores proveedores = proveedorBLL.GetAll();
            cboxProveedores.Items.Clear();
            foreach (Proveedor proveedor in proveedores)
            {
                cboxProveedores.Items.Add(proveedor.Nombre_Proveedor);
            }
            dgvProveedores.DataSource = proveedorBLL.GetAll();
            dgvProveedores.Columns["ID_Proveedor"].Visible = false;
            dgvProveedores.Columns["activo"].Visible = false;
        }
    }
}
