using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SessionManager.CLS;
using Entidades.Entidades.Usuarios;


namespace XShop.GUI
{
    public partial class MainForm : Form
    {
        private Sesion sesion;
        private Usuarios user;
        public MainForm()

        {
            sesion = Sesion.Instance;
            this.user = new Usuarios();
            this.user = sesion.Datos.getUsuario();
            InitializeComponent();
            this.usernameLabel.Text = this.user.usuario;
            this.userRolLabel.Text = CLS.Utility.getRol(this.user.rol);
            
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            ///Cargar el formulario Agregar Order
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            openWindowFromPanel(new OrdenesForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void openWindowFromPanel(object form)
        {
            if (this.panelContainer.Controls.Count>0)
            {
                this.panelContainer.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(f);
            this.panelContainer.Tag = f;
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            openWindowFromPanel(new UsuarioForm());
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
