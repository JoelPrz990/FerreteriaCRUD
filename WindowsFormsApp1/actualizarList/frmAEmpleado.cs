using BLL;
using BOL.Cliente;
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

namespace WindowsFormsApp1.actualizarList
{
    public partial class frmAEmpleado : Form
    {
        EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance();
        int idEmpleado;
        public frmAEmpleado()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDireccion.Text) || String.IsNullOrEmpty(txtEmail.Text)
                || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtTelefono.Text)
                || String.IsNullOrEmpty(txtPass.Text)||String.IsNullOrEmpty(txtPass.Text) ||
                String.IsNullOrEmpty(cboxCargo.Text))
            {
                MessageBox.Show("Llene los campos", "Ferrepapus");
            }
            else
            {
                idEmpleado = empleadoBLL.getByName(new Empleado()
                {
                    Nombre_Usuario = cboxEmpleado.Text
                }).ID_Empleado;

                if (empleadoBLL.Update(new Empleado()
                {
                    ID_Empleado = idEmpleado,
                    Nombre_Empleado = txtNombre.Text,
                    Direccion_Empleado = txtDireccion.Text,
                    Telefono_Empleado=txtTelefono.Text,
                    Email_Empleado = txtEmail.Text,
                    Cargo_Empleado = cboxCargo.Text,
                    password = txtPass.Text,
                    Nombre_Usuario = txtUsuario.Text
                }))
                {
                    MessageBox.Show("Empleado Actualizado Correctamente", "FerroPapus",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reload();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campos limpiados", "FerroPapus",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboxEmpleado.SelectedIndex = -1;
            reload();
        }

        private void frmAEmpleado_Enter(object sender, EventArgs e)
        {
            reload();
        }
        public void reload() {
            Empleados empleados = empleadoBLL.GetAll();
            cboxEmpleado.Items.Clear();
            foreach (Empleado empleado in empleados)
            {
                cboxEmpleado.Items.Add(empleado.Nombre_Usuario);
            }
            cboxCargo.SelectedIndex = -1;
            txtNombre.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtUsuario.Clear();
            txtPass.Clear();
            dgvEmpleado.DataSource = empleadoBLL.GetAll();
            dgvEmpleado.Columns["ID_Empleado"].Visible = false;
            dgvEmpleado.Columns["activo"].Visible = false;
        }

        private void cboxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
