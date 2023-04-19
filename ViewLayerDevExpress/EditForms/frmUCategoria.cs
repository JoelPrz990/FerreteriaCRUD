using BLL;
using BOL.Categoria;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewLayerDevExpress.EditForms
{
    public partial class frmUCategoria : DevExpress.XtraEditors.XtraForm
    {
        private bool mostrarMensaje;
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
            mostrarMensaje = false;
            if (!categoriaBLL.Update(new Categoria()
            {
                ID_Categoria = this.IdCategoria,
                Nombre_Categoria = txtDescripcion.Text
            }))
            {
                XtraMessageBox.Show("Categoria Modificada Correctamente", Application.ProductName);
                this.Close();
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mostrarMensaje = true;
            this.Close();
        }

        private void frmUCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mostrarMensaje && XtraMessageBox.Show("¿Desea Cancelar la Modificacion?", Application.ProductName, MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                } 
            else
            {
                this.Dispose();
            }
        }
    }
}