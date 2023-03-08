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

namespace ViewLayer
{
    public partial class frmProductos : Form
    {
        ProductoBLL productoBLL = ProductoBLL.Instance();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = productoBLL.GetAll();
            dgvProductos.Columns["ID_Producto"].Visible =  false;
            dgvProductos.Columns["ID_Marca"].Visible = false;
            dgvProductos.Columns["ID_Categoria"].Visible = false;
            dgvProductos.Columns["activo"].Visible = false;
        }
    }
}
