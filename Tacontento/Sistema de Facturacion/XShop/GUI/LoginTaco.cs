using System;
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
using Microsoft.VisualBasic.ApplicationServices;

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
            if (MessageBox.Show("Desea Salir Realmente?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
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
            if (e.KeyCode == Keys.Enter)
            {
               
                try
                {
                    Sesion sesion = Sesion.Instance;
                    UsuarioDAO userDao = new UsuarioDAO();
                    Usuarios userActual = new Usuarios();
                    userActual = userDao.ObtenerUsuarioByUserNameAndPassword(this.txbUsuario.Text, this.txbContraseña.Text);
                    if (userDao.ObtenerUsuarioByUserNameAndPassword(this.txbUsuario.Text, this.txbContraseña.Text) != null)
                    {

                        sesion.Datos.setUsuario(userActual);
                        _AUTORIZAR = true;
                        ///Obtenemos todos los permisos luego de setear al usuario
                        ///Obteniendo asi el id del rol
                        CacheManager.CLS.Cache.ObtenerPermisos();
                        this.lblMensaje.Text = "Bienvenido " + userActual.usuario + "!";
                        Close();
                    }
                    else
                    {
                        this.lblMensaje.Text = "Credenciales Incorrectas, Intente de Nuevo...";
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocurrió un Error: " + ex.Message,"Informacion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }


        private void LoginTaco_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Sesion sesion = Sesion.Instance;
                UsuarioDAO userDao = new UsuarioDAO();
                Usuarios userActual = new Usuarios();
                userActual = userDao.ObtenerUsuarioByUserNameAndPassword(this.txbUsuario.Text, this.txbContraseña.Text);
                if (userDao.ObtenerUsuarioByUserNameAndPassword(this.txbUsuario.Text, this.txbContraseña.Text) != null)
                {

                    sesion.Datos.setUsuario(userActual);
                    _AUTORIZAR = true;
                    ///Obtenemos todos los permisos luego de setear al usuario
                    ///Obteniendo asi el id del rol
                    CacheManager.CLS.Cache.ObtenerPermisos();
                    this.lblMensaje.Text = "Bienvenido " + userActual.usuario + "!";
                    Close();
                }
                else
                {
                    this.lblMensaje.Text = "Credenciales Incorrectas, Intente de Nuevo...";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un Error: " + ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
