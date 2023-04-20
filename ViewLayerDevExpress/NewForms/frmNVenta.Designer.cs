namespace ViewLayerDevExpress.NewForms
{
    partial class frmNVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNVenta));
            this.DatosVenta = new DevExpress.XtraEditors.GroupControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAlmacenar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.rlookCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFecha = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcProductos = new DevExpress.XtraGrid.GridControl();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlookCategoria = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colStock_Disponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlookMarca = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DatosVenta)).BeginInit();
            this.DatosVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rlookCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlookCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlookMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosVenta
            // 
            this.DatosVenta.Controls.Add(this.btnCancelar);
            this.DatosVenta.Controls.Add(this.btnAlmacenar);
            this.DatosVenta.Controls.Add(this.labelControl5);
            this.DatosVenta.Controls.Add(this.lblTotal);
            this.DatosVenta.Controls.Add(this.labelControl4);
            this.DatosVenta.Controls.Add(this.rlookCliente);
            this.DatosVenta.Controls.Add(this.labelControl3);
            this.DatosVenta.Controls.Add(this.txtFecha);
            this.DatosVenta.Controls.Add(this.labelControl2);
            this.DatosVenta.Controls.Add(this.labelControl1);
            this.DatosVenta.Location = new System.Drawing.Point(13, 13);
            this.DatosVenta.Name = "DatosVenta";
            this.DatosVenta.Size = new System.Drawing.Size(964, 177);
            this.DatosVenta.TabIndex = 0;
            this.DatosVenta.Text = "Detalles de la venta";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancelar.ImageOptions.SvgImage")));
            this.btnCancelar.Location = new System.Drawing.Point(755, 101);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(162, 65);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar Venta";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlmacenar
            // 
            this.btnAlmacenar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAlmacenar.ImageOptions.SvgImage")));
            this.btnAlmacenar.Location = new System.Drawing.Point(755, 30);
            this.btnAlmacenar.Name = "btnAlmacenar";
            this.btnAlmacenar.Size = new System.Drawing.Size(162, 65);
            this.btnAlmacenar.TabIndex = 8;
            this.btnAlmacenar.Text = "Guardar Venta";
            this.btnAlmacenar.Click += new System.EventHandler(this.btnAlmacenar_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(25, 149);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(462, 23);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Haga Clic en los Productos de la Lista que Desea Comprar";
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Location = new System.Drawing.Point(659, 66);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "000.00";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(590, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 20);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Total: ";
            // 
            // rlookCliente
            // 
            this.rlookCliente.Location = new System.Drawing.Point(84, 103);
            this.rlookCliente.Name = "rlookCliente";
            this.rlookCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlookCliente.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_Cliente", "ID_Cliente", 82, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre_Cliente", "Nombre del Cliente", 122, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Direccion_Cliente", "Direccion_Cliente", 130, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Telefono_Cliente", "Telefono_Cliente", 126, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email_Cliente", "Email_Cliente", 104, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 55, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlookCliente.Properties.DataSource = this.clientesBindingSource;
            this.rlookCliente.Properties.DisplayMember = "Nombre_Cliente";
            this.rlookCliente.Properties.ValueMember = "ID_Cliente";
            this.rlookCliente.Size = new System.Drawing.Size(250, 30);
            this.rlookCliente.TabIndex = 4;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(BOL.Cliente.Clientes);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 20);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Cliente: ";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(144, 66);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(36, 20);
            this.txtFecha.TabIndex = 2;
            this.txtFecha.Text = "fecha";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 20);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Fecha de Hoy: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(121, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Empleado Actual: ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcProductos);
            this.groupControl1.Location = new System.Drawing.Point(13, 196);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(964, 347);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Productos";
            // 
            // gcProductos
            // 
            this.gcProductos.DataSource = this.productosBindingSource;
            this.gcProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProductos.Location = new System.Drawing.Point(2, 27);
            this.gcProductos.MainView = this.gvProductos;
            this.gcProductos.Name = "gcProductos";
            this.gcProductos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlookMarca,
            this.rlookCategoria});
            this.gcProductos.Size = new System.Drawing.Size(960, 318);
            this.gcProductos.TabIndex = 0;
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
            this.gvProductos.OptionsBehavior.Editable = false;
            this.gvProductos.OptionsCustomization.AllowColumnMoving = false;
            this.gvProductos.OptionsMenu.EnableColumnMenu = false;
            this.gvProductos.OptionsView.ShowGroupPanel = false;
            this.gvProductos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvProductos_RowClick);
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
            this.colID_Categoria.ColumnEdit = this.rlookCategoria;
            this.colID_Categoria.FieldName = "ID_Categoria";
            this.colID_Categoria.MinWidth = 25;
            this.colID_Categoria.Name = "colID_Categoria";
            this.colID_Categoria.Visible = true;
            this.colID_Categoria.VisibleIndex = 4;
            this.colID_Categoria.Width = 94;
            // 
            // rlookCategoria
            // 
            this.rlookCategoria.AutoHeight = false;
            this.rlookCategoria.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlookCategoria.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_Categoria", "ID_Categoria", 101, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre_Categoria", "Categoria", 141, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 55, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlookCategoria.DataSource = this.categoriasBindingSource;
            this.rlookCategoria.DisplayMember = "Nombre_Categoria";
            this.rlookCategoria.Name = "rlookCategoria";
            this.rlookCategoria.ValueMember = "ID_Categoria";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(BOL.Categoria.Categorias);
            // 
            // colStock_Disponible
            // 
            this.colStock_Disponible.Caption = "Stock";
            this.colStock_Disponible.FieldName = "Stock_Disponible";
            this.colStock_Disponible.MinWidth = 25;
            this.colStock_Disponible.Name = "colStock_Disponible";
            this.colStock_Disponible.Visible = true;
            this.colStock_Disponible.VisibleIndex = 5;
            this.colStock_Disponible.Width = 94;
            // 
            // colID_Marca
            // 
            this.colID_Marca.ColumnEdit = this.rlookMarca;
            this.colID_Marca.FieldName = "ID_Marca";
            this.colID_Marca.MinWidth = 25;
            this.colID_Marca.Name = "colID_Marca";
            this.colID_Marca.Width = 94;
            // 
            // rlookMarca
            // 
            this.rlookMarca.AutoHeight = false;
            this.rlookMarca.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlookMarca.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_Marca", "ID_Marca", 77, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_Proveedor", "ID_Proveedor", 104, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre_Marca", "Marca", 117, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 55, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlookMarca.DataSource = this.marcasBindingSource;
            this.rlookMarca.DisplayMember = "Nombre_Marca";
            this.rlookMarca.Name = "rlookMarca";
            this.rlookMarca.ValueMember = "ID_Marca";
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataSource = typeof(BOL.Marca.Marcas);
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 25;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 94;
            // 
            // frmNVenta
            // 
            this.AcceptButton = this.btnAlmacenar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 555);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.DatosVenta);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmNVenta.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmNVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Venta";
            this.Load += new System.EventHandler(this.frmNVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosVenta)).EndInit();
            this.DatosVenta.ResumeLayout(false);
            this.DatosVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rlookCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlookCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlookMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl DatosVenta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl txtFecha;
        private DevExpress.XtraEditors.LookUpEdit rlookCliente;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductos;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Categoria;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlookCategoria;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Disponible;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Marca;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlookMarca;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnAlmacenar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
    }
}