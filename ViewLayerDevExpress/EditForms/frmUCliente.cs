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
    public partial class frmUCliente : DevExpress.XtraEditors.XtraForm
    {
        private int IdCliente;
        public frmUCliente()
        {
            InitializeComponent();
        }
        public frmUCliente(int idCliente)
        {
            InitializeComponent();
            this.IdCliente = idCliente;
        }
    }
}