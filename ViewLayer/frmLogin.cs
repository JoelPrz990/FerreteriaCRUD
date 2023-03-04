using BLL;
using BOL.Empleado;

namespace ViewLayer
{
    public partial class frmLogin : Form
    {
        private EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance();
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
                throw new ApplicationException(ex.Message);
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }
    }
}