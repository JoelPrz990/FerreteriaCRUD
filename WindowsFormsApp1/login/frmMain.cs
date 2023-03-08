using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewLayer.agregarList;
using ViewLayer.consultaList;
using WindowsFormsApp1.agregarList;

namespace ViewLayer
{
    public partial class frmMain : Form
    {
        private bool mostrarMensaje = true;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {



            frmLogin loginform = new frmLogin();
            frmProductos frmProductos = new frmProductos();
            frmStartup frmStartup = new frmStartup();
            frmCategorias frmCategorias = new frmCategorias();
            frmClientes frmClientes = new frmClientes();
            frmEmpleados frmEmpleados = new frmEmpleados();
            frmMarcas frmMarcas = new frmMarcas();
            frmProveedores frmProveedores= new frmProveedores();
            frmVentas frmVentas = new frmVentas();
            frmNVenta frmNVenta = new frmNVenta();
            frmNCliente frmNCliente = new frmNCliente();

            //ToolStripButton toolStripButton1 = new ToolStripButton("Formulario 1");
            //ToolStripButton toolStripButton2 =  new ToolStripButton("Ver Productos");
            // toolStrip1.Items.Add(toolStripButton1);
            //toolStrip1.Items.Add(toolStripButton2);

            //Lista ver 
            verProductosToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmProductos); 
            verCategoriasToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmCategorias);
            verClientesToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmClientes);
            verEmpleadosToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmEmpleados);
            verMarcasToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmMarcas);
            verProveedoresToolStripMenuItem1.Click += (s, ea) => ShowFormInContentPanel(frmProveedores);

            //botones
            nuevaVentaToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmNVenta);
            verVentasToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmVentas);
            inicioToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmStartup);

            //botones de startup
            frmStartup.btnVenta.Click += (s, ea) => ShowFormInContentPanel(frmNVenta);
            frmStartup.btnVerClientes.Click += (s, ea) => ShowFormInContentPanel(frmClientes);
            frmStartup.btnVerVenta.Click += (s, ea) =>  ShowFormInContentPanel(frmVentas);
            frmStartup.btnAgregarCliente.Click += (s, ea) => ShowFormInContentPanel(frmNCliente);

            ShowFormInContentPanel(frmStartup);
        }

        private Form currentForm = null;
        public void ShowFormInContentPanel(Form formToShow)
        {
            Panel contentPanel = tscMain.ContentPanel;
            // Elimina cualquier control existente del ContentPanel
            contentPanel.Controls.Clear();

            // Ajusta el formulario para que se muestre en el ContentPanel
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;

            // Agrega el formulario al ContentPanel y establece la variable currentForm
            contentPanel.Controls.Add(formToShow);
            currentForm = formToShow;

            // Muestra el formulario
            formToShow.Show();
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
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                mostrarMensaje = false;
                this.Close();
                frmLogin loginFrame = new frmLogin();
                Thread mainThread = new Thread(() => Application.Run(loginFrame));
                mainThread.Start();
            }
        }

        private void menu_Enter(object sender, EventArgs e)
        {
            menu.Focus();             
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                if (mostrarMensaje && MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true; // Cancelar el cierre del formulario
                }
            }
        }
    }
}
