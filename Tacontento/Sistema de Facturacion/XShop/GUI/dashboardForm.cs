using Entidades.Entidades.Pedidos;
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
            try
            {
                List<Entidades.Entidades.Pedidos.Pedidos> list = pedidosDao.findAll();
                dtgPedidos.Rows.Clear();
                foreach (Entidades.Entidades.Pedidos.Pedidos p in list)
                {

                    Entidades.Entidades.Incidentes.Incidente inc = new Entidades.Entidades.Incidentes.Incidente();
                    if (!IncidentesDao.getIncidentesByPedido(p.id).Equals(null))
                    {
                        Decimal total = 0;
                        foreach(Entidades.Entidades.Incidentes.Incidente e in IncidentesDao.getIncidentesByPedido(p.id))
                        {
                            total += e.Precio;
                        }
                        inc.Precio = total;
                    }
                    else
                    {
                        inc.Precio = Decimal.Parse("0.00");
                    }

                    dtgPedidos.Rows.Add(p.id, p.nombreCliente, p.listaDetalles.Count, p.total, inc.Precio, p.total + inc.Precio);


                }
                dtgPedidos.AutoGenerateColumns = false;
                this.lblConteo.Text = dtgPedidos.Rows.Count + " Registros Encontrados";
            }
            catch
            {

            }      
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Pedidos p = new Pedidos(null, this);
            p.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.txbidPedido.Text == string.Empty)
            {
                MessageBox.Show("Seleccione una Opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                Entidades.Entidades.Pedidos.PedidosDAO pd = new Entidades.Entidades.Pedidos.PedidosDAO();
                XShop.GUI.Pedidos pdi = new XShop.GUI.Pedidos(pd.getPedidosById(int.Parse(this.txbidPedido.Text)), this);
                pdi.ShowDialog();
            }

        }

        private void btnIncidente_Click(object sender, EventArgs e)
        {
            if (this.txbidPedido.Text == string.Empty)
            {
                MessageBox.Show("Seleccione una Opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                    IncidenteForm inf = new IncidenteForm(int.Parse(this.txbidPedido.Text), this);
                    inf.ShowDialog();
                
            }

        }
        private void dashboardForm_Load(object sender, EventArgs e)
        {
            dtgPedidos.CurrentCell = null;
        }

        private void dtgPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idpedido = (int)dtgPedidos.SelectedRows[0].Cells[0].Value;
            this.txbidPedido.Text = idpedido.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.txbidPedido.Text == string.Empty)
            {
                MessageBox.Show("Seleccione una Opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Desea Eliminar el Pedido seleccionado?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Entidades.Entidades.Pedidos.Pedidos p = new Entidades.Entidades.Pedidos.Pedidos();
                    p.id = int.Parse(this.txbidPedido.Text);

                    PedidosDAO dao = new PedidosDAO();

                    try
                    {
                        if (dao.DeletePedido(p) > 0)
                        {
                            MessageBox.Show("Pedido Eliminado Correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se Pudo Eliminar.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("No se Pudo Eliminar: " + ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                this.DisplayDatos();
            }
         }
    }
}
