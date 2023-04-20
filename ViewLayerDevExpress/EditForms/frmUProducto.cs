using BLL;
using BOL.Categoria;
using BOL.Marca;
using BOL.Producto;
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
    public partial class frmUProducto : DevExpress.XtraEditors.XtraForm
    {
        private int IdProducto;

        MarcaBLL marcaBLL = MarcaBLL.Instance();
        ProductoBLL productoBLL = ProductoBLL.Instance();
        CategoriaBLL categoriaBLL = CategoriaBLL.Instance();
        public frmUProducto()
        {
            InitializeComponent();
        }

        public frmUProducto(int IdProducto)
        {
            this.IdProducto = IdProducto;
            InitializeComponent();
        }

        private void frmUProducto_Load(object sender, EventArgs e)
        {
            marcasBindingSource.DataSource = marcaBLL.GetAll();
            marcasBindingSource.DataSource = marcaBLL.GetAll();
            categoriasBindingSource.DataSource = categoriaBLL.GetAll();

            Producto producto = productoBLL.GetById(new Producto()
            {
                ID_Producto = this.IdProducto
            });
            String precio = Convert.ToString(producto.Precio_Producto);
            String stock = Convert.ToString(producto.Stock_Disponible);

            rlookCategoria.EditValue = producto.ID_Categoria;
            rlookMarcas.EditValue = producto.ID_Marca;
            txtDescripcion.Text = producto.Descripcion_Producto;
            txtNombre.Text = producto.Nombre_Producto;
            txtPrecio.Text = precio;
            txtStock.Text = stock;
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
                    Nombre_Marca = rlookMarcas.Text
                }).ID_Marca;

                if (productoBLL.Update(new BOL.Producto.Producto() {
                    ID_Producto = this.IdProducto,
                    Nombre_Producto = txtNombre.Text,
                    Descripcion_Producto = txtDescripcion.Text,
                    Marca_Producto = rlookMarcas.Text,
                    Precio_Producto = precio,
                    ID_Categoria = idCategoria,
                    Stock_Disponible = stockD,
                    ID_Marca = idMarca
                })) 
                {
                    XtraMessageBox.Show("Producto Actualizado Correctamente", 
                        Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);   
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea Cancelar?",Application.ProductName, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)==DialogResult.Yes) {
                this.Close();
            }
        }
    }
}