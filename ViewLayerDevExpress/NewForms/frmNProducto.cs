using BLL;
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
    public partial class frmNProducto : DevExpress.XtraEditors.XtraForm
    {
        ProductoBLL productoBLL = ProductoBLL.Instance();
        public frmNProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDescripcion.Text) || String.IsNullOrEmpty(txtNombre.Text)
                || String.IsNullOrEmpty(txtPrecio.Text) || String.IsNullOrEmpty(txtStock.Text))
            {
                XtraMessageBox.Show("Llene los campos", Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else {
                if (productoBLL.Add(new BOL.Producto.Producto() { 
                    Nombre_Producto = txtNombre.Text,
                    Descripcion_Producto = txtDescripcion.Text
                })) { 
                
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea Cancelar?", Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                this.Close();    
            }
        }
    }
}