namespace ViewLayerDevExpress.EditForms
{
    partial class frmUCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUCliente));
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
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(53, 191);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 20);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Email";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(53, 133);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 20);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Telefono";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(53, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 20);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Direccion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(241, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 29);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(67, 272);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 29);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(182, 181);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Size = new System.Drawing.Size(210, 30);
            this.txtEmail.TabIndex = 14;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(182, 128);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtTelefono.Properties.MaskSettings.Set("mask", "(000) 000-0000");
            this.txtTelefono.Properties.MaskSettings.Set("culture", "es-MX");
            this.txtTelefono.Size = new System.Drawing.Size(210, 30);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(182, 76);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdireccion.Size = new System.Drawing.Size(210, 30);
            this.txtdireccion.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(182, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Size = new System.Drawing.Size(210, 30);
            this.txtNombre.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(53, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 20);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Nombre";
            // 
            // frmUCliente
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 357);
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
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmUCliente.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmUCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Cliente";
            this.Load += new System.EventHandler(this.frmUCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
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
    }
}