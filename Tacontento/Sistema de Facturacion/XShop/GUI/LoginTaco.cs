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

namespace XShop.GUI
{
   
    public partial class LoginTaco : Form
    {     

        public LoginTaco()
        {
            InitializeComponent();

            //Modificamos las medidas de los TextBox
            txbUsuario.MinimumSize = new Size(240, 35);
            //txbUsuario.MaximumSize = new Size(300, 100);
            txbContraseña.MinimumSize = new Size(240, 35);
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
    }
}
