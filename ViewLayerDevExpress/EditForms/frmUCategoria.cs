using BLL;
using BOL.Categoria;
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
    public partial class frmUCategoria : DevExpress.XtraEditors.XtraForm
    {
        private int IdCategoria;
        CategoriaBLL categoriaBLL = CategoriaBLL.Instance();
        public frmUCategoria()
        {
            InitializeComponent();
        }
        public frmUCategoria(int IdCategoria)
        {
            this.IdCategoria = IdCategoria;
            InitializeComponent();
        }

        private void frmUCategoria_Load(object sender, EventArgs e)
        {
            Categoria categoria = categoriaBLL.GetById(new Categoria()
            {
                ID_Categoria = this.IdCategoria
            });
            txtDescripcion.Text = categoria.Nombre_Categoria;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!categoriaBLL.Update(new Categoria()
            {
                ID_Categoria = this.IdCategoria,
                Nombre_Categoria = txtDescripcion.Text
            }))
            {
                MessageBox.Show("Categoria Modificada Correctamente", Application.ProductName);
                this.Close();
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}