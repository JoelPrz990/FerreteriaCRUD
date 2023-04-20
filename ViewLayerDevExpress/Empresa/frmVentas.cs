using BLL;
using BOL.Venta;
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
using ViewLayerDevExpress.Login;
using ViewLayerDevExpress.NewForms;

namespace ViewLayerDevExpress.Empresa
{
    public partial class frmVentas : DevExpress.XtraEditors.XtraForm
    {
        VentaBLL ventaBLL = VentaBLL.Instance();
        EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance();
        ClienteBLL clienteBLL = ClienteBLL.Instance();
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            btnRegresar.Enabled = false;
            empleadosBindingSource.DataSource = empleadoBLL.GetAll();
            clientesBindingSource.DataSource = clienteBLL.GetAll();
            gcVentas.DataSource = ventaBLL.GetAll();
            gvVentas.BestFitColumns();
        }

        private void btnArchivado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Se Va a Actualizar la Lista \n ¿Está Bien?",Application.ProductName,
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) {
                btnRegresar.Enabled = true;
                btnArchivado.Enabled = false;
                btnArchivar.Enabled = false;
                empleadosBindingSource.DataSource = empleadoBLL.GetAll();
                clientesBindingSource.DataSource = clienteBLL.GetAll();
                gcVentas.DataSource = ventaBLL.GetArchivo();
                gvVentas.BestFitColumns();
            }
        }

        private void btnRegresar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Se Mostrarán Ventas Activas \n ¿Está Bien?", Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnRegresar.Enabled = false;
                btnArchivado.Enabled = true;
                btnArchivar.Enabled = true;
                empleadosBindingSource.DataSource = empleadoBLL.GetAll();
                clientesBindingSource.DataSource = clienteBLL.GetAll();
                gcVentas.DataSource = ventaBLL.GetAll();
                gvVentas.BestFitColumns();
            }
        }

        private void btnArchivar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int numeroElementos;

            Ventas obj = ventaBLL.GetAll();
            numeroElementos = obj.Count();

            if (numeroElementos == 0) {
                XtraMessageBox.Show("No Hay Elementos Para Archivar", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else {
                if (XtraMessageBox.Show("¿Desea Archivar la Venta Seleccionada?", Application.ProductName,
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int IdVenta = (int)gvVentas.GetFocusedRowCellValue("ID_Venta");
                    if (ventaBLL.Delete(new BOL.Venta.Venta() {
                        ID_Venta = IdVenta
                    })) {
                        XtraMessageBox.Show("Se Ha Archivado Una Venta", Application.ProductName, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        empleadosBindingSource.DataSource = empleadoBLL.GetAll();
                        clientesBindingSource.DataSource = clienteBLL.GetAll();
                        gcVentas.DataSource = ventaBLL.GetAll();
                        gvVentas.BestFitColumns();
                    }
                } 
            }
        }

        private void btnNuevaVenta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNVenta().ShowDialog();
            empleadosBindingSource.DataSource = empleadoBLL.GetAll();
            clientesBindingSource.DataSource = clienteBLL.GetAll();
            gcVentas.DataSource = ventaBLL.GetAll();
            gvVentas.BestFitColumns();
        }
    }
}