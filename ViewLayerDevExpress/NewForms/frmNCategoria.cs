using BLL;
using BOL.Categoria;
using DevExpress.XtraBars.Alerter;
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

namespace ViewLayerDevExpress.NewForms
{
    public partial class frmNCategoria : DevExpress.XtraEditors.XtraForm
    {
        private bool mostrarMensaje;
        private int ID_Categoria;
        CategoriaBLL categoriaBLL = CategoriaBLL.Instance();
        public frmNCategoria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mostrarMensaje = false;
            if (String.IsNullOrEmpty(txtDescripcion.Text))
            {
                XtraMessageBox.Show("Llene el campo", Application.ProductName,
                    MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                categoriaBLL.Add(new Categoria()
                {
                    Nombre_Categoria = txtDescripcion.Text
                });
                XtraMessageBox.Show("Categoria Ingresada Correctamente", Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripcion.Clear();
                //this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mostrarMensaje = true;
            this.Close();
        }

        private void frmNCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mostrarMensaje && XtraMessageBox.Show("¿Desea no Agregar?", Application.ProductName, MessageBoxButtons.YesNo,
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