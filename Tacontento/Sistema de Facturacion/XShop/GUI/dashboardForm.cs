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
    public partial class dashboardForm : Form
    {
        BindingSource pedidos = new BindingSource();

        Entidades.Entidades.Pedidos.PedidosDAO pedidosDao;
        Entidades.Entidades.Incidentes.IncidenteDao IncidentesDao;
        public dashboardForm()
        {
            pedidosDao = new Entidades.Entidades.Pedidos.PedidosDAO();
            IncidentesDao = new Entidades.Entidades.Incidentes.IncidenteDao();
            InitializeComponent();
            DisplayDatos();
        }

        public void DisplayDatos()
        {

            List<Entidades.Entidades.Pedidos.Pedidos> list = pedidosDao.findAll();
            dtgPedidos.Rows.Clear();
            foreach (Entidades.Entidades.Pedidos.Pedidos p in list)
            {
               
                Entidades.Entidades.Incidentes.Incidente inc = new Entidades.Entidades.Incidentes.Incidente();
                if (!IncidentesDao.getIncidenteByPedido(p.id).Equals(null))
                {
                    inc = IncidentesDao.getIncidenteByPedido(p.id);
                }
                else
                {
                    inc.Precio = Decimal.Parse("0.00");
                }

                dtgPedidos.Rows.Add(p.id, p.nombreCliente, p.listaDetalles.Count, p.total, inc.Precio, p.total + inc.Precio);

            }  
            this.lblConteo.Text = dtgPedidos.Rows.Count + " Registros Encontrados";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Pedidos p = new Pedidos(null, this);
            p.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idpedido = (int)dtgPedidos.SelectedRows[0].Cells[0].Value;
            Entidades.Entidades.Pedidos.PedidosDAO pd = new Entidades.Entidades.Pedidos.PedidosDAO();
            XShop.GUI.Pedidos pdi = new XShop.GUI.Pedidos(pd.getPedidosById(idpedido), this);
            pdi.ShowDialog();

        }

        private void btnIncidente_Click(object sender, EventArgs e)
        {
            int idpedido = (int)dtgPedidos.SelectedRows[0].Cells[0].Value;
            if (Decimal.Parse(dtgPedidos.SelectedRows[0].Cells[4].Value.ToString()) == 0)
            {
                IncidenteForm inf = new IncidenteForm(idpedido, this);
                inf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ya tiene agregado un incidente");
            }

        }
    }
}
