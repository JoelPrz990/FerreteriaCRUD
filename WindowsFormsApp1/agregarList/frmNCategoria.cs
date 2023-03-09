using BLL;
using BOL.Categoria;
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
    public partial class frmNCategoria : Form
    {
        CategoriaBLL categoriaBLL = CategoriaBLL.Instance();
        public frmNCategoria()
        {
            InitializeComponent();
        }

        private void frmNCategoria_Enter(object sender, EventArgs e)
        {
            dgvCategoria.DataSource = categoriaBLL.GetAll();
            dgvCategoria.DataSource = categoriaBLL.GetAll();
            dgvCategoria.Columns["ID_Categoria"].Visible = false;
            dgvCategoria.Columns["activo"].Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Llene el campo", "Ferropapus");
            }
            else {

                if (categoriaBLL.Add(new Categoria()
                {
                    Nombre_Categoria = txtNombre.Text
                }))
                {
                    MessageBox.Show("Categoria Ingresada Correctamente", "FerroPapus",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                }
                dgvCategoria.DataSource = categoriaBLL.GetAll();
                dgvCategoria.Columns["ID_Categoria"].Visible = false;
                dgvCategoria.Columns["activo"].Visible = false;

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campo limpiado", "FerroPapus",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombre.Clear();
        }
    }
}
