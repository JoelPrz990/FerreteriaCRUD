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

namespace ViewLayerDevExpress.Catalogos
{
    public partial class frmCategorias : DevExpress.XtraEditors.XtraForm
    {
        CategoriaBLL categoriaBLL = CategoriaBLL.Instance();
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            gcCategorias.DataSource = categoriaBLL.GetAll();
        }
    }
}