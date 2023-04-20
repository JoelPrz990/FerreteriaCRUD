namespace ViewLayerDevExpress.EditForms
{
    partial class frmUCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUCategoria));
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(62, 135);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 29);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(194, 55);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Size = new System.Drawing.Size(189, 30);
            this.txtDescripcion.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(79, 65);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 20);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Descripcion";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(247, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmUCategoria
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 223);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnGuardar);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmUCategoria.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmUCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Categoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUCategoria_FormClosing);
            this.Load += new System.EventHandler(this.frmUCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}