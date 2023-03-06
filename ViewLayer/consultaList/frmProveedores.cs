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
    public partial class frmProveedores : Form
    {
        ProveedorBLL proveedorBLL = ProveedorBLL.Instance();
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = proveedorBLL.GetAll();
            dgvProveedores.Columns["ID_Proveedor"].Visible= false;
        }
    }
}
