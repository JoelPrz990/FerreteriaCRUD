using BLL;
using BOL.Cliente;
using BOL.Empleado;
using BOL.Marca;
using BOL.Venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ViewLayer.agregarList
{
    public partial class frmNVenta : Form
    {
        ClienteBLL clienteBLL = ClienteBLL.Instance();
        VentaBLL ventaBLL = VentaBLL.Instance();
        EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance();
        ProductoBLL productoBLL = ProductoBLL.Instance();
        public int idCliente;
        public decimal total;
        public int idEmpleado;
        DateTime fecha;


        public frmNVenta()
        {
            InitializeComponent();
        }

        private void frmNVenta_Load(object sender, EventArgs e)
        {
            Program.FechaHoy = DateTime.Now.Date;
            txtFecha.Text = Program.FechaHoy.ToString("dd/MM/yyyy");
            labelEmpleado.Text = Program.UsuarioActual;

            Clientes clientes = clienteBLL.GetAll();
            foreach (Cliente cliente in clientes)
            {
                boxCliente.Items.Add(cliente.Nombre_Cliente);
            }

            dgvProductos.DataSource = productoBLL.GetAll();
            dgvProductos.Columns["ID_Producto"].Visible = false;
            dgvProductos.Columns["ID_Categoria"].Visible = false;
            dgvProductos.Columns["ID_Marca"].Visible = false;
            dgvProductos.Columns["activo"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblTotal.Equals("00.00"))
            {
                if (!boxCliente.Text.Equals(""))
                {
                    idCliente = clienteBLL.getByName(new Cliente()
                    {
                        Nombre_Cliente = boxCliente.Text
                    }).ID_Cliente;
                }

                idEmpleado = empleadoBLL.getByName(new Empleado()
                {
                    Nombre_Usuario = Program.UsuarioActual
                }).ID_Empleado;

                DateTime.TryParseExact(txtFecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha);
                if (ventaBLL.Add(new Venta()
                {
                    Fecha_Venta = fecha,
                    Total_Venta = total,
                    ID_Cliente = idCliente,
                    ID_Empleado = idEmpleado,

                }))
                {
                    MessageBox.Show("Venta Ingresada Correctamente", "FerroPapus",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else {
                MessageBox.Show("Agregue productos a la venta","Ferropapus", MessageBoxButtons.OK);
            }
        }



        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // e.ColumnIndex == dgvProductos.Columns["Precio_Producto"].Index && 
            if (e.RowIndex >= 0)
            {
                int stock = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["Stock_Disponible"].Value);
                using (cantidadDialog cantidadDlg = new cantidadDialog(stock))
                {
                    if (cantidadDlg.ShowDialog() == DialogResult.OK)
                    {
                        int cantidad = cantidadDlg.Cantidad;
                        if (cantidad > stock)
                        {
                            MessageBox.Show("No hay suficiente stock disponible para agregar " + cantidad + " productos.");
                        }
                        else
                        {
                            decimal precioUnitario = Convert.ToDecimal(dgvProductos.Rows[e.RowIndex].Cells["Precio_Producto"].Value);
                            decimal subtotal = precioUnitario * cantidad;
                            total += subtotal;
                            lblTotal.Text = total.ToString();
                            MessageBox.Show("El precio total es: $" + total.ToString("0.00"));

                            int cantidadDisp = 0;
                            cantidadDisp = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["Stock_Disponible"].Value);
                            cantidadDisp = cantidadDisp - cantidad;
                            dgvProductos.Rows[e.RowIndex].Cells["Stock_Disponible"].Value = cantidadDisp;
                        }
                    }
                }
            }
        }






        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DateTime.TryParseExact(txtFecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha);
            boxCliente.SelectedIndex = -1;
            lblTotal.Text = "00.00";
            dgvProductos.DataSource = productoBLL.GetAll();
        }
    }
}
