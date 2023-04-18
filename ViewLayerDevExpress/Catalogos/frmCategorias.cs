using BLL;
using BOL.Categoria;
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
using ViewLayerDevExpress.EditForms;
using ViewLayerDevExpress.NewForms;

namespace ViewLayerDevExpress.Catalogos
{
    public partial class frmCategorias : DevExpress.XtraEditors.XtraForm
    {
        CategoriaBLL categoriaBLL = CategoriaBLL.Instance();
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            categoriasBindingSource.DataSource = categoriaBLL.GetAll();
        }

        private void btnEliminarCat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea Eliminar el Objeto Seleccionado?",
                Application.ProductName, MessageBoxButtons.YesNo)== DialogResult.Yes) {

                int IdCategoria = (int)gvCategorias.GetFocusedRowCellValue("ID_Categoria");

                categoriaBLL.Delete(new Categoria()
                {
                    ID_Categoria = IdCategoria
                });

                categoriasBindingSource.DataSource = categoriaBLL.GetAll();
                gvCategorias.BestFitColumns();
            }
        }

        private void btnActualizCat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Actualizado", Application.ProductName, MessageBoxButtons.OK);
            categoriasBindingSource.DataSource = categoriaBLL.GetAll();
            gcCategorias.DataSource = categoriaBLL.GetAll();
        }

        private void btnEditCat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int IdCategoria = (int)gvCategorias.GetFocusedRowCellValue("ID_Categoria");
            new frmUCategoria(IdCategoria).ShowDialog();
            gcCategorias.DataSource = categoriaBLL.GetAll();
            gvCategorias.BestFitColumns();
        }

        private void btnNuevoCat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNCategoria().ShowDialog();
            gcCategorias.DataSource = categoriaBLL.GetAll();
            gvCategorias.BestFitColumns();
        }
    }
}