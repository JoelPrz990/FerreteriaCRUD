using BLL;
using BOL.Empleado;
using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ViewLayer
{
    public partial class frmLogin : Form
    {
        EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance(); 
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }
        public void IniciarSesion() {
            try
            {
                if (empleadoBLL.Login(new Empleado()
                {
                    Nombre_Usuario = txtUsr.Text,
                    password = txtPass.Text
                }))
                { 
                    Program.UsuarioActual = txtUsr.Text;
                    MessageBox.Show("Accedido correctamente", "Sesion Abierta",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtUsr.Clear();
                    txtPass.Clear();
                    this.Close();
                    frmSplash splashForm = new frmSplash();
                    Thread splashThread = new Thread(() => Application.Run(splashForm));
                    splashThread.Start();
                }
                else
                {
                    
                    MessageBox.Show("Credenciales incorrectas", "Error de Autenticacion",
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

        private void btnAcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') { 
                e.Handled = true;
            }
        }
        private void btnCan_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPass.Text) && String.IsNullOrEmpty(txtUsr.Text))
            {
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Desea Salir", Application.ProductName, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    btnAcc.Focus();
                }
            }
        }

        private void btnCan_Click_1(object sender, EventArgs e)
        {
                if (String.IsNullOrEmpty(txtPass.Text) && String.IsNullOrEmpty(txtUsr.Text))
                {
                    this.Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Desea Salir", "FerrePapus", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {
                        btnAcc.Focus();
                    }
            }
        }
    }
}