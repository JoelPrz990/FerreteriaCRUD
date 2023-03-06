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

            DateTime fecha;
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



        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en la columna de precio
            // e.ColumnIndex == dgvProductos.Columns["Precio_Producto"].Index && 
            if (e.RowIndex >= 0)
            {
                // Obtener el valor de la columna de stock
                int stock = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["Stock_Disponible"].Value);

                // Mostrar un cuadro de diálogo personalizado para permitir al usuario ingresar la cantidad de productos que desea agregar
                using (cantidadDialog cantidadDlg = new cantidadDialog(stock))
                {
                    if (cantidadDlg.ShowDialog() == DialogResult.OK)
                    {
                        // Obtener la cantidad ingresada por el usuario
                        int cantidad = cantidadDlg.Cantidad;

                        // Verificar si la cantidad ingresada es mayor que el stock disponible
                        if (cantidad > stock)
                        {
                            MessageBox.Show("No hay suficiente stock disponible para agregar " + cantidad + " productos.");
                        }
                        else
                        {
                            // Calcular el precio total
                            decimal precioUnitario = Convert.ToDecimal(dgvProductos.Rows[e.RowIndex].Cells["Precio_Producto"].Value);
                            decimal subtotal = precioUnitario * cantidad;
                            total += subtotal;
                            lblTotal.Text = total.ToString();

                            // Mostrar el precio total en un cuadro de mensaje
                            MessageBox.Show("El precio total es: $" + total.ToString("0.00"));

                            // Actualizar el valor de la celda de cantidad en el DataGridView
                            int cantidadDisp = 0;
                            cantidadDisp = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["Stock_Disponible"].Value);
                            cantidadDisp = cantidadDisp - cantidad;
                            dgvProductos.Rows[e.RowIndex].Cells["Stock_Disponible"].Value = cantidadDisp;
                        }
                    }
                }
            }
        }
    }
}
