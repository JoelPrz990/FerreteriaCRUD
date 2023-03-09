using BLL;
using BOL.Empleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewLayer.agregarList;
using ViewLayer.consultaList;
using WindowsFormsApp1;
using WindowsFormsApp1.actualizarList;
using WindowsFormsApp1.agregarList;
using WindowsFormsApp1.eliminarList;

namespace ViewLayer
{
    public partial class frmMain : Form
    {
        private bool mostrarMensaje = true;
        private string cargo;
        public frmMain()
        {
            InitializeComponent();
            menu.TabStop = true;
        }
        

        private void frmMain_Load(object sender, EventArgs e)
        { 
            #region importaciones de ventanas
            //frames Actualizar
            frmACliente frmACliente = new frmACliente();
            frmACategoria frmACategoria= new frmACategoria();
            frmAMarca frmAMarca = new frmAMarca();
            frmAProducto frmAProducto = new frmAProducto();
            frmAProveedor frmAProveedor = new frmAProveedor();
            frmAEmpleado frmAEmpleado = new frmAEmpleado();

            //frames Login
            frmStartup frmStartup = new frmStartup();
            frmLogin loginform = new frmLogin();

            //frames consultar
            frmProductos frmProductos = new frmProductos();
            frmCategorias frmCategorias = new frmCategorias();
            frmClientes frmClientes = new frmClientes();
            frmEmpleados frmEmpleados = new frmEmpleados();
            frmMarcas frmMarcas = new frmMarcas();
            frmProveedores frmProveedores= new frmProveedores();
            frmVentas frmVentas = new frmVentas();

            //frames Agregar
            frmNVenta frmNVenta = new frmNVenta();
            frmNCliente frmNCliente = new frmNCliente();
            frmNCategoria frmNCategoria = new frmNCategoria();
            frmNProducto frmNProducto = new frmNProducto();
            frmNProveedor frmNProveedor = new frmNProveedor();
            frmNMarca frmNMarca = new frmNMarca();
            frmNEmpleado frmNEmpleado = new frmNEmpleado();

            //frames Eliminar
            frmECategoria frmECategoria = new frmECategoria();
            frmECliente frmECliente = new frmECliente(); 
            frmEMarca frmEMarca = new frmEMarca();
            frmEProducto frmEProducto = new frmEProducto();
            frmEProveedor frmEProveedor = new frmEProveedor();
            frmEEmpleado frmEEmpleado = new frmEEmpleado();
            #endregion

            #region acciones de los botones
            //Lista ver 
            verProductosToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmProductos); 
            verCategoriasToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmCategorias);
            verClientesToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmClientes);
            verEmpleadosToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmEmpleados);
            verMarcasToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmMarcas);
            verProveedoresToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmProveedores);

            //lista agregar
            nuevaCategoriaToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmNCategoria);
            nuevoClienteToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmNCliente);
            nuevaMarcaToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmNMarca);
            nuevoProductoToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmNProducto);
            nuevoProveedorToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmNProveedor);
            nuevoEmpleadoToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmNEmpleado);

            //lista eliminar
            eliminarCategoriasToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmECategoria);
            eliminarClientesToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmECliente);
            eliminarMarcasToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmEMarca);
            eliminarProductosToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmEProducto);
            eliminarProveedoresToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmEProveedor);
            eliminarEmpleadoToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmEEmpleado);

            //lista Actualizar
            actualizarCategoriaToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmACategoria);
            actualizarClienteToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmACliente);
            actualizarMarcasToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmAMarca);
            actualizarProveedoresToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmAProveedor);
            acutalizarProductosToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmAProducto);
            actualizarEmpleadoToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmAEmpleado);


            //botones menustrip
            nuevaVentaToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmNVenta);
            verVentasToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmVentas);
            inicioToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmStartup);

            //botones de startup
            frmStartup.btnVenta.Click += (s, ea) => ShowFormInContentPanel(frmNVenta);
            frmStartup.btnVerClientes.Click += (s, ea) => ShowFormInContentPanel(frmClientes);
            frmStartup.btnVerVenta.Click += (s, ea) =>  ShowFormInContentPanel(frmVentas);
            frmStartup.btnAgregarCliente.Click += (s, ea) => ShowFormInContentPanel(frmNCliente);
            #endregion

            ShowFormInContentPanel(frmStartup);
            EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance();


            cargo = empleadoBLL.getByName(new Empleado()
            {
                Nombre_Usuario = Program.UsuarioActual
            }).Cargo_Empleado;

            if (!cargo.Equals("ADMINISTRADOR"))
            {
                nuevoEmpleadoToolStripMenuItem.Enabled = false;
                verEmpleadosToolStripMenuItem1.Enabled = false;
                eliminarEmpleadoToolStripMenuItem.Enabled =false;
                actualizarEmpleadoToolStripMenuItem.Enabled = false;
            }
            else {
            }
        }
        public void ShowFormInContentPanel(Form formToShow)
        {
            Form currentForm = tscMain.ContentPanel.Controls.OfType<Form>().FirstOrDefault();
            if (currentForm != null)
            {
                currentForm.Hide();
            }

            Panel contentPanel = tscMain.ContentPanel;
            contentPanel.Controls.Clear();
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(formToShow);
            formToShow.Show();
            formToShow.Focus();
        }

        /*public void ShowFormInContentPanel(Form formToShow)
        {
            Panel contentPanel = tscMain.ContentPanel;
            // Elimina cualquier control existente del ContentPanel
            contentPanel.Controls.Clear();
            // Ajusta el formulario para que se muestre en el ContentPanel
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            // Agrega el formulario al ContentPanel
            contentPanel.Controls.Add(formToShow);
            // Muestra el formulario
            formToShow.Show();
        }*/

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Cerrar Sesion?", "FerrePapus", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                mostrarMensaje = false;
                this.Close();
                frmLogin loginFrame = new frmLogin();
                Thread mainThread = new Thread(() => Application.Run(loginFrame));
                mainThread.Start();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                if (mostrarMensaje && MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
