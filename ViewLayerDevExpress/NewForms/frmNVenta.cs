using BLL;
using ViewLayerDevExpress.NewForms;
using BOL.Venta;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewLayerDevExpress.agregarList;

namespace ViewLayerDevExpress.NewForms
{
    public partial class frmNVenta : DevExpress.XtraEditors.XtraForm
    {
        ClienteBLL clienteBLL = ClienteBLL.Instance();
        VentaBLL ventaBLL = VentaBLL.Instance();
        EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance();
        ProductoBLL productoBLL = ProductoBLL.Instance();
        MarcaBLL marcaBLL = MarcaBLL.Instance();
        CategoriaBLL categoriaBLL = CategoriaBLL.Instance();
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
            rlookCliente.EditValue = -1;
            clientesBindingSource.DataSource = clienteBLL.GetAll();
            marcasBindingSource.DataSource = marcaBLL.GetAll();
            categoriasBindingSource.DataSource = categoriaBLL.GetAll();
            gcProductos.DataSource = productoBLL.GetAll();

            String nombre = empleadoBLL.getByName(new BOL.Empleado.Empleado()
            {
                Nombre_Usuario = Program.UsuarioActual
            }).Nombre_Empleado;
            labelControl1.Text = "Empleado Actual: " + nombre;

            Program.FechaHoy = DateTime.Now.Date;
            txtFecha.Text = Program.FechaHoy.ToString("dd/MM/yyyy");
        }

        private void btnAlmacenar_Click(object sender, EventArgs e)
        {
            decimal precioEst = Convert.ToDecimal(lblTotal.Text);
            if (precioEst != 0)
            {
                if (!String.IsNullOrEmpty(rlookCliente.Text))
                {
                    int IdEmpleado = empleadoBLL.getByName(new BOL.Empleado.Empleado()
                    {
                        Nombre_Usuario = Program.UsuarioActual
                    }).ID_Empleado;

                    idCliente = Convert.ToInt32(rlookCliente.EditValue);

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
                        this.Close();
                    }
                }
                else {
                    XtraMessageBox.Show("No Deje Campos Vacios", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else {
                XtraMessageBox.Show("Agrege Productos a la Venta", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void gvProductos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                int stock = Convert.ToInt32(gvProductos.GetRowCellValue(e.RowHandle, "Stock_Disponible"));
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
                            decimal precioUnitario = Convert.ToDecimal(gvProductos.GetRowCellValue(e.RowHandle, "Precio_Producto"));
                            decimal subtotal = precioUnitario * cantidad;
                            total += subtotal;
                            lblTotal.Text = total.ToString();
                            MessageBox.Show("El precio total es: $" + total.ToString("0.00"));

                            int cantidadDisp = 0;
                            cantidadDisp = Convert.ToInt32(gvProductos.GetRowCellValue(e.RowHandle, "Stock_Disponible"));
                            cantidadDisp = cantidadDisp - cantidad;
                            gvProductos.SetRowCellValue(e.RowHandle, "Stock_Disponible", cantidadDisp);
                        }
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea Cancelar?", Application.ProductName, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}