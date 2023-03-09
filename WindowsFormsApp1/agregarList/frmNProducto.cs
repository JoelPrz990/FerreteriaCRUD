using BLL;
using BOL.Categoria;
using BOL.Marca;
using BOL.Producto;
using BOL.Proveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.agregarList
{
    public partial class frmNProducto : Form
    {
        ProductoBLL productoBLL = ProductoBLL.Instance();
        CategoriaBLL categoriaBLL = CategoriaBLL.Instance();
        MarcaBLL MarcaBLL  = MarcaBLL.Instance();
        int idMarca;
        int idCategoria;
        decimal precio;
        int stock;

        public frmNProducto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDesc.Text) || String.IsNullOrEmpty(txtNombre.Text)
                || String.IsNullOrEmpty(txtPrecio.Text) || String.IsNullOrEmpty(txtStock.Text)
                || String.IsNullOrEmpty(cboxCategoria.Text) || String.IsNullOrEmpty(cboxMarca.Text))
            {
                MessageBox.Show("Llene los campos", "Ferropapus");
            }
            else {

                if (!cboxMarca.Text.Equals(""))
                {
                    idMarca = MarcaBLL.getByName(new Marca()
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

                if (productoBLL.Add(new Producto()
                {
                    Nombre_Producto = txtNombre.Text,
                    Descripcion_Producto = txtDesc.Text,
                    Marca_Producto = cboxMarca.Text,
                    Precio_Producto = precio,
                    ID_Categoria = idCategoria,
                    Stock_Disponible = stock,
                    ID_Marca = idMarca
                }))
                {
                    MessageBox.Show("Producto Ingresado Correctamente", "FerroPapus",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProducto.DataSource = productoBLL.GetAll();
                    dgvProducto.Columns["ID_Producto"].Visible = false;
                    dgvProducto.Columns["ID_Marca"].Visible = false;
                    dgvProducto.Columns["ID_Categoria"].Visible = false;
                    dgvProducto.Columns["activo"].Visible = false;
                }

            }
        }

        private void frmNProducto_Enter(object sender, EventArgs e)
        {
            Categorias categorias = categoriaBLL.GetAll();
            foreach (Categoria categoria in categorias)
            {
                cboxCategoria.Items.Add(categoria.Nombre_Categoria);
            }
            Marcas marcas = MarcaBLL.GetAll();
            foreach (Marca marca in marcas)
            {
                cboxMarca.Items.Add(marca.Nombre_Marca);
            }
            dgvProducto.DataSource = productoBLL.GetAll();
            dgvProducto.Columns["ID_Producto"].Visible = false;
            dgvProducto.Columns["ID_Marca"].Visible = false;
            dgvProducto.Columns["ID_Categoria"].Visible = false;
            dgvProducto.Columns["activo"].Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            
            MessageBox.Show("Campos limpiados", "FerroPapus",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombre.Clear();
            cboxMarca.SelectedIndex = -1;
            cboxCategoria.SelectedIndex= -1;
            txtDesc.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }
    }
}
