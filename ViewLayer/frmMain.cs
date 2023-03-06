using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewLayer.consultaList;

namespace ViewLayer
{
    public partial class frmMain : Form
    {
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

            //ToolStripButton toolStripButton1 = new ToolStripButton("Formulario 1");
            //ToolStripButton toolStripButton2 =  new ToolStripButton("Ver Productos");
            // toolStrip1.Items.Add(toolStripButton1);
            //toolStrip1.Items.Add(toolStripButton2);

            //Lista ver 
            verProductosToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmProductos); 
            verCategoriasToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmCategorias);
            verClientesToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmClientes);
            verEmpleadosToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmEmpleados);
            verMarcasToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmMarcas);
            verProveedoresToolStripMenuItem.Click += (s, ea) => ShowFormInContentPanel(frmProveedores);

            //botones
            nuevaVenta.Click += (s, ea) => ShowFormInContentPanel(loginform);
            verVentas.Click += (s, ea) => ShowFormInContentPanel(frmVentas);
            inicio.Click += (s, ea) => ShowFormInContentPanel(frmStartup);

            ShowFormInContentPanel(frmStartup);
        }


        private void ShowFormInContentPanel(Form formToShow)
        {
            Panel contentPanel = toolStripContainer1.ContentPanel;
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
        }
    }
}
