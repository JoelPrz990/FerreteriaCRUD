using BLL;
using BOL.Producto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewLayer.consultaList
{
    public partial class frmMarcas : Form
    {
        MarcaBLL marcaBLL = MarcaBLL.Instance();
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            dgvMarcas.DataSource = marcaBLL.GetAll();
            dgvMarcas.Columns["Nombre_Marca"].HeaderText= "Nombre de la marca";


            dgvMarcas.Columns["ID_Marca"].Visible = false;
            dgvMarcas.Columns["activo"].Visible = false;
            dgvMarcas.Columns["ID_Proveedor"].Visible = false;
        }
    }
}
