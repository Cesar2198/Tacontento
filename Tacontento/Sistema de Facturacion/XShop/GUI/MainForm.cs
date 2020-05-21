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

        int lx, ly;
        int sw, sh;

        private void openWindowFromPanel(object form)
        {
            if (this.panelContainer.Controls.Count > 0)
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

        private void Customize()
        {
            ///aca esconderemos los submenus
            this.pnSubMenuLocal.Visible = false;
            this.panelOrdenes.Visible = false;
        }

        private void hideSubMenu()
        {
            ///para esconder los submenus
            if(this.pnSubMenuLocal.Visible == true)
            {
                this.pnSubMenuLocal.Visible = false;
            }

            if (this.panelOrdenes.Visible == true)
            {
                this.panelOrdenes.Visible = false;
            }
        }

        private void ShowSubMenu(Panel mypanel)
        {
            if(mypanel.Visible == false)
            {
                hideSubMenu();
                mypanel.Visible = true;
            }
            else
            {
                mypanel.Visible = false;
            }
        }

        public void pantallaCompleta()
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        public MainForm()

        {
            sesion = Sesion.Instance;
            this.user = new Usuarios();
            this.user = sesion.Datos.getUsuario();
            InitializeComponent();
            Customize();
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
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           ///pantallaCompleta();
        }

       

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            openWindowFromPanel(new UsuariosForm());
            hideSubMenu();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            int opcion = 1;
            if (CacheManager.CLS.Cache.VerificarPermiso(opcion))
            {
                openWindowFromPanel(new dashboardForm());
                hideSubMenu();
            }
          
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            int opcion = 2;
            if (CacheManager.CLS.Cache.VerificarPermiso(opcion)==false)
            {
               
            }
            else
            {
                ShowSubMenu(this.panelOrdenes);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {///para Salir
            if (MessageBox.Show("Desea Salir Realmente?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
            }
                
        }

        private void btnAgregarRoles_Click(object sender, EventArgs e)
        {
            openWindowFromPanel(new RolesForm());
            hideSubMenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openWindowFromPanel(new EmpleadosForm());
            hideSubMenu();
        }

        private void btnOrdenes_Click_1(object sender, EventArgs e)
        {
            openWindowFromPanel(new OrdenesForm());
            hideSubMenu();
        }

        private void btnLocal_Click_1(object sender, EventArgs e)
        {
            int opcion = 3;
            if (CacheManager.CLS.Cache.VerificarPermiso(opcion)==false)
            {
               
            }
            else
            {
                ShowSubMenu(this.pnSubMenuLocal);
            }
        }

        private void btnClasificaciones_Click(object sender, EventArgs e)
        {
            openWindowFromPanel(new ClasificacionForm());
            hideSubMenu();
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            openWindowFromPanel(new PermisosForm());
            hideSubMenu();
        }
    }
}
