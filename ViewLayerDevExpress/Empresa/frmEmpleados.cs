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
using ViewLayerDevExpress.EditForms;
using ViewLayerDevExpress.NewForms;

namespace ViewLayerDevExpress.Empresa
{
    public partial class frmEmpleados : DevExpress.XtraEditors.XtraForm
    {
        EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance();

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            gcEmpleados.DataSource = empleadoBLL.GetAll();
        }

        private void btnNuevoEmpleado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNEmpleado().ShowDialog();
            gcEmpleados.DataSource = empleadoBLL.GetAll();
            gvEmpleados.BestFitColumns();
        }

        private void btnModEmpleado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int IdEmpleado = (int)gvEmpleados.GetFocusedRowCellValue("ID_Empleado");
            new frmUEmpleado(IdEmpleado).ShowDialog();
        }
    }
}