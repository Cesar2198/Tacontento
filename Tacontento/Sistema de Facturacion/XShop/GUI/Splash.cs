using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XShop.GUI
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            ///Evento desencadenante que cerrara la ventana actual cuando se cumpla los 5 segundos
       
            this.Cronometro.Stop();
            Close();

         
            
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            //empezamos con el conteo
            this.Cronometro.Start();
        }
    }
}
