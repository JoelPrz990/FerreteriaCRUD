using BLL;
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

namespace ViewLayerDevExpress.NewForms
{
    public partial class frmNEmpleado : DevExpress.XtraEditors.XtraForm
    {
        EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance();
        public frmNEmpleado()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea Cancelar?", Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtdireccion.Text) || String.IsNullOrEmpty(txtNombre.Text)
                || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtTelefono.Text)
                || String.IsNullOrEmpty(txtContraseña.Text) || String.IsNullOrEmpty(txtUsuario.Text))
            {
                XtraMessageBox.Show("Llene todos los campos", Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else {
                if (empleadoBLL.Add(new BOL.Empleado.Empleado() { 
                    Nombre_Empleado = txtNombre.Text,
                    Direccion_Empleado = txtdireccion.Text,
                    Telefono_Empleado = txtTelefono.Text,
                    Email_Empleado = txtEmail.Text,
                    Cargo_Empleado = cboxCargo.Text,
                    Nombre_Usuario = txtUsuario.Text,
                    password = txtContraseña.Text
                })) {
                    XtraMessageBox.Show("Empleado Agregado Correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
        }
    }
}