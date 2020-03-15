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
    public partial class PruebaConector : Form
    {
        public PruebaConector()
        {
            InitializeComponent();
        }

        private void PruebaConector_Load(object sender, EventArgs e)
        {

        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            ///Agregaremos un evento al boton
            ///Creamos un objeto de database Operacion para ejecutar una accion
            DataManager.CLS.DBOperacion oOperacion = new DataManager.CLS.DBOperacion();
            //Ejecutar una consulta asignando al datagridview la tabla que nos trae, ademas pasando como parametro lo que el usuario ingrese
            dtgDatos.DataSource = oOperacion.Consultar(txbConsulta.Text);

            ///F10 Por procedimientos
            ///F11: Profundizar

        }

        private void btnSentencia_Click(object sender, EventArgs e)
        {
            ///Haremos un evento para ejecutar una sentencia
            DataManager.CLS.DBOperacion oSentencia = new DataManager.CLS.DBOperacion();

            ///Una variable entera que nos llevara el control de las filas que se afecten
            Int32 FilasAfectadas = 0;
            FilasAfectadas = oSentencia.Insertar(txbSentencia.Text);
            //un mensaje que nos saldra indicando que fue lo que afectamos
            MessageBox.Show(FilasAfectadas.ToString() + "Registros afectados");
        }
    }
}
