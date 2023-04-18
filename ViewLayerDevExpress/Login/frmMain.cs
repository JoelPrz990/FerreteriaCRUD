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
            frmLogin login = new frmLogin();
            login.Dispose();
            //frmSplash splash = new frmSplash();
            //splash.Dispose();
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
            if (mostrarMensaje && MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo) == DialogResult.No)
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

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
            Program.loginfrm.Show();
        }
    }
}