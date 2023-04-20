using BLL;
using BOL.Empleado;
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
using ViewLayerDevExpress.EditForms;
using ViewLayerDevExpress.NewForms;

namespace ViewLayerDevExpress.Empresa
{
    public partial class frmProveedores : DevExpress.XtraEditors.XtraForm
    {
        ProveedorBLL proveedorBLL = ProveedorBLL.Instance();
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void btnEliminarProv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea Eliminar el Proveedor Seleccionado?",
                Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int IdProveedor = (int)gvProveedores.GetFocusedRowCellValue("ID_Proveedor");
                proveedorBLL.Delete(new Proveedor()
                {
                    ID_Proveedor = IdProveedor
                });
                gcProveedores.DataSource = proveedorBLL.GetAll();
                gvProveedores.BestFitColumns();
            }
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Actualizado", Application.ProductName, MessageBoxButtons.OK);
            gcProveedores.DataSource = proveedorBLL.GetAll();
            gvProveedores.BestFitColumns();
        }

        private void btnEditarProv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int IdProveedor = (int)gvProveedores.GetFocusedRowCellValue("ID_Proveedor");
            new frmUProveedor(IdProveedor).ShowDialog();
            gcProveedores.DataSource = proveedorBLL.GetAll();
            gvProveedores.BestFitColumns();
        }

        private void btnNuevoProv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNProveedor().ShowDialog();
            gcProveedores.DataSource = proveedorBLL.GetAll();
            gvProveedores.BestFitColumns();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            gcProveedores.DataSource = proveedorBLL.GetAll();
            gvProveedores.BestFitColumns();
        }
    }
}