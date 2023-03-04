﻿using BLL;
using BOL.Empleado;
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
    public partial class LoginForm : Form
    {
        private EmpleadoBLL empleadoBLL = EmpleadoBLL.Instance();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }
        public void IniciarSesion()
        {
            try
            {
                if (empleadoBLL.Login(new Empleado()
                {
                    Nombre_Usuario = txtUsr.Text,
                    password = txtPass.Text
                }))
                {
                    MessageBox.Show("Accedido correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    SplashForm sf = new SplashForm();
                    sf.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPass.Clear();
                    txtPass.Focus();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}