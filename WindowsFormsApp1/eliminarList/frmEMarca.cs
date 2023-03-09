using BLL;
using BOL.Cliente;
using BOL.Marca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.eliminarList
{
    public partial class frmEMarca : Form
    {
        MarcaBLL marcaBLL = MarcaBLL.Instance();
        int idMarca;

        public frmEMarca()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            idMarca = marcaBLL.getByName(new Marca()
            {
                Nombre_Marca = cboxMarcas.Text
            }).ID_Marca;

            if (marcaBLL.Delete(new Marca()
            {
                ID_Marca = idMarca
            }))
            {
                MessageBox.Show("Marca Eliminada Correctamente", "FerroPapus",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campos limpiados", "FerroPapus",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboxMarcas.SelectedIndex = -1;
        }

        public void reload()
        {
            Marcas marcas = marcaBLL.GetAll();
            cboxMarcas.Items.Clear();
            foreach (Marca marca in marcas)
            {
                cboxMarcas.Items.Add(marca.Nombre_Marca);
            }
            cboxMarcas.SelectedIndex = -1;
            dgvMarcas.DataSource = marcaBLL.GetAll();
            dgvMarcas.Columns["Nombre_Marca"].HeaderText = "Nombre de la marca";
            dgvMarcas.Columns["ID_Marca"].Visible = false;
            dgvMarcas.Columns["activo"].Visible = false;
            dgvMarcas.Columns["ID_Proveedor"].Visible = false;
        }

        private void frmEMarca_Enter(object sender, EventArgs e)
        {
            reload();
        }
    }
}
