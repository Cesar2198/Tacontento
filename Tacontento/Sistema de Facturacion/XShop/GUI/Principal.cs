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
    public partial class Principal : Form
    {


        public Principal()
        {
            InitializeComponent();
        }

        private void pruebaDeConectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///para mandar a crear un nuevo formulario
            PruebaConector p = new PruebaConector();

            p.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.ShowDialog();
            
        }
    }

}
