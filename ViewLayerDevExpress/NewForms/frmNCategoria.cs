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
        private bool mensajeAlerta = false;
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
                txtAlerta.Visible = true;
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
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mostrarMensaje = true;
            this.Close();
        }

        private void frmNCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mensajeAlerta == true)
            {
                e.Cancel = true;
                mensajeAlerta = false;
            }
            if (mostrarMensaje && XtraMessageBox.Show("¿Desea Cancelar?", Application.ProductName, MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                this.Dispose();
            }

        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            txtAlerta.Visible = false;
        }
    }
}