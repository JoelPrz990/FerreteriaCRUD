namespace ViewLayerDevExpress.Catalogos
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.gcCategorias = new DevExpress.XtraGrid.GridControl();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvCategorias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_Categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNuevoCat = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditCat = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarCat = new DevExpress.XtraBars.BarButtonItem();
            this.btnActualizCat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCategorias
            // 
            this.gcCategorias.DataSource = this.categoriasBindingSource;
            this.gcCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCategorias.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcCategorias.Location = new System.Drawing.Point(0, 40);
            this.gcCategorias.MainView = this.gvCategorias;
            this.gcCategorias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcCategorias.Name = "gcCategorias";
            this.gcCategorias.Size = new System.Drawing.Size(991, 579);
            this.gcCategorias.TabIndex = 0;
            this.gcCategorias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCategorias});
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(BOL.Categoria.Categorias);
            // 
            // gvCategorias
            // 
            this.gvCategorias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Categoria,
            this.colNombre_Categoria,
            this.colactivo});
            this.gvCategorias.DetailHeight = 437;
            this.gvCategorias.GridControl = this.gcCategorias;
            this.gvCategorias.Name = "gvCategorias";
            this.gvCategorias.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCategorias.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCategorias.OptionsBehavior.AutoPopulateColumns = false;
            this.gvCategorias.OptionsBehavior.Editable = false;
            this.gvCategorias.OptionsView.ColumnAutoWidth = false;
            // 
            // colID_Categoria
            // 
            this.colID_Categoria.FieldName = "ID_Categoria";
            this.colID_Categoria.MinWidth = 25;
            this.colID_Categoria.Name = "colID_Categoria";
            this.colID_Categoria.Width = 86;
            // 
            // colNombre_Categoria
            // 
            this.colNombre_Categoria.FieldName = "Nombre_Categoria";
            this.colNombre_Categoria.MinWidth = 25;
            this.colNombre_Categoria.Name = "colNombre_Categoria";
            this.colNombre_Categoria.Visible = true;
            this.colNombre_Categoria.VisibleIndex = 0;
            this.colNombre_Categoria.Width = 252;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 25;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 86;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNuevoCat,
            this.btnEditCat,
            this.btnEliminarCat,
            this.btnActualizCat});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevoCat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEditCat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminarCat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizCat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnNuevoCat
            // 
            this.btnNuevoCat.Caption = "Nuevo";
            this.btnNuevoCat.Id = 0;
            this.btnNuevoCat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNuevoCat.ImageOptions.SvgImage")));
            this.btnNuevoCat.Name = "btnNuevoCat";
            // 
            // btnEditCat
            // 
            this.btnEditCat.Caption = "Editar";
            this.btnEditCat.Id = 1;
            this.btnEditCat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditCat.ImageOptions.SvgImage")));
            this.btnEditCat.Name = "btnEditCat";
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.Caption = "Eliminar";
            this.btnEliminarCat.Id = 2;
            this.btnEliminarCat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEliminarCat.ImageOptions.SvgImage")));
            this.btnEliminarCat.Name = "btnEliminarCat";
            // 
            // btnActualizCat
            // 
            this.btnActualizCat.Caption = "Actualizar";
            this.btnActualizCat.Id = 3;
            this.btnActualizCat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnActualizCat.ImageOptions.SvgImage")));
            this.btnActualizCat.Name = "btnActualizCat";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(991, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 619);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(991, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 579);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(991, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 579);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 619);
            this.Controls.Add(this.gcCategorias);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCategorias;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCategorias;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnNuevoCat;
        private DevExpress.XtraBars.BarButtonItem btnEditCat;
        private DevExpress.XtraBars.BarButtonItem btnEliminarCat;
        private DevExpress.XtraBars.BarButtonItem btnActualizCat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Categoria;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Categoria;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
    }
}