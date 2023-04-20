namespace ViewLayerDevExpress.EditForms
{
    partial class frmUMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUMarca));
            this.rlookProveedor = new DevExpress.XtraEditors.LookUpEdit();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rlookProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rlookProveedor
            // 
            this.rlookProveedor.Location = new System.Drawing.Point(251, 29);
            this.rlookProveedor.Name = "rlookProveedor";
            this.rlookProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlookProveedor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_Proveedor", "ID_Proveedor", 104, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre_Proveedor", "Nombre_Proveedor", 144, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Direccion_Proveedor", "Direccion_Proveedor", 152, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Telefono_Proveedor", "Telefono_Proveedor", 148, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email_Proveedor", "Email_Proveedor", 126, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 55, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlookProveedor.Properties.DataSource = this.proveedoresBindingSource;
            this.rlookProveedor.Properties.DisplayMember = "Nombre_Proveedor";
            this.rlookProveedor.Properties.ValueMember = "ID_Proveedor";
            this.rlookProveedor.Size = new System.Drawing.Size(182, 30);
            this.rlookProveedor.TabIndex = 0;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataSource = typeof(BOL.Proveedor.Proveedores);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(55, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 20);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Proveedor";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(55, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(137, 20);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nombre de la Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(251, 85);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Size = new System.Drawing.Size(182, 30);
            this.txtMarca.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(65, 174);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 29);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(251, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(BOL.Proveedor.Proveedor);
            // 
            // frmUMarca
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 258);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.rlookProveedor);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmUMarca.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmUMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Marca";
            this.Load += new System.EventHandler(this.frmUMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rlookProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit rlookProveedor;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMarca;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
    }
}