using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewLayer.agregarList
{
    public partial class cantidadDialog : Form
    {
        public cantidadDialog(int stock)
        {
            InitializeComponent();
            updCantidad.Maximum = stock;
        }
        public int Cantidad
        {
            get { return (int)updCantidad.Value; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cantidadDialog_Load(object sender, EventArgs e)
        {
            updCantidad.Select(0,1);
        }
    }
}
