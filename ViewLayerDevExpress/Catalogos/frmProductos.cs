using BLL;
using BOL.Categoria;
using BOL.Marca;
using BOL.Producto;
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
using ViewLayerDevExpress.NewForms;

namespace ViewLayerDevExpress.Catalogos
{
    public partial class frmProductos : DevExpress.XtraEditors.XtraForm
    {
        ProductoBLL productoBLL = ProductoBLL.Instance();
        MarcaBLL marcaBLL = MarcaBLL.Instance();
        CategoriaBLL categoriaBLL= CategoriaBLL.Instance();

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            categoriasBindingSource.DataSource = categoriaBLL.GetAll();
            gcProductos.DataSource = productoBLL.GetAll();
            productosBindingSource.DataSource = productoBLL.GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnUProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmUP
        }

        private void btnNProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNProducto().ShowDialog();
            gcProductos.DataSource= productoBLL.GetAll();
            productosBindingSource.DataSource = productoBLL.GetAll();
        }

        private void btnEliminarProd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea Eliminar el Producto Seleccionado?",
                Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int IdProducto = (int)gvProductos.GetFocusedRowCellValue("ID_Producto");

                productoBLL.Delete(new Producto()
                {
                    ID_Producto = IdProducto
                });

                gcProductos.DataSource = productoBLL.GetAll();
                categoriasBindingSource.DataSource = categoriaBLL.GetAll();
                gvProductos.BestFitColumns();
            }
        }

        private void btnActualizarProd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Actualizado", Application.ProductName, MessageBoxButtons.OK);
            categoriasBindingSource.DataSource = categoriaBLL.GetAll();
            gcProductos.DataSource = productoBLL.GetAll();
        }
    }
}