using BLL;
using BOL.Empleado;
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
using ViewLayerDevExpress.Empresa;
using ViewLayerDevExpress.NewForms;

namespace ViewLayerDevExpress.Login
{
    public partial class frmStart : DevExpress.XtraEditors.XtraForm
    {
        EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance();
        public frmStart()
        {
            InitializeComponent();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            String nombre = empleadoBLL.getByName(new Empleado()
            {
                Nombre_Usuario = Program.UsuarioActual
            }).Nombre_Empleado;
            txtBienvenida.Text = "Empleado Actual: \n" + nombre;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            new frmNVenta().ShowDialog();
        }

        private void btnCerrarSes_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.logout();
        }
    }
}