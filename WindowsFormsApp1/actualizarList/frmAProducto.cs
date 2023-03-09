using BLL;
using BOL.Categoria;
using BOL.Cliente;
using BOL.Marca;
using BOL.Producto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.actualizarList
{
    public partial class frmAProducto : Form
    {
        ProductoBLL productoBLL = ProductoBLL.Instance();
        MarcaBLL marcaBLL = MarcaBLL.Instance();
        CategoriaBLL categoriaBLL = CategoriaBLL.Instance();
        int idProducto;
        int idMarca;
        int idCategoria;
        decimal precio;
        int stock;

        public frmAProducto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDesc.Text) || String.IsNullOrEmpty(txtNombre.Text)
                || String.IsNullOrEmpty(txtPrecio.Text) || String.IsNullOrEmpty(txtStock.Text)
                || String.IsNullOrEmpty(cboxCategoria.Text) || String.IsNullOrEmpty(cboxMarca.Text)
                || String.IsNullOrEmpty(cboxProducto.Text))
            {
                MessageBox.Show("Llene los campos", "Ferropapus");
            }
            else
            {
                if (!cboxProducto.Text.Equals(""))
                {
                    idProducto = productoBLL.getByName(new Producto()
                    {
                        Nombre_Producto = cboxProducto.Text
                    }).ID_Producto;
                }

                if (!cboxMarca.Text.Equals(""))
                {
                    idMarca = marcaBLL.getByName(new Marca()
                    {
                        Nombre_Marca = cboxMarca.Text
                    }).ID_Marca;
                }
                if (!cboxCategoria.Text.Equals(""))
                {
                    idCategoria = categoriaBLL.getByDescripcion(new Categoria()
                    {
                        Nombre_Categoria = cboxCategoria.Text
                    }).ID_Categoria;
                }
                string unitario = txtPrecio.Text;
                decimal.TryParse(unitario, out precio);

                string stockD = txtStock.Text;
                int.TryParse(stockD, out stock);

                if (productoBLL.Update(new Producto()
                {
                    ID_Producto = idProducto,
                    Nombre_Producto = txtNombre.Text,
                    Descripcion_Producto = txtDesc.Text,
                    Marca_Producto = cboxMarca.Text,
                    Precio_Producto = precio,
                    ID_Categoria = idCategoria,
                    Stock_Disponible = stock,
                    ID_Marca = idMarca
                }))
                {
                    MessageBox.Show("Producto Actualizado Correctamente", "FerroPapus",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campos limpiados", "FerroPapus",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            reload();
        }

        private void frmAProducto_Enter(object sender, EventArgs e)
        {
            reload();
        }
        public void reload() {
            Marcas marcas = marcaBLL.GetAll();
            cboxMarca.Items.Clear();
            foreach (Marca marca in marcas)
            {
                cboxMarca.Items.Add(marca.Nombre_Marca);
            }

            Categorias categorias = categoriaBLL.GetAll();
            cboxCategoria.Items.Clear();
            foreach (Categoria categoria in categorias)
            {
                cboxCategoria.Items.Add(categoria.Nombre_Categoria);
            }

            Productos productos = productoBLL.GetAll();
            cboxProducto.Items.Clear();
            foreach (Producto producto in productos)
            {
                cboxProducto.Items.Add(producto.Nombre_Producto);
            }

            cboxProducto.SelectedIndex = -1;
            cboxMarca.SelectedIndex = -1;
            cboxCategoria.SelectedIndex = -1;
            dgvProducto.DataSource = productoBLL.GetAll();
            dgvProducto.Columns["ID_Producto"].Visible = false;
            dgvProducto.Columns["ID_Marca"].Visible = false;
            dgvProducto.Columns["ID_Categoria"].Visible = false;
            dgvProducto.Columns["activo"].Visible = false;
        }
    }
}
