using BLL;
using BOL.Categoria;
using BOL.Marca;
using BOL.Proveedor;
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

namespace ViewLayerDevExpress.EditForms
{
    public partial class frmUMarca : DevExpress.XtraEditors.XtraForm
    {
        private int IdMarca;
        private int idproveedor;
        ProveedorBLL proveedorBLL = ProveedorBLL.Instance();
        MarcaBLL marcaBLL = MarcaBLL.Instance();

        public frmUMarca(int IdMarca)
        {
            this.IdMarca = IdMarca;
            InitializeComponent();
        }
        public frmUMarca()
        {
            InitializeComponent();
        }

        private void frmUMarca_Load(object sender, EventArgs e)
        {
            proveedoresBindingSource.DataSource = proveedorBLL.GetAll();
            Marca marca = marcaBLL.GetById(new Marca()
            {
                ID_Marca = this.IdMarca
            });
            rlookProveedor.EditValue = marca.ID_Proveedor;
            txtMarca.Text = marca.Nombre_Marca;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            idproveedor = Convert.ToInt32(rlookProveedor.EditValue);

            if (String.IsNullOrEmpty(txtMarca.Text))
            {
                XtraMessageBox.Show("Llene los campos", Application.ProductName);
            }
            else
            {
                if (marcaBLL.Update(new Marca()
                {
                    ID_Marca = this.IdMarca,
                    ID_Proveedor = idproveedor,
                    Nombre_Marca = txtMarca.Text
                }))
                {
                    XtraMessageBox.Show("Marca Modificada Correctamente",
                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Dispose();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea Cancelar?", Application.ProductName,
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}