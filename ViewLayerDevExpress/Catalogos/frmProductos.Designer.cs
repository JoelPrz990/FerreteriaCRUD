namespace ViewLayerDevExpress.Catalogos
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNProducto = new DevExpress.XtraBars.BarButtonItem();
            this.btnUProducto = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarProd = new DevExpress.XtraBars.BarButtonItem();
            this.btnActualizarProd = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcProductos = new DevExpress.XtraGrid.GridControl();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlookCategorias = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colStock_Disponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlookCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.btnNProducto,
            this.btnUProducto,
            this.btnEliminarProd,
            this.btnActualizarProd});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNProducto, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUProducto, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminarProd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizarProd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Tools";
            // 
            // btnNProducto
            // 
            this.btnNProducto.Caption = "Nuevo";
            this.btnNProducto.Id = 0;
            this.btnNProducto.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNProducto.ImageOptions.SvgImage")));
            this.btnNProducto.Name = "btnNProducto";
            this.btnNProducto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNProducto_ItemClick);
            // 
            // btnUProducto
            // 
            this.btnUProducto.Caption = "Editar";
            this.btnUProducto.Id = 1;
            this.btnUProducto.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUProducto.ImageOptions.SvgImage")));
            this.btnUProducto.Name = "btnUProducto";
            this.btnUProducto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUProducto_ItemClick);
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.Caption = "Eliminar";
            this.btnEliminarProd.Id = 2;
            this.btnEliminarProd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEliminarProd.ImageOptions.SvgImage")));
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminarProd_ItemClick);
            // 
            // btnActualizarProd
            // 
            this.btnActualizarProd.Caption = "Actualizar";
            this.btnActualizarProd.Id = 3;
            this.btnActualizarProd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnActualizarProd.ImageOptions.SvgImage")));
            this.btnActualizarProd.Name = "btnActualizarProd";
            this.btnActualizarProd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizarProd_ItemClick);
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
            // gcProductos
            // 
            this.gcProductos.DataSource = this.productosBindingSource;
            this.gcProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProductos.Location = new System.Drawing.Point(0, 40);
            this.gcProductos.MainView = this.gvProductos;
            this.gcProductos.MenuManager = this.barManager1;
            this.gcProductos.Name = "gcProductos";
            this.gcProductos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlookCategorias});
            this.gcProductos.Size = new System.Drawing.Size(991, 539);
            this.gcProductos.TabIndex = 4;
            this.gcProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductos});
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataSource = typeof(BOL.Producto.Productos);
            // 
            // gvProductos
            // 
            this.gvProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Producto,
            this.colNombre_Producto,
            this.colDescripcion_Producto,
            this.colMarca_Producto,
            this.colPrecio_Producto,
            this.colID_Categoria,
            this.colStock_Disponible,
            this.colID_Marca,
            this.colactivo});
            this.gvProductos.GridControl = this.gcProductos;
            this.gvProductos.Name = "gvProductos";
            this.gvProductos.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvProductos.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvProductos.OptionsBehavior.Editable = false;
            // 
            // colID_Producto
            // 
            this.colID_Producto.FieldName = "ID_Producto";
            this.colID_Producto.MinWidth = 25;
            this.colID_Producto.Name = "colID_Producto";
            this.colID_Producto.Width = 94;
            // 
            // colNombre_Producto
            // 
            this.colNombre_Producto.Caption = "Nombre";
            this.colNombre_Producto.FieldName = "Nombre_Producto";
            this.colNombre_Producto.MinWidth = 25;
            this.colNombre_Producto.Name = "colNombre_Producto";
            this.colNombre_Producto.Visible = true;
            this.colNombre_Producto.VisibleIndex = 0;
            this.colNombre_Producto.Width = 94;
            // 
            // colDescripcion_Producto
            // 
            this.colDescripcion_Producto.Caption = "Descripcion";
            this.colDescripcion_Producto.FieldName = "Descripcion_Producto";
            this.colDescripcion_Producto.MinWidth = 25;
            this.colDescripcion_Producto.Name = "colDescripcion_Producto";
            this.colDescripcion_Producto.Visible = true;
            this.colDescripcion_Producto.VisibleIndex = 1;
            this.colDescripcion_Producto.Width = 94;
            // 
            // colMarca_Producto
            // 
            this.colMarca_Producto.Caption = "Marca";
            this.colMarca_Producto.FieldName = "Marca_Producto";
            this.colMarca_Producto.MinWidth = 25;
            this.colMarca_Producto.Name = "colMarca_Producto";
            this.colMarca_Producto.Visible = true;
            this.colMarca_Producto.VisibleIndex = 2;
            this.colMarca_Producto.Width = 94;
            // 
            // colPrecio_Producto
            // 
            this.colPrecio_Producto.Caption = "Precio";
            this.colPrecio_Producto.FieldName = "Precio_Producto";
            this.colPrecio_Producto.MinWidth = 25;
            this.colPrecio_Producto.Name = "colPrecio_Producto";
            this.colPrecio_Producto.Visible = true;
            this.colPrecio_Producto.VisibleIndex = 3;
            this.colPrecio_Producto.Width = 94;
            // 
            // colID_Categoria
            // 
            this.colID_Categoria.Caption = "Categoria";
            this.colID_Categoria.ColumnEdit = this.rlookCategorias;
            this.colID_Categoria.FieldName = "ID_Categoria";
            this.colID_Categoria.MinWidth = 25;
            this.colID_Categoria.Name = "colID_Categoria";
            this.colID_Categoria.Visible = true;
            this.colID_Categoria.VisibleIndex = 4;
            this.colID_Categoria.Width = 94;
            // 
            // rlookCategorias
            // 
            this.rlookCategorias.AutoHeight = false;
            this.rlookCategorias.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlookCategorias.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_Categoria", "ID_Categoria", 101, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre_Categoria", "Categoria", 141, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 55, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlookCategorias.DataSource = this.categoriasBindingSource;
            this.rlookCategorias.DisplayMember = "Nombre_Categoria";
            this.rlookCategorias.Name = "rlookCategorias";
            this.rlookCategorias.ValueMember = "ID_Categoria";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(BOL.Categoria.Categorias);
            // 
            // colStock_Disponible
            // 
            this.colStock_Disponible.Caption = "Stock Disponible";
            this.colStock_Disponible.FieldName = "Stock_Disponible";
            this.colStock_Disponible.MinWidth = 25;
            this.colStock_Disponible.Name = "colStock_Disponible";
            this.colStock_Disponible.Visible = true;
            this.colStock_Disponible.VisibleIndex = 5;
            this.colStock_Disponible.Width = 94;
            // 
            // colID_Marca
            // 
            this.colID_Marca.FieldName = "ID_Marca";
            this.colID_Marca.MinWidth = 25;
            this.colID_Marca.Name = "colID_Marca";
            this.colID_Marca.Width = 94;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 25;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 94;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 579);
            this.Controls.Add(this.gcProductos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlookCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnNProducto;
        private DevExpress.XtraBars.BarButtonItem btnUProducto;
        private DevExpress.XtraBars.BarButtonItem btnEliminarProd;
        private DevExpress.XtraBars.BarButtonItem btnActualizarProd;
        private DevExpress.XtraGrid.GridControl gcProductos;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductos;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Categoria;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Disponible;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Marca;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlookCategorias;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
    }
}