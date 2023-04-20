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

namespace ViewLayerDevExpress.EditForms
{
    public partial class frmUEmpleado : DevExpress.XtraEditors.XtraForm
    {
        EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance();
        private int IdEmpleado;
        public frmUEmpleado()
        {
            InitializeComponent();
        }
        public frmUEmpleado(int idEmpleado)
        {
            InitializeComponent();
            this.IdEmpleado = idEmpleado;
        }

        private void frmUEmpleado_Load(object sender, EventArgs e)
        {
            Empleado empleado = empleadoBLL.GetById(new Empleado()
            {
                ID_Empleado = this.IdEmpleado
            });
            txtUser.Text = empleado.Nombre_Usuario;
            txtNombre.Text = empleado.Nombre_Empleado;
            txtdireccion.Text = empleado.Direccion_Empleado;
            txtTelefono.Text = empleado.Telefono_Empleado;
            txtEmail.Text = empleado.Email_Empleado;
            txtContraseña.Text = empleado.password;
            cboxCargo.Text = empleado.Cargo_Empleado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtdireccion.Text) || String.IsNullOrEmpty(txtNombre.Text)
                || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtTelefono.Text)
                || String.IsNullOrEmpty(txtContraseña.Text) || String.IsNullOrEmpty(txtUser.Text))
            {
                XtraMessageBox.Show("Llene todos los campos", Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                if (empleadoBLL.Update(new BOL.Empleado.Empleado()
                {
                    ID_Empleado = this.IdEmpleado,
                    Nombre_Empleado = txtNombre.Text,
                    Direccion_Empleado = txtdireccion.Text,
                    Telefono_Empleado = txtTelefono.Text,
                    Email_Empleado = txtEmail.Text,
                    Cargo_Empleado = cboxCargo.Text,
                    Nombre_Usuario = txtUser.Text,
                    password = txtContraseña.Text
                }))
                {
                    XtraMessageBox.Show("Empleado Modificado Correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea Cancelar?", Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}