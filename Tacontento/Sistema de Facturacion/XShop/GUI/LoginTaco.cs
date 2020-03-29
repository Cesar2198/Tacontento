﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using SessionManager.CLS;
using Entidades.Entidades.Usuarios;


namespace XShop.GUI
{
   
    public partial class LoginTaco : Form

    {
        Boolean _AUTORIZAR = false;

        public LoginTaco()
        {
            InitializeComponent();

            //Modificamos las medidas de los TextBox
            txbUsuario.MinimumSize = new Size(240, 35);
            //txbUsuario.MaximumSize = new Size(300, 100);
            txbContraseña.MinimumSize = new Size(240, 35);
        }


        public Boolean AUTORIZAR
        {
            get { return _AUTORIZAR; }
        }

        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            //Activamso el Evento KeyDown para realizar el cambio de color al TextBox
            txbUsuario.ForeColor = Color.FromArgb(209, 142, 61);
        }

        private void txbContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            //Activamso el Evento KeyDown para realizar el cambio de color al TextBox
            txbContraseña.ForeColor = Color.FromArgb(209, 142, 61);
        }


        private void LoginTaco_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Sesion sesion = Sesion.Instance;
            UsuarioDAO userDao = new UsuarioDAO();
            if (userDao.ObtenerUsuarioByUserNameAndPassword(this.txbUsuario.Text, this.txbContraseña.Text) != null)
            {
                Usuarios userActual = new Usuarios();
                userActual = userDao.ObtenerUsuarioByUserNameAndPassword(this.txbUsuario.Text, this.txbContraseña.Text);
                if (userActual.usuario == txbUsuario.Text && userActual.password == txbContraseña.Text)
                {
                    
                    sesion.Datos.setUsuario(userActual);
                    _AUTORIZAR = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas");
                }
            }
            else
            {
                MessageBox.Show("El usuario no se encuentra registrado");
            }
            
        }

    }
}
