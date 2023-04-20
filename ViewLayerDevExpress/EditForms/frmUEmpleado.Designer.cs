namespace ViewLayerDevExpress.EditForms
{
    partial class frmUEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUEmpleado));
            this.cboxCargo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.lbl = new DevExpress.XtraEditors.LabelControl();
            this.txtContraseña = new DevExpress.XtraEditors.TextEdit();
            this.text = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtdireccion = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCargo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxCargo
            // 
            this.cboxCargo.Location = new System.Drawing.Point(105, 221);
            this.cboxCargo.Name = "cboxCargo";
            this.cboxCargo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxCargo.Properties.Items.AddRange(new object[] {
            "CAJERO",
            "ALMACEN",
            "ADMINISTRADOR"});
            this.cboxCargo.Size = new System.Drawing.Size(197, 30);
            this.cboxCargo.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 227);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 20);
            this.labelControl5.TabIndex = 38;
            this.labelControl5.Text = "Cargo";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtUser);
            this.groupControl1.Controls.Add(this.lbl);
            this.groupControl1.Controls.Add(this.txtContraseña);
            this.groupControl1.Controls.Add(this.text);
            this.groupControl1.Location = new System.Drawing.Point(319, 27);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(347, 144);
            this.groupControl1.TabIndex = 37;
            this.groupControl1.Text = "Detalles de Inicio de Sesion";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(157, 45);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(185, 30);
            this.txtUser.TabIndex = 24;
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(11, 50);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(130, 20);
            this.lbl.TabIndex = 23;
            this.lbl.Text = "Nombre de Usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(157, 90);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContraseña.Size = new System.Drawing.Size(185, 30);
            this.txtContraseña.TabIndex = 7;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(11, 95);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(74, 20);
            this.text.TabIndex = 22;
            this.text.Text = "Contraseña";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 180);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 20);
            this.labelControl4.TabIndex = 36;
            this.labelControl4.Text = "Email";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 122);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 20);
            this.labelControl3.TabIndex = 35;
            this.labelControl3.Text = "Telefono";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 20);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "Direccion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(513, 218);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 29);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(359, 218);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 29);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Size = new System.Drawing.Size(197, 30);
            this.txtEmail.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(105, 122);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtTelefono.Properties.MaskSettings.Set("mask", "(000) 000-0000");
            this.txtTelefono.Properties.MaskSettings.Set("culture", "es-MX");
            this.txtTelefono.Size = new System.Drawing.Size(197, 30);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(105, 70);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdireccion.Size = new System.Drawing.Size(197, 30);
            this.txtdireccion.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Size = new System.Drawing.Size(197, 30);
            this.txtNombre.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 20);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Nombre";
            // 
            // frmUEmpleado
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 307);
            this.Controls.Add(this.cboxCargo);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmUEmpleado.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmUEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Empleado";
            this.Load += new System.EventHandler(this.frmUEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboxCargo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cboxCargo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lbl;
        private DevExpress.XtraEditors.TextEdit txtContraseña;
        private DevExpress.XtraEditors.LabelControl text;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtdireccion;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUser;
    }
}