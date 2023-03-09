using BLL;
using BOL.Empleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.agregarList
{
    public partial class frmNEmpleado : Form
    {
        EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance();
        public frmNEmpleado()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (empleadoBLL.Add(new Empleado()
            {
                Nombre_Empleado = txtNombre.Text,
                Direccion_Empleado = txtDireccion.Text,
                Telefono_Empleado = txtTelefono.Text,
                Email_Empleado = txtEmail.Text,
                Cargo_Empleado = cboxCargo.Text,
                password = txtPass.Text,
                Nombre_Usuario= txtUsuario.Text
            }))
            {
                MessageBox.Show("Cliente Ingresado Correctamente", "FerroPapus",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvEmpleado.DataSource = empleadoBLL.GetAll();
                dgvEmpleado.Columns["ID_Empleado"].Visible = false;
                dgvEmpleado.Columns["activo"].Visible = false;
                txtDireccion.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtNombre.Clear();
                txtUsuario.Clear();
                txtPass.Clear();
                cboxCargo.SelectedIndex = -1;
            }

        }

        private void frmNEmpleado_Enter(object sender, EventArgs e)
        {
            dgvEmpleado.DataSource = empleadoBLL.GetAll();
            dgvEmpleado.Columns["ID_Empleado"].Visible = false;
            dgvEmpleado.Columns["activo"].Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campos limpiados", "FerroPapus",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtUsuario.Clear();
            txtPass.Clear();
            cboxCargo.SelectedIndex = -1;
        }
    }
}
