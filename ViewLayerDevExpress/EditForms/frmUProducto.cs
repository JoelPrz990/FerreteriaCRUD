using BOL.Categoria;
using BOL.Marca;
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
    public partial class frmUProducto : DevExpress.XtraEditors.XtraForm
    {
        private int IdProducto;
        public frmUProducto()
        {
            InitializeComponent();
        }

        public frmUProducto(int IdProducto)
        {
            this.IdProducto = IdProducto;
            InitializeComponent();
        }

        private void frmUProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idCategoria = Convert.ToInt32(rlookCategoria.EditValue);
            int idMarca = Convert.ToInt32(rlookMarca.EditValue);
            int stock = Convert.ToInt32(txtStock.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}