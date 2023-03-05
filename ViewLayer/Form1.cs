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
                    MessageBox.Show("Accedido correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsr.Clear();
                    txtPass.Clear();
                    txtUsr.Focus();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", Application.ProductName,
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
    }
}