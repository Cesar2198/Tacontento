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
    public partial class IncidenteForm : Form
    {
        private int idpedido;
        private dashboardForm df;
        public IncidenteForm(int id, dashboardForm d)
        {
            idpedido = id;
            df = d;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Entidades.Entidades.Incidentes.Incidente inc = new Entidades.Entidades.Incidentes.Incidente();
            Entidades.Entidades.Incidentes.IncidenteDao incDao = new Entidades.Entidades.Incidentes.IncidenteDao();

            inc.Descripcion = txbDesc.Text;
            inc.Pedido = idpedido;
            inc.Precio = Decimal.Parse(txbCobro.Text);
            if (!txbCobro.Equals("") && !txbDesc.Equals(""))
            {
                if (incDao.insertarIncidente(inc))
                {
               
                    MessageBox.Show("Se agrego un incidente");
                    df.DisplayDatos();
                    Close();
                }
                else
                {
                    MessageBox.Show("Hubo un problema");
                }

            }else
            {
                MessageBox.Show("LLene los campos");
            }


        }
    }
}
