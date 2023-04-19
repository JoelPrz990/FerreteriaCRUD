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
using ViewLayerDevExpress.Catalogos;

namespace ViewLayerDevExpress.Login
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private bool mostrarMensaje = true;
        private string cargo;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            new frmStart() { MdiParent = this }.Show();

            EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance();
            cargo = empleadoBLL.getByName(new Empleado()
            {
                Nombre_Usuario = Program.UsuarioActual
            }).Cargo_Empleado;

            if (!cargo.Equals("ADMINISTRADOR"))
            {
                btnEmpleados.Enabled = false;
            }
            else
            {
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmStart))
                {
                    form.Activate();
                    return;
                }
            new frmStart() { MdiParent = this }.Show();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mostrarMensaje && XtraMessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else {
                mostrarMensaje = false;
                Application.Exit();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmCategorias))
                {
                    form.Activate();
                    return;
                }
            new frmCategorias() { MdiParent = this }.Show();
        }
        private void btnMarcas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmMarcas))
                {
                    form.Activate();
                    return;
                }
            new frmMarcas() { MdiParent = this }.Show();
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
            Program.loginfrm.Show();
        }


    }
}