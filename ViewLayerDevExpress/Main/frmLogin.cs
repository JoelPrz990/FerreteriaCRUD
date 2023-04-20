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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewLayerDevExpress.Login
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance();
        private bool mostrarMensaje = true;
        public frmLogin()
        {
            InitializeComponent();
        }

        public void IniciarSesion()
        {
            try
            {
                if (empleadoBLL.Login(new Empleado()
                {
                    Nombre_Usuario = txtUsuario.Text,
                    password = txtPass.Text
                }))
                {
                    Program.UsuarioActual = txtUsuario.Text;
                    XtraMessageBox.Show("Accedido correctamente", "Sesion Abierta",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtUsuario.Clear();
                    txtPass.Clear();
                    mostrarMensaje = false;

                    frmSplash splashForm = new frmSplash();
                    splashForm.Show();

                    Program.loginfrm.Hide();

                    //splashForm.Show();
                    //Thread splashThread = new Thread(() => Application.Run(splashForm));
                    //splashThread.Start();
                }
                else
                {

                    XtraMessageBox.Show("Credenciales incorrectas", "Error de Autenticacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPass.Clear();
                    txtPass.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region no se
        private void btnAcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
        #endregion
        #region no se que pedo
        private void btnCan_Click(object sender, EventArgs e)
        {
            if (mostrarMensaje && String.IsNullOrEmpty(txtPass.Text) && String.IsNullOrEmpty(txtUsuario.Text))
            {
                mostrarMensaje = false;
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Desea Salir", Application.ProductName, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    mostrarMensaje = false;
                    this.Close();
                }
                else
                {
                    btnLogin.Focus();
                }
            }
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            IniciarSesion();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (mostrarMensaje && String.IsNullOrEmpty(txtPass.Text) && String.IsNullOrEmpty(txtUsuario.Text))
            {
                mostrarMensaje = false;
                Application.Exit();
            }
            else
            {
                DialogResult result = MessageBox.Show("Desea Salir", "FerrePapus", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    mostrarMensaje = false;
                    Application.Exit();
                }
                else
                {
                    btnLogin.Focus();
                }
            }
        }

        private void frmLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (mostrarMensaje &&  XtraMessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true; // Cancelar el cierre del formulario
            }
        }
    }
}