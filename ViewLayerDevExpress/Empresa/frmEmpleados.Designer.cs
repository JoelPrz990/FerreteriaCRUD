namespace ViewLayerDevExpress.Empresa
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNuevoEmpleado = new DevExpress.XtraBars.BarButtonItem();
            this.btnModEmpleado = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarEmpleado = new DevExpress.XtraBars.BarButtonItem();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcEmpleados = new DevExpress.XtraGrid.GridControl();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEmpleados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_Empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion_Empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono_Empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail_Empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCargo_Empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_Usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleados)).BeginInit();
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
            this.btnNuevoEmpleado,
            this.btnModEmpleado,
            this.btnEliminarEmpleado,
            this.btnActualizar});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevoEmpleado, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnModEmpleado, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminarEmpleado, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Tools";
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.Caption = "Nuevo";
            this.btnNuevoEmpleado.Id = 0;
            this.btnNuevoEmpleado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNuevoEmpleado.ImageOptions.SvgImage")));
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevoEmpleado_ItemClick);
            // 
            // btnModEmpleado
            // 
            this.btnModEmpleado.Caption = "Editar";
            this.btnModEmpleado.Id = 1;
            this.btnModEmpleado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnModEmpleado.ImageOptions.SvgImage")));
            this.btnModEmpleado.Name = "btnModEmpleado";
            this.btnModEmpleado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModEmpleado_ItemClick);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Caption = "Eliminar";
            this.btnEliminarEmpleado.Id = 2;
            this.btnEliminarEmpleado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEliminarEmpleado.ImageOptions.SvgImage")));
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminarEmpleado_ItemClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 3;
            this.btnActualizar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnActualizar.ImageOptions.SvgImage")));
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
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
            // gcEmpleados
            // 
            this.gcEmpleados.DataSource = this.empleadosBindingSource;
            this.gcEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEmpleados.Location = new System.Drawing.Point(0, 40);
            this.gcEmpleados.MainView = this.gvEmpleados;
            this.gcEmpleados.MenuManager = this.barManager1;
            this.gcEmpleados.Name = "gcEmpleados";
            this.gcEmpleados.Size = new System.Drawing.Size(991, 579);
            this.gcEmpleados.TabIndex = 4;
            this.gcEmpleados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmpleados});
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataSource = typeof(BOL.Empleado.Empleados);
            // 
            // gvEmpleados
            // 
            this.gvEmpleados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Empleado,
            this.colNombre_Empleado,
            this.colDireccion_Empleado,
            this.colTelefono_Empleado,
            this.colEmail_Empleado,
            this.colCargo_Empleado,
            this.colactivo,
            this.colpassword,
            this.colNombre_Usuario});
            this.gvEmpleados.GridControl = this.gcEmpleados;
            this.gvEmpleados.Name = "gvEmpleados";
            this.gvEmpleados.OptionsBehavior.Editable = false;
            this.gvEmpleados.OptionsMenu.EnableColumnMenu = false;
            // 
            // colID_Empleado
            // 
            this.colID_Empleado.FieldName = "ID_Empleado";
            this.colID_Empleado.MinWidth = 25;
            this.colID_Empleado.Name = "colID_Empleado";
            this.colID_Empleado.Width = 94;
            // 
            // colNombre_Empleado
            // 
            this.colNombre_Empleado.Caption = "Nombre";
            this.colNombre_Empleado.FieldName = "Nombre_Empleado";
            this.colNombre_Empleado.MinWidth = 25;
            this.colNombre_Empleado.Name = "colNombre_Empleado";
            this.colNombre_Empleado.Visible = true;
            this.colNombre_Empleado.VisibleIndex = 0;
            this.colNombre_Empleado.Width = 94;
            // 
            // colDireccion_Empleado
            // 
            this.colDireccion_Empleado.Caption = "Direccion";
            this.colDireccion_Empleado.FieldName = "Direccion_Empleado";
            this.colDireccion_Empleado.MinWidth = 25;
            this.colDireccion_Empleado.Name = "colDireccion_Empleado";
            this.colDireccion_Empleado.Visible = true;
            this.colDireccion_Empleado.VisibleIndex = 1;
            this.colDireccion_Empleado.Width = 94;
            // 
            // colTelefono_Empleado
            // 
            this.colTelefono_Empleado.Caption = "Telefono";
            this.colTelefono_Empleado.FieldName = "Telefono_Empleado";
            this.colTelefono_Empleado.MinWidth = 25;
            this.colTelefono_Empleado.Name = "colTelefono_Empleado";
            this.colTelefono_Empleado.Visible = true;
            this.colTelefono_Empleado.VisibleIndex = 2;
            this.colTelefono_Empleado.Width = 94;
            // 
            // colEmail_Empleado
            // 
            this.colEmail_Empleado.Caption = "Email";
            this.colEmail_Empleado.FieldName = "Email_Empleado";
            this.colEmail_Empleado.MinWidth = 25;
            this.colEmail_Empleado.Name = "colEmail_Empleado";
            this.colEmail_Empleado.Visible = true;
            this.colEmail_Empleado.VisibleIndex = 3;
            this.colEmail_Empleado.Width = 94;
            // 
            // colCargo_Empleado
            // 
            this.colCargo_Empleado.Caption = "Cargo";
            this.colCargo_Empleado.FieldName = "Cargo_Empleado";
            this.colCargo_Empleado.MinWidth = 25;
            this.colCargo_Empleado.Name = "colCargo_Empleado";
            this.colCargo_Empleado.Visible = true;
            this.colCargo_Empleado.VisibleIndex = 4;
            this.colCargo_Empleado.Width = 94;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 25;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 94;
            // 
            // colpassword
            // 
            this.colpassword.Caption = "Contraseña";
            this.colpassword.FieldName = "password";
            this.colpassword.MinWidth = 25;
            this.colpassword.Name = "colpassword";
            this.colpassword.Visible = true;
            this.colpassword.VisibleIndex = 5;
            this.colpassword.Width = 94;
            // 
            // colNombre_Usuario
            // 
            this.colNombre_Usuario.Caption = "Usuario";
            this.colNombre_Usuario.FieldName = "Nombre_Usuario";
            this.colNombre_Usuario.MinWidth = 25;
            this.colNombre_Usuario.Name = "colNombre_Usuario";
            this.colNombre_Usuario.Visible = true;
            this.colNombre_Usuario.VisibleIndex = 6;
            this.colNombre_Usuario.Width = 94;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 619);
            this.Controls.Add(this.gcEmpleados);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnNuevoEmpleado;
        private DevExpress.XtraBars.BarButtonItem btnModEmpleado;
        private DevExpress.XtraBars.BarButtonItem btnEliminarEmpleado;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcEmpleados;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmpleados;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion_Empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono_Empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail_Empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colCargo_Empleado;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraGrid.Columns.GridColumn colpassword;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Usuario;
    }
}