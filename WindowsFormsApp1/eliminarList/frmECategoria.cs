using BLL;
using BOL.Categoria;
using BOL.Marca;
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
    public partial class frmECategoria : Form
    {
        CategoriaBLL categoriaBLL = CategoriaBLL.Instance();
        int idCategoria;
        public frmECategoria()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            idCategoria = categoriaBLL.getByDescripcion(new Categoria()
            {
                Nombre_Categoria = cboxCategorias.Text
            }).ID_Categoria;

            if (categoriaBLL.Delete(new Categoria()
            {
                ID_Categoria = idCategoria
            }))
            {
                MessageBox.Show("Categoria Eliminada Correctamente", "FerroPapus",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCategorias.DataSource = categoriaBLL.GetAll();
                dgvCategorias.Columns["ID_Categoria"].Visible = false;
                dgvCategorias.Columns["activo"].Visible = false;
                cboxCategorias.SelectedIndex = -1;
                reload();
            }
        }

        private void frmECategoria_Enter(object sender, EventArgs e)
        {
            reload();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campos limpiados", "FerroPapus",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboxCategorias.SelectedIndex = -1;
        }
        private void reload() {
            Categorias categorias = categoriaBLL.GetAll();
            foreach (Categoria categoria in categorias)
            {
                cboxCategorias.Items.Add(categoria.Nombre_Categoria);
            }
            dgvCategorias.DataSource = categoriaBLL.GetAll();
            dgvCategorias.Columns["ID_Categoria"].Visible = false;
            dgvCategorias.Columns["activo"].Visible = false;
        }
    }
}
