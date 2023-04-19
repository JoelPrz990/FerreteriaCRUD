using BLL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewLayerDevExpress.NewForms
{
    public partial class frmNMarca : DevExpress.XtraEditors.XtraForm
    {
        MarcaBLL marcaBLL = MarcaBLL.Instance();
        ProveedorBLL proveedorBLL = ProveedorBLL.Instance();

        public frmNMarca()
        {
            InitializeComponent();
        }
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea Cancelar?", Application.ProductName, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes) {
                this.Dispose();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idProveedor = Convert.ToInt32(rlookProveedor.EditValue);
            if (String.IsNullOrEmpty(txtMarca.Text))
            {
                XtraMessageBox.Show("Llene los campos", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                marcaBLL.Add(new BOL.Marca.Marca()
                {
                    ID_Proveedor = idProveedor,
                    Nombre_Marca = txtMarca.Text
                });
                XtraMessageBox.Show("Marca añadida correctamente", Application.ProductName,
                    MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                this.Dispose();
            }

        }

        private void frmNMarca_Load(object sender, EventArgs e)
        {
            proveedoresBindingSource.DataSource = proveedorBLL.GetAll();
            rlookProveedor.EditValue = -1;
        }
    }
}