namespace ViewLayerDevExpress.Empresa
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNuevaVenta = new DevExpress.XtraBars.BarButtonItem();
            this.btnArchivar = new DevExpress.XtraBars.BarButtonItem();
            this.btnArchivado = new DevExpress.XtraBars.BarButtonItem();
            this.btnRegresar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcVentas = new DevExpress.XtraGrid.GridControl();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvVentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_Venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlookCliente = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID_Empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlookEmpleado = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlookCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlookEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.AllowShowToolbarsPopup = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNuevaVenta,
            this.btnArchivar,
            this.btnArchivado,
            this.btnRegresar});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevaVenta, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnArchivar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnArchivado, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRegresar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Tools";
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Caption = "Nueva Venta";
            this.btnNuevaVenta.Id = 0;
            this.btnNuevaVenta.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNuevaVenta.ImageOptions.SvgImage")));
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevaVenta_ItemClick);
            // 
            // btnArchivar
            // 
            this.btnArchivar.Caption = "Archivar Venta";
            this.btnArchivar.Id = 1;
            this.btnArchivar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnArchivar.ImageOptions.SvgImage")));
            this.btnArchivar.Name = "btnArchivar";
            this.btnArchivar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnArchivar_ItemClick);
            // 
            // btnArchivado
            // 
            this.btnArchivado.Caption = "Ver Ventas Archivadas";
            this.btnArchivado.Id = 2;
            this.btnArchivado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnArchivado.ImageOptions.SvgImage")));
            this.btnArchivado.Name = "btnArchivado";
            this.btnArchivado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnArchivado_ItemClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Caption = "Regresar";
            this.btnRegresar.Id = 4;
            this.btnRegresar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRegresar.ImageOptions.SvgImage")));
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRegresar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(991, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 619);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(991, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 579);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(991, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 579);
            // 
            // gcVentas
            // 
            this.gcVentas.DataSource = this.ventasBindingSource;
            this.gcVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVentas.Location = new System.Drawing.Point(0, 40);
            this.gcVentas.MainView = this.gvVentas;
            this.gcVentas.MenuManager = this.barManager1;
            this.gcVentas.Name = "gcVentas";
            this.gcVentas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlookCliente,
            this.rlookEmpleado});
            this.gcVentas.Size = new System.Drawing.Size(991, 579);
            this.gcVentas.TabIndex = 4;
            this.gcVentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVentas});
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataSource = typeof(BOL.Venta.Ventas);
            // 
            // gvVentas
            // 
            this.gvVentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Venta,
            this.colFecha_Venta,
            this.colTotal_Venta,
            this.colID_Cliente,
            this.colID_Empleado,
            this.colactivo});
            this.gvVentas.GridControl = this.gcVentas;
            this.gvVentas.Name = "gvVentas";
            this.gvVentas.OptionsBehavior.Editable = false;
            this.gvVentas.OptionsCustomization.AllowColumnMoving = false;
            this.gvVentas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVentas.OptionsView.ShowGroupPanel = false;
            // 
            // colID_Venta
            // 
            this.colID_Venta.FieldName = "ID_Venta";
            this.colID_Venta.MinWidth = 25;
            this.colID_Venta.Name = "colID_Venta";
            this.colID_Venta.Width = 94;
            // 
            // colFecha_Venta
            // 
            this.colFecha_Venta.Caption = "Fecha de la Venta";
            this.colFecha_Venta.FieldName = "Fecha_Venta";
            this.colFecha_Venta.MinWidth = 25;
            this.colFecha_Venta.Name = "colFecha_Venta";
            this.colFecha_Venta.Visible = true;
            this.colFecha_Venta.VisibleIndex = 0;
            this.colFecha_Venta.Width = 94;
            // 
            // colTotal_Venta
            // 
            this.colTotal_Venta.Caption = "Total de la Venta";
            this.colTotal_Venta.FieldName = "Total_Venta";
            this.colTotal_Venta.MinWidth = 25;
            this.colTotal_Venta.Name = "colTotal_Venta";
            this.colTotal_Venta.Visible = true;
            this.colTotal_Venta.VisibleIndex = 1;
            this.colTotal_Venta.Width = 94;
            // 
            // colID_Cliente
            // 
            this.colID_Cliente.Caption = "Cliente que Compró";
            this.colID_Cliente.ColumnEdit = this.rlookCliente;
            this.colID_Cliente.FieldName = "ID_Cliente";
            this.colID_Cliente.MinWidth = 25;
            this.colID_Cliente.Name = "colID_Cliente";
            this.colID_Cliente.Visible = true;
            this.colID_Cliente.VisibleIndex = 2;
            this.colID_Cliente.Width = 94;
            // 
            // rlookCliente
            // 
            this.rlookCliente.AutoHeight = false;
            this.rlookCliente.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlookCliente.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_Cliente", "ID_Cliente", 82, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre_Cliente", "Nombre del Cliente", 122, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Direccion_Cliente", "Direccion_Cliente", 130, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Telefono_Cliente", "Telefono_Cliente", 126, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email_Cliente", "Email_Cliente", 104, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 55, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlookCliente.DataSource = this.clientesBindingSource;
            this.rlookCliente.DisplayMember = "Nombre_Cliente";
            this.rlookCliente.Name = "rlookCliente";
            this.rlookCliente.ValueMember = "ID_Cliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(BOL.Cliente.Clientes);
            // 
            // colID_Empleado
            // 
            this.colID_Empleado.Caption = "Empleado Vendedor";
            this.colID_Empleado.ColumnEdit = this.rlookEmpleado;
            this.colID_Empleado.FieldName = "ID_Empleado";
            this.colID_Empleado.MinWidth = 25;
            this.colID_Empleado.Name = "colID_Empleado";
            this.colID_Empleado.Visible = true;
            this.colID_Empleado.VisibleIndex = 3;
            this.colID_Empleado.Width = 94;
            // 
            // rlookEmpleado
            // 
            this.rlookEmpleado.AutoHeight = false;
            this.rlookEmpleado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlookEmpleado.DataSource = this.empleadosBindingSource;
            this.rlookEmpleado.DisplayMember = "Nombre_Empleado";
            this.rlookEmpleado.Name = "rlookEmpleado";
            this.rlookEmpleado.ValueMember = "ID_Empleado";
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataSource = typeof(BOL.Empleado.Empleados);
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 25;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 94;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 619);
            this.Controls.Add(this.gcVentas);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentas";
            this.Text = "Historial de Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlookCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlookEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnNuevaVenta;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcVentas;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVentas;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Venta;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Venta;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_Venta;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraBars.BarButtonItem btnArchivar;
        private DevExpress.XtraBars.BarButtonItem btnArchivado;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlookCliente;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlookEmpleado;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private DevExpress.XtraBars.BarButtonItem btnRegresar;
    }
}