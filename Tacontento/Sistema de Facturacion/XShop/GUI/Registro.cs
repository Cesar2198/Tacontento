using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using Entidades.Entidades.Usuarios;
=======
using XShop.CLS.Entidades.Usuarios;
>>>>>>> a5e4f0f1235316c2ff7a3ed4065316609a92c52c


namespace XShop.GUI
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           UsuarioDAO userDao = new UsuarioDAO();
           Usuarios usuario = new Usuarios();
            usuario.usuario = this.txbUser.Text;

            if (userDao.CrearUsuario(usuario)!=null)
            {
                MessageBox.Show("Se ha insertado un usuario");
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }


        }
    }
}
