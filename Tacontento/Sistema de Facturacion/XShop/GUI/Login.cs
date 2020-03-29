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
    public partial class Login : Form
    {
        /// <summary>
        /// Simularemos un login con variables globales
        /// </summary>
      
        /// <summary>
        /// Le hacemos una propiedad con control r+e
        /// </summary>
        Boolean _AUTORIZAR = false;

        /// <summary>
        /// un metodo para verificar si el login tiene la informacion correcta
        /// </summary>

        public Boolean AUTORIZAR
        {
            get { return _AUTORIZAR; }
        }

        /// <summary>
        /// funcion que mandaremos a llamar al evento abrir 
        /// </summary>
        /// 
        private void Validar()
        {
            ///F10 paso por procedimiento
            ///F11 paso a paso por instrucciones
            ///Ocupamos una structura try catch para el manejo de errores
            try
            {

                ///Concatenamos con "++@"
                ///Con esta consulta iremos a nuestra base de datos
               /* String Consulta = @"SELECT 
    a.IDUsuario, a.IDUsuario,
    a.Credencial, a.IDRol, a.IDEmpleado, CONCAT(c.Nombres,' ', c.Apellidos) as 'Nombre'
    FROM 
    usuarios a,
    roles b,
    empleados c
    WHERE a.Usuario = '" + txbUsuario.Text + @"'
    AND a.Credencial = md5(sha1('" + txbPassword.Text + @"'))
    AND a.IDRol = b.IDRol
    AND a.IDEmpleado = c.IDEmpleado;";*/
                ///HAREMOS UNA CONSULTA PARA RECIBIR LA INFORMACION DEL USUARIO 
                DataTable Datos = new DataTable();
                ///con el que nos conectaremos a la base de datos
                DataManager.CLS.DBOperacion Consultor = new DataManager.CLS.DBOperacion();
                ///haremos una consulta
               // Datos = Consultor.Consultar(Consulta);

                ///Verificamos si trae datos
                if (/*Datos.Rows.Count == 1*/ this.txbUsuario.Text == "Alex" && this.txbPassword.Text == "123")
                {
                    _AUTORIZAR = true;
                    Close();
                }
                else
                {
                    lblMensaje.Text = "Usuario o contraseña Incorrecta....";
                }
            }
            catch{
                lblMensaje.Text = "HA OCURRIDO UN ERROR...";
            }

        
        }
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Mandamos a llamar la funcion que valida el inicio de sesion
            Validar();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
