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

namespace ViewLayerDevExpress.NewForms
{
    public partial class frmNCategoria : DevExpress.XtraEditors.XtraForm
    {
        private int ID_Categoria;
        CategoriaBLL categoriaBLL = CategoriaBLL.Instance();
        public frmNCategoria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Llene el campo", Application.ProductName);
            }
            else
            {
                categoriaBLL.Add(new Categoria()
                {
                    Nombre_Categoria = txtDescripcion.Text
                });
                MessageBox.Show("Categoria Ingresada Correctamente", Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripcion.Clear();
                //this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}