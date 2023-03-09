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

namespace WindowsFormsApp1.eliminarList
{
    public partial class frmEEmpleado : Form
    {
        EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance();
        int idEmpleado;
        public frmEEmpleado()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            idEmpleado = empleadoBLL.getByName(new Empleado()
            {
                Nombre_Usuario = cboxEmpleado.Text
            }).ID_Empleado;

            if (empleadoBLL.Delete(new Empleado()
            {
                ID_Empleado = idEmpleado
            }))
            {
                MessageBox.Show("Empleado Eliminado Correctamente", "FerroPapus",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campos limpiados", "FerroPapus",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboxEmpleado.SelectedIndex = -1;
        }

        private void frmEEmpleado_Enter(object sender, EventArgs e)
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
            cboxEmpleado.SelectedIndex = -1;
            dgvEmpleado.DataSource = empleadoBLL.GetAll();
            dgvEmpleado.Columns["ID_Empleado"].Visible = false;
            dgvEmpleado.Columns["activo"].Visible = false;
            dgvEmpleado.Columns["password"].Visible = false;
        }
    }
}
