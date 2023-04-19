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

namespace ViewLayerDevExpress.Catalogos
{
    public partial class frmMarcas : DevExpress.XtraEditors.XtraForm
    {
        MarcaBLL marcaBLL = MarcaBLL.Instance();
        ProveedorBLL proveedorBLL = ProveedorBLL.Instance();

        public frmMarcas()
        {
            InitializeComponent();
            gvMarcas.Columns[0].Visible = false;
            gvMarcas.Columns[1].Caption = "Proveedor";
            gvMarcas.Columns[2].Caption = "Marca del Producto";
            gvMarcas.Columns[3].Visible = false;
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            marcasBindingSource.DataSource = marcaBLL.GetAll();
            proveedoresBindingSource.DataSource = proveedorBLL.GetAll();
            gvMarcas.BestFitColumns();
        }

        private void btnActualizarMarca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}