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
    public partial class frmClientes : Form
    {
        ClienteBLL clienteBLL = ClienteBLL.Instance();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = clienteBLL.GetAll();
            dgvClientes.Columns["ID_Cliente"].Visible = false;
        }
    }
}
