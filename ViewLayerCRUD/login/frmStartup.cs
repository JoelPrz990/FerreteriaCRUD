using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewLayer
{
    public partial class frmStartup : Form
    {
        public frmStartup()
        {
            InitializeComponent();
        }

        private void frmStartup_Load(object sender, EventArgs e)
        {
            label1.Text = "¡Bienvenido "+Program.UsuarioActual+"!";
        }
    }
}
