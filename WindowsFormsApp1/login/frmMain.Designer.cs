using System.Windows.Forms;

namespace ViewLayer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tscMain = new System.Windows.Forms.ToolStripContainer();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarElementosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verClientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verCategoriasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verEmpleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verMarcasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verProveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarElementosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarElementosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acutalizarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tscMain.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscMain
            // 
            this.tscMain.BottomToolStripPanelVisible = false;
            // 
            // tscMain.ContentPanel
            // 
            this.tscMain.ContentPanel.BackColor = System.Drawing.Color.Linen;
            this.tscMain.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tscMain.ContentPanel.Size = new System.Drawing.Size(1023, 542);
            this.tscMain.LeftToolStripPanelVisible = false;
            this.tscMain.Location = new System.Drawing.Point(0, 30);
            this.tscMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tscMain.Name = "tscMain";
            this.tscMain.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tscMain.RightToolStripPanelVisible = false;
            this.tscMain.Size = new System.Drawing.Size(1033, 550);
            this.tscMain.TabIndex = 2;
            // 
            // tscMain.TopToolStripPanel
            // 
            this.tscMain.TopToolStripPanel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tscMain.TopToolStripPanel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tscMain.TopToolStripPanelVisible = false;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.nuevaVentaToolStripMenuItem,
            this.verVentasToolStripMenuItem,
            this.agregarNuevoToolStripMenuItem,
            this.consultarElementosToolStripMenuItem,
            this.eliminarElementosToolStripMenuItem,
            this.actualizarElementosToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.ShowItemToolTips = true;
            this.menu.Size = new System.Drawing.Size(1033, 28);
            this.menu.Stretch = false;
            this.menu.TabIndex = 1;
            this.menu.TabStop = true;
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.inicioToolStripMenuItem.Text = "&Inicio";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.nuevaVentaToolStripMenuItem.Text = "&Nueva Venta";
            // 
            // verVentasToolStripMenuItem
            // 
            this.verVentasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.verVentasToolStripMenuItem.Name = "verVentasToolStripMenuItem";
            this.verVentasToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.verVentasToolStripMenuItem.Text = "&Ver Ventas";
            // 
            // agregarNuevoToolStripMenuItem
            // 
            this.agregarNuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCategoriaToolStripMenuItem,
            this.nuevoClienteToolStripMenuItem,
            this.nuevaMarcaToolStripMenuItem,
            this.nuevoProductoToolStripMenuItem,
            this.nuevoProveedorToolStripMenuItem,
            this.nuevoEmpleadoToolStripMenuItem});
            this.agregarNuevoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.agregarNuevoToolStripMenuItem.Name = "agregarNuevoToolStripMenuItem";
            this.agregarNuevoToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.agregarNuevoToolStripMenuItem.Text = "&Agregar Nuevo";
            // 
            // nuevaCategoriaToolStripMenuItem
            // 
            this.nuevaCategoriaToolStripMenuItem.Name = "nuevaCategoriaToolStripMenuItem";
            this.nuevaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.nuevaCategoriaToolStripMenuItem.Text = "Nueva Categoria";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            // 
            // nuevaMarcaToolStripMenuItem
            // 
            this.nuevaMarcaToolStripMenuItem.Name = "nuevaMarcaToolStripMenuItem";
            this.nuevaMarcaToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.nuevaMarcaToolStripMenuItem.Text = "Nueva Marca";
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo Producto";
            // 
            // nuevoProveedorToolStripMenuItem
            // 
            this.nuevoProveedorToolStripMenuItem.Name = "nuevoProveedorToolStripMenuItem";
            this.nuevoProveedorToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.nuevoProveedorToolStripMenuItem.Text = "Nuevo Proveedor";
            // 
            // nuevoEmpleadoToolStripMenuItem
            // 
            this.nuevoEmpleadoToolStripMenuItem.Name = "nuevoEmpleadoToolStripMenuItem";
            this.nuevoEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.nuevoEmpleadoToolStripMenuItem.Text = "Nuevo Empleado";
            // 
            // consultarElementosToolStripMenuItem
            // 
            this.consultarElementosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verClientesToolStripMenuItem1,
            this.verCategoriasToolStripMenuItem1,
            this.verEmpleadosToolStripMenuItem1,
            this.verMarcasToolStripMenuItem1,
            this.verProductosToolStripMenuItem1,
            this.verProveedoresToolStripMenuItem1});
            this.consultarElementosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.consultarElementosToolStripMenuItem.Name = "consultarElementosToolStripMenuItem";
            this.consultarElementosToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.consultarElementosToolStripMenuItem.Text = "&Consultar Elementos";
            // 
            // verClientesToolStripMenuItem1
            // 
            this.verClientesToolStripMenuItem1.Name = "verClientesToolStripMenuItem1";
            this.verClientesToolStripMenuItem1.Size = new System.Drawing.Size(205, 26);
            this.verClientesToolStripMenuItem1.Text = "Ver Clientes";
            // 
            // verCategoriasToolStripMenuItem1
            // 
            this.verCategoriasToolStripMenuItem1.Name = "verCategoriasToolStripMenuItem1";
            this.verCategoriasToolStripMenuItem1.Size = new System.Drawing.Size(205, 26);
            this.verCategoriasToolStripMenuItem1.Text = "Ver Categorias";
            // 
            // verEmpleadosToolStripMenuItem1
            // 
            this.verEmpleadosToolStripMenuItem1.Name = "verEmpleadosToolStripMenuItem1";
            this.verEmpleadosToolStripMenuItem1.Size = new System.Drawing.Size(205, 26);
            this.verEmpleadosToolStripMenuItem1.Text = "Ver Empleados";
            // 
            // verMarcasToolStripMenuItem1
            // 
            this.verMarcasToolStripMenuItem1.Name = "verMarcasToolStripMenuItem1";
            this.verMarcasToolStripMenuItem1.Size = new System.Drawing.Size(205, 26);
            this.verMarcasToolStripMenuItem1.Text = "Ver Marcas";
            // 
            // verProductosToolStripMenuItem1
            // 
            this.verProductosToolStripMenuItem1.Name = "verProductosToolStripMenuItem1";
            this.verProductosToolStripMenuItem1.Size = new System.Drawing.Size(205, 26);
            this.verProductosToolStripMenuItem1.Text = "Ver Productos";
            // 
            // verProveedoresToolStripMenuItem1
            // 
            this.verProveedoresToolStripMenuItem1.Name = "verProveedoresToolStripMenuItem1";
            this.verProveedoresToolStripMenuItem1.Size = new System.Drawing.Size(205, 26);
            this.verProveedoresToolStripMenuItem1.Text = "Ver Proveedores";
            // 
            // eliminarElementosToolStripMenuItem
            // 
            this.eliminarElementosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarClientesToolStripMenuItem1,
            this.eliminarCategoriasToolStripMenuItem,
            this.eliminarMarcasToolStripMenuItem,
            this.eliminarProductosToolStripMenuItem1,
            this.eliminarProveedoresToolStripMenuItem1,
            this.eliminarEmpleadoToolStripMenuItem});
            this.eliminarElementosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.eliminarElementosToolStripMenuItem.Name = "eliminarElementosToolStripMenuItem";
            this.eliminarElementosToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.eliminarElementosToolStripMenuItem.Text = "&Eliminar Elementos";
            // 
            // eliminarClientesToolStripMenuItem1
            // 
            this.eliminarClientesToolStripMenuItem1.Name = "eliminarClientesToolStripMenuItem1";
            this.eliminarClientesToolStripMenuItem1.Size = new System.Drawing.Size(238, 26);
            this.eliminarClientesToolStripMenuItem1.Text = "Eliminar Clientes";
            // 
            // eliminarCategoriasToolStripMenuItem
            // 
            this.eliminarCategoriasToolStripMenuItem.Name = "eliminarCategoriasToolStripMenuItem";
            this.eliminarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.eliminarCategoriasToolStripMenuItem.Text = "Eliminar Categorias";
            // 
            // eliminarMarcasToolStripMenuItem
            // 
            this.eliminarMarcasToolStripMenuItem.Name = "eliminarMarcasToolStripMenuItem";
            this.eliminarMarcasToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.eliminarMarcasToolStripMenuItem.Text = "Eliminar Marcas";
            // 
            // eliminarProductosToolStripMenuItem1
            // 
            this.eliminarProductosToolStripMenuItem1.Name = "eliminarProductosToolStripMenuItem1";
            this.eliminarProductosToolStripMenuItem1.Size = new System.Drawing.Size(238, 26);
            this.eliminarProductosToolStripMenuItem1.Text = "Eliminar Productos";
            // 
            // eliminarProveedoresToolStripMenuItem1
            // 
            this.eliminarProveedoresToolStripMenuItem1.Name = "eliminarProveedoresToolStripMenuItem1";
            this.eliminarProveedoresToolStripMenuItem1.Size = new System.Drawing.Size(238, 26);
            this.eliminarProveedoresToolStripMenuItem1.Text = "Eliminar Proveedores";
            // 
            // actualizarElementosToolStripMenuItem
            // 
            this.actualizarElementosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarCategoriaToolStripMenuItem,
            this.actualizarClienteToolStripMenuItem1,
            this.actualizarMarcasToolStripMenuItem,
            this.acutalizarProductosToolStripMenuItem,
            this.actualizarProveedoresToolStripMenuItem1,
            this.actualizarEmpleadoToolStripMenuItem});
            this.actualizarElementosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.actualizarElementosToolStripMenuItem.Name = "actualizarElementosToolStripMenuItem";
            this.actualizarElementosToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.actualizarElementosToolStripMenuItem.Text = "Actualizar &Registro";
            // 
            // actualizarCategoriaToolStripMenuItem
            // 
            this.actualizarCategoriaToolStripMenuItem.Name = "actualizarCategoriaToolStripMenuItem";
            this.actualizarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.actualizarCategoriaToolStripMenuItem.Text = "Actualizar Categoria";
            // 
            // actualizarClienteToolStripMenuItem1
            // 
            this.actualizarClienteToolStripMenuItem1.Name = "actualizarClienteToolStripMenuItem1";
            this.actualizarClienteToolStripMenuItem1.Size = new System.Drawing.Size(250, 26);
            this.actualizarClienteToolStripMenuItem1.Text = "Actualizar Cliente";
            // 
            // actualizarMarcasToolStripMenuItem
            // 
            this.actualizarMarcasToolStripMenuItem.Name = "actualizarMarcasToolStripMenuItem";
            this.actualizarMarcasToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.actualizarMarcasToolStripMenuItem.Text = "Actualizar Marcas";
            // 
            // acutalizarProductosToolStripMenuItem
            // 
            this.acutalizarProductosToolStripMenuItem.Name = "acutalizarProductosToolStripMenuItem";
            this.acutalizarProductosToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.acutalizarProductosToolStripMenuItem.Text = "Acutalizar Productos";
            // 
            // actualizarProveedoresToolStripMenuItem1
            // 
            this.actualizarProveedoresToolStripMenuItem1.Name = "actualizarProveedoresToolStripMenuItem1";
            this.actualizarProveedoresToolStripMenuItem1.Size = new System.Drawing.Size(250, 26);
            this.actualizarProveedoresToolStripMenuItem1.Text = "Actualizar Proveedores";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.cerrarSesionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar &Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // eliminarEmpleadoToolStripMenuItem
            // 
            this.eliminarEmpleadoToolStripMenuItem.Name = "eliminarEmpleadoToolStripMenuItem";
            this.eliminarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.eliminarEmpleadoToolStripMenuItem.Text = "Eliminar Empleado";
            // 
            // actualizarEmpleadoToolStripMenuItem
            // 
            this.actualizarEmpleadoToolStripMenuItem.Name = "actualizarEmpleadoToolStripMenuItem";
            this.actualizarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.actualizarEmpleadoToolStripMenuItem.Text = "Actualizar Empleado";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 591);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.tscMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Ferropapus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tscMain.ResumeLayout(false);
            this.tscMain.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menu;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private ToolStripMenuItem verVentasToolStripMenuItem;
        private ToolStripMenuItem agregarNuevoToolStripMenuItem;
        private ToolStripMenuItem consultarElementosToolStripMenuItem;
        private ToolStripMenuItem eliminarElementosToolStripMenuItem;
        private ToolStripMenuItem actualizarElementosToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem verClientesToolStripMenuItem1;
        private ToolStripMenuItem verCategoriasToolStripMenuItem1;
        private ToolStripMenuItem verEmpleadosToolStripMenuItem1;
        private ToolStripMenuItem verMarcasToolStripMenuItem1;
        private ToolStripMenuItem verProductosToolStripMenuItem1;
        private ToolStripMenuItem verProveedoresToolStripMenuItem1;
        private ToolStripMenuItem eliminarClientesToolStripMenuItem1;
        private ToolStripMenuItem eliminarCategoriasToolStripMenuItem;
        private ToolStripMenuItem eliminarMarcasToolStripMenuItem;
        private ToolStripMenuItem eliminarProductosToolStripMenuItem1;
        private ToolStripMenuItem eliminarProveedoresToolStripMenuItem1;
        private ToolStripMenuItem actualizarCategoriaToolStripMenuItem;
        private ToolStripMenuItem actualizarClienteToolStripMenuItem1;
        private ToolStripMenuItem actualizarMarcasToolStripMenuItem;
        private ToolStripMenuItem acutalizarProductosToolStripMenuItem;
        private ToolStripMenuItem actualizarProveedoresToolStripMenuItem1;
        private ToolStripMenuItem nuevaCategoriaToolStripMenuItem;
        private ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private ToolStripMenuItem nuevaMarcaToolStripMenuItem;
        private ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private ToolStripMenuItem nuevoProveedorToolStripMenuItem;
        public ToolStripContainer tscMain;
        private ToolStripMenuItem nuevoEmpleadoToolStripMenuItem;
        private ToolStripMenuItem eliminarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem actualizarEmpleadoToolStripMenuItem;
    }
}