using BLL;
using BOL.Categoria;
using BOL.Cliente;
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
using ViewLayerDevExpress.EditForms;
using ViewLayerDevExpress.NewForms;

namespace ViewLayerDevExpress.Empresa
{
    public partial class frmClientes : DevExpress.XtraEditors.XtraForm
    {
        ClienteBLL clienteBLL = ClienteBLL.Instance();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            gvClientes.BestFitColumns();
            gcClientes.DataSource = clienteBLL.GetAll();
        }

        private void btnNCliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNCliente().ShowDialog();
            gcClientes.DataSource = clienteBLL.GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnACliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Actualizado", Application.ProductName, MessageBoxButtons.OK);
            gcClientes.DataSource = clienteBLL.GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnECliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea Eliminar el Cliente Seleccionado?",
                Application.ProductName, MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int IdCliente = (int)gvClientes.GetFocusedRowCellValue("ID_Cliente");
                clienteBLL.Delete(new Cliente()
                {
                    ID_Cliente = IdCliente
                });
                gcClientes.DataSource = clienteBLL.GetAll();
                gvClientes.BestFitColumns();
            }
        }

        private void btnUCliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int IdCliente = (int)gvClientes.GetFocusedRowCellValue("ID_Cliente");
            new frmUCliente(IdCliente).ShowDialog();
            gcClientes.DataSource = clienteBLL.GetAll();
            gvClientes.BestFitColumns();
        }
    }
}