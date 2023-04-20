namespace ViewLayerDevExpress.NewForms
{
    partial class frmNEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNEmpleado));
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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txtContraseña = new DevExpress.XtraEditors.TextEdit();
            this.text = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboxCargo = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCargo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(46, 193);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 20);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Email";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(46, 135);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 20);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Telefono";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 20);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Direccion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(536, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 29);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(382, 231);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 29);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar Nuevo";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(128, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Size = new System.Drawing.Size(197, 30);
            this.txtEmail.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(128, 135);
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
            this.txtdireccion.Location = new System.Drawing.Point(128, 83);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdireccion.Size = new System.Drawing.Size(197, 30);
            this.txtdireccion.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Size = new System.Drawing.Size(197, 30);
            this.txtNombre.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(46, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 20);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Nombre";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(157, 40);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textEdit1.Size = new System.Drawing.Size(185, 30);
            this.textEdit1.TabIndex = 6;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(157, 85);
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
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(11, 50);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(130, 20);
            this.txtUsuario.TabIndex = 23;
            this.txtUsuario.Text = "Nombre de Usuario";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.txtUsuario);
            this.groupControl1.Controls.Add(this.txtContraseña);
            this.groupControl1.Controls.Add(this.text);
            this.groupControl1.Location = new System.Drawing.Point(342, 40);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(347, 144);
            this.groupControl1.TabIndex = 24;
            this.groupControl1.Text = "Detalles de Inicio de Sesion";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(46, 240);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 20);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Cargo";
            // 
            // cboxCargo
            // 
            this.cboxCargo.Location = new System.Drawing.Point(128, 234);
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
            // frmNEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 314);
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
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmNEmpleado.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmNEmpleado";
            this.Text = "Nuevo Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCargo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit txtContraseña;
        private DevExpress.XtraEditors.LabelControl text;
        private DevExpress.XtraEditors.LabelControl txtUsuario;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cboxCargo;
    }
}