using Entidades.Entidades.Usuarios;
using SessionManager.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XShop.CLS;

namespace XShop.GUI
{
    public partial class LockScreen : Form
    {
        private Sesion sesion;
        private Usuarios user;
        private int intentos = 10;

        public Boolean bandera = false;



        public Boolean Validar()
        {
            

            if (CLS.Utility.Encryptar(this.txbPassword.Text) == this.user.password)
            {
                bandera = true;
            }
            else
            {
                bandera = false;
            }
            return bandera;

        }

        public LockScreen()
        {
            InitializeComponent();
            sesion = Sesion.Instance;
            this.user = new Usuarios();
            this.user = sesion.Datos.getUsuario();
            this.lblUsuario.Text = "USUARIO : " +  user.usuario;
            this.lblRol.Text = CLS.Utility.getRol(user.rol);

        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            try
            {

                if (Validar())
                {
                    this.Close();
                }
                else
                {
                    
                    this.lblAviso.Text = "Contraseña Incorrecta!";
                    this.lblIntentos.Text = "***Tiene " + intentos + " intento/s disponible/s";
                  

                    if(intentos == 0)
                    {
                        MessageBox.Show("Intentos Máximos Alcanzados! Cerrando Aplicación...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    this.intentos--;
                }
            }
            catch
            {
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            this.txbPassword.ForeColor = Color.FromArgb(209, 142, 61);
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string pass = this.txbPassword.Text;

                    if (Validar())
                    {
                        this.Close();
                    }
                    else
                    {
                        
                        this.lblAviso.Text = "Contraseña Incorrecta!";
                        this.lblIntentos.Text = "***Tiene "+intentos+" intento/s disponible/s";
                       

                        if (intentos == 0)
                        {
                            MessageBox.Show("Intentos Máximos Alcanzados! Cerrando Aplicación...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        this.intentos--;
                    }
                }
                catch
                {
                }
            }
            else
            {

            }
        }

        private void LockScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
