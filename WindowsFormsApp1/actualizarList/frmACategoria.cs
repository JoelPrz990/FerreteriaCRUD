using BLL;
using BOL.Categoria;
using BOL.Cliente;
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
    public partial class frmACategoria : Form
    {
        CategoriaBLL categoriaBLL = CategoriaBLL.Instance();
        int idCategoria;
        public frmACategoria()
        {
            InitializeComponent();
        }


        private void frmACategoria_Enter(object sender, EventArgs e)
        {
            reload();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Llene los campos", "Ferrepapus");
            }
            else {
                idCategoria = categoriaBLL.getByDescripcion(new Categoria()
                {
                    Nombre_Categoria = cboxCategoria.Text
                }).ID_Categoria;

                if (categoriaBLL.Update(new Categoria()
                {
                    ID_Categoria = idCategoria,
                    Nombre_Categoria = txtNombre.Text
                }))
                {
                    MessageBox.Show("Categoria Actualizada Correctamente", "FerroPapus",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reload();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campos limpiados", "FerroPapus",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboxCategoria.SelectedIndex = -1;
        }
        public void reload() {
            Categorias categorias = categoriaBLL.GetAll();
            cboxCategoria.Items.Clear();
            foreach (Categoria categoria in categorias)
            {
                cboxCategoria.Items.Add(categoria.Nombre_Categoria);
            }
            txtNombre.Clear();
            cboxCategoria.SelectedIndex = -1;
            dgvCategoria.DataSource = categoriaBLL.GetAll();
            dgvCategoria.Columns["ID_Categoria"].Visible = false;
            dgvCategoria.Columns["activo"].Visible = false;
        }

        private void cboxCategoria_Leave(object sender, EventArgs e)
        {
            txtNombre.Text = cboxCategoria.Text;
        }
    }
}
