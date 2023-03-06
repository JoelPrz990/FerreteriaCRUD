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
    public partial class frmEmpleados : Form
    {
        EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance();
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = empleadoBLL.GetAll();
            dgvEmpleados.Columns["ID_Empleado"].Visible= false;
            dgvEmpleados.Columns["activo"].Visible = false;
            dgvEmpleados.Columns["password"].Visible = false;
        }
    }
}
