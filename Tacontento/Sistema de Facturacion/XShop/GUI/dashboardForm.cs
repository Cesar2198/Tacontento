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
        Entidades.Entidades.Pedidos.PedidosDAO pedidosDao;
        public dashboardForm()
        {
            pedidosDao = new Entidades.Entidades.Pedidos.PedidosDAO();
            InitializeComponent();
            DisplayDatos();
        }

        public void DisplayDatos()
        {
            List<Entidades.Entidades.Pedidos.Pedidos> list = pedidosDao.findAll();
            dtgPedidos.Rows.Clear();
            foreach(Entidades.Entidades.Pedidos.Pedidos p in list)
            {
                dtgPedidos.Rows.Add(p.id, p.nombreCliente, p.listaDetalles.Count, p.total);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Pedidos p = new Pedidos(null,null);
            p.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idpedido = (int)dtgPedidos.SelectedRows[0].Cells[0].Value;
            Entidades.Entidades.Pedidos.PedidosDAO pd = new Entidades.Entidades.Pedidos.PedidosDAO();
            XShop.GUI.Pedidos pdi = new XShop.GUI.Pedidos(pd.getPedidosById(idpedido),this);
            pdi.ShowDialog();

        }
    }
}
