namespace ViewLayerDevExpress.Catalogos
{
    partial class frmMarcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarcas));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnNuevaMarca = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditarMarca = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarMarca = new DevExpress.XtraBars.BarButtonItem();
            this.btnActualizarMarca = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcMarcas = new DevExpress.XtraGrid.GridControl();
            this.gvMarcas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlookProveedores = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNombre_Marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlookProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Offset = 9;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Offset = 9;
            this.bar2.Text = "Tools";
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.AllowShowToolbarsPopup = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNuevaMarca,
            this.btnEditarMarca,
            this.btnEliminarMarca,
            this.btnActualizarMarca});
            this.barManager1.MaxItemId = 4;
            // 
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevaMarca, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEditarMarca, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminarMarca, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizarMarca, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DisableClose = true;
            this.bar3.OptionsBar.DisableCustomization = true;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.Text = "Tools";
            // 
            // btnNuevaMarca
            // 
            this.btnNuevaMarca.Caption = "Nuevo";
            this.btnNuevaMarca.Id = 0;
            this.btnNuevaMarca.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNuevaMarca.ImageOptions.SvgImage")));
            this.btnNuevaMarca.Name = "btnNuevaMarca";
            this.btnNuevaMarca.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevaMarca_ItemClick);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Caption = "Editar";
            this.btnEditarMarca.Id = 1;
            this.btnEditarMarca.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditarMarca.ImageOptions.SvgImage")));
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditarMarca_ItemClick);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Caption = "Eliminar";
            this.btnEliminarMarca.Id = 2;
            this.btnEliminarMarca.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEliminarMarca.ImageOptions.SvgImage")));
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminarMarca_ItemClick);
            // 
            // btnActualizarMarca
            // 
            this.btnActualizarMarca.Caption = "Actualizar";
            this.btnActualizarMarca.Id = 3;
            this.btnActualizarMarca.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnActualizarMarca.ImageOptions.SvgImage")));
            this.btnActualizarMarca.Name = "btnActualizarMarca";
            this.btnActualizarMarca.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizarMarca_ItemClick);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 579);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(991, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 539);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(991, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 539);
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataSource = typeof(BOL.Marca.Marcas);
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataSource = typeof(BOL.Proveedor.Proveedores);
            // 
            // gcMarcas
            // 
            this.gcMarcas.DataSource = this.marcasBindingSource;
            this.gcMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMarcas.Location = new System.Drawing.Point(0, 40);
            this.gcMarcas.MainView = this.gvMarcas;
            this.gcMarcas.MenuManager = this.barManager1;
            this.gcMarcas.Name = "gcMarcas";
            this.gcMarcas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlookProveedores});
            this.gcMarcas.Size = new System.Drawing.Size(991, 539);
            this.gcMarcas.TabIndex = 14;
            this.gcMarcas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMarcas});
            // 
            // gvMarcas
            // 
            this.gvMarcas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Marca,
            this.colID_Proveedor,
            this.colNombre_Marca,
            this.colactivo});
            this.gvMarcas.GridControl = this.gcMarcas;
            this.gvMarcas.Name = "gvMarcas";
            this.gvMarcas.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvMarcas.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvMarcas.OptionsBehavior.Editable = false;
            this.gvMarcas.OptionsCustomization.AllowColumnMoving = false;
            this.gvMarcas.OptionsMenu.EnableColumnMenu = false;
            this.gvMarcas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvMarcas.OptionsView.ShowAutoFilterRow = true;
            this.gvMarcas.OptionsView.ShowGroupPanel = false;
            // 
            // colID_Marca
            // 
            this.colID_Marca.FieldName = "ID_Marca";
            this.colID_Marca.MinWidth = 25;
            this.colID_Marca.Name = "colID_Marca";
            this.colID_Marca.Visible = true;
            this.colID_Marca.VisibleIndex = 0;
            this.colID_Marca.Width = 94;
            // 
            // colID_Proveedor
            // 
            this.colID_Proveedor.Caption = "Nombre del Proveedor";
            this.colID_Proveedor.ColumnEdit = this.rlookProveedores;
            this.colID_Proveedor.FieldName = "ID_Proveedor";
            this.colID_Proveedor.MinWidth = 25;
            this.colID_Proveedor.Name = "colID_Proveedor";
            this.colID_Proveedor.Visible = true;
            this.colID_Proveedor.VisibleIndex = 1;
            this.colID_Proveedor.Width = 94;
            // 
            // rlookProveedores
            // 
            this.rlookProveedores.AutoHeight = false;
            this.rlookProveedores.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlookProveedores.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_Proveedor", "ID_Proveedor", 104, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre_Proveedor", "Nombre_Proveedor", 144, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Direccion_Proveedor", "Direccion_Proveedor", 152, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Telefono_Proveedor", "Telefono_Proveedor", 148, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email_Proveedor", "Email_Proveedor", 126, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 55, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlookProveedores.DataSource = this.proveedoresBindingSource;
            this.rlookProveedores.DisplayMember = "Nombre_Proveedor";
            this.rlookProveedores.Name = "rlookProveedores";
            this.rlookProveedores.ValueMember = "ID_Proveedor";
            // 
            // colNombre_Marca
            // 
            this.colNombre_Marca.Caption = "Nombre de la marca";
            this.colNombre_Marca.FieldName = "Nombre_Marca";
            this.colNombre_Marca.MinWidth = 25;
            this.colNombre_Marca.Name = "colNombre_Marca";
            this.colNombre_Marca.Visible = true;
            this.colNombre_Marca.VisibleIndex = 2;
            this.colNombre_Marca.Width = 94;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 25;
            this.colactivo.Name = "colactivo";
            this.colactivo.Visible = true;
            this.colactivo.VisibleIndex = 3;
            this.colactivo.Width = 94;
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 579);
            this.Controls.Add(this.gcMarcas);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlookProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnNuevaMarca;
        private DevExpress.XtraBars.BarButtonItem btnEditarMarca;
        private DevExpress.XtraBars.BarButtonItem btnEliminarMarca;
        private DevExpress.XtraBars.BarButtonItem btnActualizarMarca;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private DevExpress.XtraGrid.GridControl gcMarcas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMarcas;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Marca;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Marca;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlookProveedores;
    }
}