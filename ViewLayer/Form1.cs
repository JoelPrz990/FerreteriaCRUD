using BLL;
using BOL.Empleado;
using System.Data.SqlClient;

namespace ViewLayer
{
    public partial class Form1 : Form
    {
        EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance(); 
        public Form1()
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
    }
}