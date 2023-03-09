using BLL;
using BOL.Marca;
using BOL.Producto;
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
    public partial class frmEProducto : Form
    {
        ProductoBLL productoBLL = ProductoBLL.Instance();
        int idProducto;
        public frmEProducto()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            idProducto = productoBLL.getByName(new Producto()
            {
                Nombre_Producto = cboxProductos.Text
            }).ID_Producto;

            if (productoBLL.Delete(new Producto()
            {
                ID_Producto = idProducto
            }))
            {
                MessageBox.Show("Producto Eliminado Correctamente", "FerroPapus",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campos limpiados", "FerroPapus",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboxProductos.SelectedIndex = -1;
        }

        private void frmEProducto_Enter(object sender, EventArgs e)
        {
            reload();
        }
        public void reload() {
            Productos productos = productoBLL.GetAll();
            cboxProductos.Items.Clear();
            foreach (Producto producto in productos)
            {
                cboxProductos.Items.Add(producto.Nombre_Producto);
            }

            cboxProductos.SelectedIndex = -1;
            dgvProductos.DataSource = productoBLL.GetAll();
            dgvProductos.Columns["ID_Producto"].Visible = false;
            dgvProductos.Columns["ID_Marca"].Visible = false;
            dgvProductos.Columns["ID_Categoria"].Visible = false;
            dgvProductos.Columns["activo"].Visible = false;
        }
    }
}
