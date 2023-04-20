namespace ViewLayerDevExpress.Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.topBar = new DevExpress.XtraBars.Bar();
            this.menuArchivo = new DevExpress.XtraBars.BarSubItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.btnInicio = new DevExpress.XtraBars.BarButtonItem();
            this.menuCatalogo = new DevExpress.XtraBars.BarSubItem();
            this.btnCategorias = new DevExpress.XtraBars.BarButtonItem();
            this.btnMarcas = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductos = new DevExpress.XtraBars.BarButtonItem();
            this.menuEmpresa = new DevExpress.XtraBars.BarSubItem();
            this.btnProveedor = new DevExpress.XtraBars.BarButtonItem();
            this.btnClientes = new DevExpress.XtraBars.BarButtonItem();
            this.btnVentas = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmpleados = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.AllowShowToolbarsPopup = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.topBar,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnInicio,
            this.menuArchivo,
            this.menuCatalogo,
            this.btnSalir,
            this.barButtonItem2,
            this.btnLogout,
            this.btnCategorias,
            this.btnMarcas,
            this.btnProductos,
            this.barButtonItem7,
            this.menuEmpresa,
            this.btnProveedor,
            this.btnClientes,
            this.btnVentas,
            this.btnEmpleados});
            this.barManager1.MainMenu = this.topBar;
            this.barManager1.MaxItemId = 20;
            this.barManager1.OptionsLayout.AllowAddNewItems = false;
            this.barManager1.StatusBar = this.bar3;
            // 
            // topBar
            // 
            this.topBar.BarName = "Main menu";
            this.topBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.topBar.DockCol = 0;
            this.topBar.DockRow = 0;
            this.topBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.topBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.menuArchivo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInicio, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.menuCatalogo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.menuEmpresa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLogout, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.topBar.OptionsBar.AllowQuickCustomization = false;
            this.topBar.OptionsBar.DisableClose = true;
            this.topBar.OptionsBar.DisableCustomization = true;
            this.topBar.OptionsBar.DrawBorder = false;
            this.topBar.OptionsBar.DrawDragBorder = false;
            this.topBar.OptionsBar.MultiLine = true;
            this.topBar.OptionsBar.UseWholeRow = true;
            this.topBar.Text = "Main menu";
            // 
            // menuArchivo
            // 
            this.menuArchivo.Caption = "Archivo";
            this.menuArchivo.Id = 1;
            this.menuArchivo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menuArchivo.ImageOptions.SvgImage")));
            this.menuArchivo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSalir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.menuArchivo.Name = "menuArchivo";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 3;
            this.btnSalir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSalir.ImageOptions.SvgImage")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // btnInicio
            // 
            this.btnInicio.Caption = "Inicio";
            this.btnInicio.Id = 0;
            this.btnInicio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.ImageOptions.Image")));
            this.btnInicio.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInicio.ImageOptions.LargeImage")));
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // menuCatalogo
            // 
            this.menuCatalogo.Caption = "Catalogo";
            this.menuCatalogo.Id = 2;
            this.menuCatalogo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuCatalogo.ImageOptions.Image")));
            this.menuCatalogo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuCatalogo.ImageOptions.LargeImage")));
            this.menuCatalogo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCategorias, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnMarcas, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnProductos, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.menuCatalogo.Name = "menuCatalogo";
            // 
            // btnCategorias
            // 
            this.btnCategorias.Caption = "Categorias";
            this.btnCategorias.Id = 7;
            this.btnCategorias.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCategorias.ImageOptions.SvgImage")));
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Caption = "Marcas";
            this.btnMarcas.Id = 9;
            this.btnMarcas.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMarcas.ImageOptions.SvgImage")));
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMarcas_ItemClick);
            // 
            // btnProductos
            // 
            this.btnProductos.Caption = "Productos";
            this.btnProductos.Id = 10;
            this.btnProductos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProductos.ImageOptions.SvgImage")));
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductos_ItemClick);
            // 
            // menuEmpresa
            // 
            this.menuEmpresa.Caption = "Empresa";
            this.menuEmpresa.Id = 14;
            this.menuEmpresa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menuEmpresa.ImageOptions.SvgImage")));
            this.menuEmpresa.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnProveedor, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClientes, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnVentas, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEmpleados, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.menuEmpresa.Name = "menuEmpresa";
            // 
            // btnProveedor
            // 
            this.btnProveedor.Caption = "Proveedores";
            this.btnProveedor.Id = 15;
            this.btnProveedor.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProveedor.ImageOptions.SvgImage")));
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProveedor_ItemClick);
            // 
            // btnClientes
            // 
            this.btnClientes.Caption = "Clientes";
            this.btnClientes.Id = 16;
            this.btnClientes.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClientes.ImageOptions.SvgImage")));
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClientes_ItemClick);
            // 
            // btnVentas
            // 
            this.btnVentas.Caption = "Ventas";
            this.btnVentas.Id = 17;
            this.btnVentas.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnVentas.ImageOptions.SvgImage")));
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVentas_ItemClick);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Caption = "Empleados";
            this.btnEmpleados.Id = 18;
            this.btnEmpleados.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEmpleados.ImageOptions.SvgImage")));
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmpleados_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Cerrar Sesion";
            this.btnLogout.Id = 6;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.LargeImage")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(998, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 666);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(998, 28);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 619);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(998, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 619);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Cerrar Sesion";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Id = 13;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 694);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmMain.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FerroPAPUS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar topBar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnInicio;
        private DevExpress.XtraBars.BarSubItem menuArchivo;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarSubItem menuCatalogo;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnCategorias;
        private DevExpress.XtraBars.BarButtonItem btnMarcas;
        private DevExpress.XtraBars.BarButtonItem btnProductos;
        private DevExpress.XtraBars.BarSubItem menuEmpresa;
        private DevExpress.XtraBars.BarButtonItem btnProveedor;
        private DevExpress.XtraBars.BarButtonItem btnClientes;
        private DevExpress.XtraBars.BarButtonItem btnVentas;
        private DevExpress.XtraBars.BarButtonItem btnEmpleados;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
    }
}