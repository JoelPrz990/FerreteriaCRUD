namespace ViewLayerDevExpress.Empresa
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNCliente = new DevExpress.XtraBars.BarButtonItem();
            this.btnUCliente = new DevExpress.XtraBars.BarButtonItem();
            this.btnECliente = new DevExpress.XtraBars.BarButtonItem();
            this.btnACliente = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcClientes = new DevExpress.XtraGrid.GridControl();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion_Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono_Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail_Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
            this.SuspendLayout();
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
            this.btnNCliente,
            this.btnUCliente,
            this.btnECliente,
            this.btnACliente});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNCliente, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUCliente, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnECliente, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnACliente, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Tools";
            // 
            // btnNCliente
            // 
            this.btnNCliente.Caption = "Nuevo";
            this.btnNCliente.Id = 0;
            this.btnNCliente.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNCliente.ImageOptions.SvgImage")));
            this.btnNCliente.Name = "btnNCliente";
            this.btnNCliente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNCliente_ItemClick);
            // 
            // btnUCliente
            // 
            this.btnUCliente.Caption = "Editar";
            this.btnUCliente.Id = 1;
            this.btnUCliente.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUCliente.ImageOptions.SvgImage")));
            this.btnUCliente.Name = "btnUCliente";
            this.btnUCliente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUCliente_ItemClick);
            // 
            // btnECliente
            // 
            this.btnECliente.Caption = "Eliminar";
            this.btnECliente.Id = 2;
            this.btnECliente.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnECliente.ImageOptions.SvgImage")));
            this.btnECliente.Name = "btnECliente";
            this.btnECliente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnECliente_ItemClick);
            // 
            // btnACliente
            // 
            this.btnACliente.Caption = "Actualizar";
            this.btnACliente.Id = 3;
            this.btnACliente.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnACliente.ImageOptions.SvgImage")));
            this.btnACliente.Name = "btnACliente";
            this.btnACliente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnACliente_ItemClick);
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
            // gcClientes
            // 
            this.gcClientes.DataSource = this.clientesBindingSource;
            this.gcClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcClientes.Location = new System.Drawing.Point(0, 40);
            this.gcClientes.MainView = this.gvClientes;
            this.gcClientes.MenuManager = this.barManager1;
            this.gcClientes.Name = "gcClientes";
            this.gcClientes.Size = new System.Drawing.Size(991, 579);
            this.gcClientes.TabIndex = 4;
            this.gcClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClientes});
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(BOL.Cliente.Clientes);
            // 
            // gvClientes
            // 
            this.gvClientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Cliente,
            this.colNombre_Cliente,
            this.colDireccion_Cliente,
            this.colTelefono_Cliente,
            this.colEmail_Cliente,
            this.colactivo});
            this.gvClientes.GridControl = this.gcClientes;
            this.gvClientes.Name = "gvClientes";
            this.gvClientes.OptionsBehavior.Editable = false;
            this.gvClientes.OptionsMenu.EnableColumnMenu = false;
            // 
            // colID_Cliente
            // 
            this.colID_Cliente.FieldName = "ID_Cliente";
            this.colID_Cliente.MinWidth = 25;
            this.colID_Cliente.Name = "colID_Cliente";
            this.colID_Cliente.Width = 94;
            // 
            // colNombre_Cliente
            // 
            this.colNombre_Cliente.Caption = "Nombre del Cliente";
            this.colNombre_Cliente.FieldName = "Nombre_Cliente";
            this.colNombre_Cliente.MinWidth = 25;
            this.colNombre_Cliente.Name = "colNombre_Cliente";
            this.colNombre_Cliente.Visible = true;
            this.colNombre_Cliente.VisibleIndex = 0;
            this.colNombre_Cliente.Width = 94;
            // 
            // colDireccion_Cliente
            // 
            this.colDireccion_Cliente.Caption = "Direccion";
            this.colDireccion_Cliente.FieldName = "Direccion_Cliente";
            this.colDireccion_Cliente.MinWidth = 25;
            this.colDireccion_Cliente.Name = "colDireccion_Cliente";
            this.colDireccion_Cliente.Visible = true;
            this.colDireccion_Cliente.VisibleIndex = 1;
            this.colDireccion_Cliente.Width = 94;
            // 
            // colTelefono_Cliente
            // 
            this.colTelefono_Cliente.Caption = "Telefono";
            this.colTelefono_Cliente.FieldName = "Telefono_Cliente";
            this.colTelefono_Cliente.MinWidth = 25;
            this.colTelefono_Cliente.Name = "colTelefono_Cliente";
            this.colTelefono_Cliente.Visible = true;
            this.colTelefono_Cliente.VisibleIndex = 2;
            this.colTelefono_Cliente.Width = 94;
            // 
            // colEmail_Cliente
            // 
            this.colEmail_Cliente.Caption = "Email";
            this.colEmail_Cliente.FieldName = "Email_Cliente";
            this.colEmail_Cliente.MinWidth = 25;
            this.colEmail_Cliente.Name = "colEmail_Cliente";
            this.colEmail_Cliente.Visible = true;
            this.colEmail_Cliente.VisibleIndex = 3;
            this.colEmail_Cliente.Width = 94;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 25;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 94;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 619);
            this.Controls.Add(this.gcClientes);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnNCliente;
        private DevExpress.XtraBars.BarButtonItem btnUCliente;
        private DevExpress.XtraBars.BarButtonItem btnECliente;
        private DevExpress.XtraBars.BarButtonItem btnACliente;
        private DevExpress.XtraGrid.GridControl gcClientes;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClientes;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion_Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono_Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail_Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
    }
}