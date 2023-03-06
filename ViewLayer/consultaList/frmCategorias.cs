using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewLayer.consultaList
{
    public partial class frmCategorias : Form
    {
        CategoriaBLL categoriaBLL = CategoriaBLL.Instance();
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            dgvCategorias.DataSource = categoriaBLL.GetAll();
        }
    }
}
