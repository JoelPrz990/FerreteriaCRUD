﻿using DevExpress.XtraEditors;
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
    public partial class frmUEmpleado : DevExpress.XtraEditors.XtraForm
    {
        private int IdEmpleado;
        public frmUEmpleado()
        {
            InitializeComponent();
        }
        public frmUEmpleado(int idEmpleado)
        {
            InitializeComponent();
            this.IdEmpleado = idEmpleado;
        }

    }
}