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
    public partial class frmVentas : Form
    {
        VentaBLL ventaBLL = VentaBLL.Instance();
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = ventaBLL.GetAll();
            dgvVentas.Columns["ID_Venta"].Visible = false;
            dgvVentas.Columns["ID_Cliente"].Visible = false;
            dgvVentas.Columns["ID_Empleado"].Visible = false;
            dgvVentas.Columns["activo"].Visible = false;
        }
    }
}
