namespace ViewLayerDevExpress.Empresa
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNuevoProv = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditarProv = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarProv = new DevExpress.XtraBars.BarButtonItem();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcProveedores = new DevExpress.XtraGrid.GridControl();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvProveedores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_Proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion_Proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono_Proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail_Proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNuevoProv,
            this.btnEditarProv,
            this.btnEliminarProv,
            this.btnActualizar});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevoProv, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEditarProv, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminarProv, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnNuevoProv
            // 
            this.btnNuevoProv.Caption = "Nuevo";
            this.btnNuevoProv.Id = 0;
            this.btnNuevoProv.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNuevoProv.ImageOptions.SvgImage")));
            this.btnNuevoProv.Name = "btnNuevoProv";
            this.btnNuevoProv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevoProv_ItemClick);
            // 
            // btnEditarProv
            // 
            this.btnEditarProv.Caption = "Editar";
            this.btnEditarProv.Id = 1;
            this.btnEditarProv.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditarProv.ImageOptions.SvgImage")));
            this.btnEditarProv.Name = "btnEditarProv";
            this.btnEditarProv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditarProv_ItemClick);
            // 
            // btnEliminarProv
            // 
            this.btnEliminarProv.Caption = "Eliminar";
            this.btnEliminarProv.Id = 2;
            this.btnEliminarProv.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEliminarProv.ImageOptions.SvgImage")));
            this.btnEliminarProv.Name = "btnEliminarProv";
            this.btnEliminarProv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminarProv_ItemClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 3;
            this.btnActualizar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnActualizar.ImageOptions.SvgImage")));
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(991, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 593);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(991, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 553);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(991, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 553);
            // 
            // gcProveedores
            // 
            this.gcProveedores.DataSource = this.proveedoresBindingSource;
            this.gcProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProveedores.Location = new System.Drawing.Point(0, 40);
            this.gcProveedores.MainView = this.gvProveedores;
            this.gcProveedores.MenuManager = this.barManager1;
            this.gcProveedores.Name = "gcProveedores";
            this.gcProveedores.Size = new System.Drawing.Size(991, 553);
            this.gcProveedores.TabIndex = 4;
            this.gcProveedores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProveedores});
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataSource = typeof(BOL.Proveedor.Proveedores);
            // 
            // gvProveedores
            // 
            this.gvProveedores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Proveedor,
            this.colNombre_Proveedor,
            this.colDireccion_Proveedor,
            this.colTelefono_Proveedor,
            this.colEmail_Proveedor,
            this.colactivo});
            this.gvProveedores.GridControl = this.gcProveedores;
            this.gvProveedores.Name = "gvProveedores";
            this.gvProveedores.OptionsBehavior.Editable = false;
            this.gvProveedores.OptionsMenu.EnableColumnMenu = false;
            // 
            // colID_Proveedor
            // 
            this.colID_Proveedor.FieldName = "ID_Proveedor";
            this.colID_Proveedor.MinWidth = 25;
            this.colID_Proveedor.Name = "colID_Proveedor";
            this.colID_Proveedor.Width = 94;
            // 
            // colNombre_Proveedor
            // 
            this.colNombre_Proveedor.Caption = "Nombre";
            this.colNombre_Proveedor.FieldName = "Nombre_Proveedor";
            this.colNombre_Proveedor.MinWidth = 25;
            this.colNombre_Proveedor.Name = "colNombre_Proveedor";
            this.colNombre_Proveedor.Visible = true;
            this.colNombre_Proveedor.VisibleIndex = 0;
            this.colNombre_Proveedor.Width = 94;
            // 
            // colDireccion_Proveedor
            // 
            this.colDireccion_Proveedor.Caption = "Direccion";
            this.colDireccion_Proveedor.FieldName = "Direccion_Proveedor";
            this.colDireccion_Proveedor.MinWidth = 25;
            this.colDireccion_Proveedor.Name = "colDireccion_Proveedor";
            this.colDireccion_Proveedor.Visible = true;
            this.colDireccion_Proveedor.VisibleIndex = 1;
            this.colDireccion_Proveedor.Width = 94;
            // 
            // colTelefono_Proveedor
            // 
            this.colTelefono_Proveedor.Caption = "Telefono";
            this.colTelefono_Proveedor.FieldName = "Telefono_Proveedor";
            this.colTelefono_Proveedor.MinWidth = 25;
            this.colTelefono_Proveedor.Name = "colTelefono_Proveedor";
            this.colTelefono_Proveedor.Visible = true;
            this.colTelefono_Proveedor.VisibleIndex = 2;
            this.colTelefono_Proveedor.Width = 94;
            // 
            // colEmail_Proveedor
            // 
            this.colEmail_Proveedor.Caption = "Email";
            this.colEmail_Proveedor.FieldName = "Email_Proveedor";
            this.colEmail_Proveedor.MinWidth = 25;
            this.colEmail_Proveedor.Name = "colEmail_Proveedor";
            this.colEmail_Proveedor.Visible = true;
            this.colEmail_Proveedor.VisibleIndex = 3;
            this.colEmail_Proveedor.Width = 94;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 25;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 94;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 619);
            this.Controls.Add(this.gcProveedores);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnNuevoProv;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnEditarProv;
        private DevExpress.XtraBars.BarButtonItem btnEliminarProv;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraGrid.GridControl gcProveedores;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProveedores;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion_Proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono_Proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail_Proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
    }
}