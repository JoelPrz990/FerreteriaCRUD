using BLL;
using BOL.Marca;
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
    public partial class frmNProducto : DevExpress.XtraEditors.XtraForm
    {
        ProductoBLL productoBLL = ProductoBLL.Instance();
        MarcaBLL marcaBLL = MarcaBLL.Instance();
        CategoriaBLL categoriaBLL = CategoriaBLL.Instance();
        public frmNProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDescripcion.Text) || String.IsNullOrEmpty(txtNombre.Text)
                || String.IsNullOrEmpty(txtPrecio.Text) || String.IsNullOrEmpty(txtStock.Text))
            {
                XtraMessageBox.Show("Llene los campos", Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else {
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                int idCategoria = Convert.ToInt32(rlookCategoria.EditValue);
                int stockD = Convert.ToInt32(txtStock.Text);

                int idMarca = marcaBLL.getByName(new Marca()
                {
                    Nombre_Marca = rlookMarca.Text
                }).ID_Marca;

                if (productoBLL.Add(new BOL.Producto.Producto()
                {
                    Nombre_Producto = txtNombre.Text,
                    Descripcion_Producto = txtDescripcion.Text,
                    Marca_Producto = rlookMarca.Text,
                    Precio_Producto = precio,
                    ID_Categoria = idCategoria,
                    Stock_Disponible = stockD,
                    ID_Marca = idMarca
                })) {
                    XtraMessageBox.Show("Producto añadido correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea Cancelar?", Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                this.Close();    
            }
        }

        private void frmNProducto_Load(object sender, EventArgs e)
        {
            marcasBindingSource.DataSource = marcaBLL.GetAll();
            categoriasBindingSource.DataSource = categoriaBLL.GetAll();
            rlookMarca.EditValue = -1;
            rlookCategoria.EditValue = -1;
        }
    }
}