using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Entidades.DetallesPedido;
using Entidades.Entidades.Ordenes;
using Entidades.Entidades.Pedidos;

namespace XShop.GUI
{
    public partial class Pedidos : Form
    {
        class ComboItem
        {
            public int Key { get; set; }
            public string Value { get; set; }
            public ComboItem(int key, string value)
            {
                Key = key; Value = value;
            }
            public override string ToString()
            {
                return Value;
            }
        }

        public List<DetallePedidos> list;
        private Entidades.Entidades.Pedidos.Pedidos pedidos;
        private dashboardForm df;
        public Pedidos(Entidades.Entidades.Pedidos.Pedidos p, dashboardForm d)
        {
            this.pedidos = p;
            this.df = d;
            InitializeComponent();
            ConfigurarTabla();
            setComboBox();
            this.txbEmpleado.Text = SessionManager.CLS.Sesion.Instance.Datos.getUsuario().usuario;
            if (this.pedidos != null)
            {
                PedidosDAO pdo = new PedidosDAO();
                list = pdo.GetDetallePedidos(this.pedidos.id);
                this.txbCliente.Text = this.pedidos.nombreCliente;
                this.lblTotal.Text = this.pedidos.total.ToString();
                this.cmbPago.SelectedIndex = this.pedidos.tipoPago == 1 ? 0 : 1;
                CargarTable();
            }
            else
            {
                list = new List<DetallePedidos>();
            }


        }

        public void setComboBox()
        {
            this.cmbPago.Items.Add(new ComboItem(1, "Efectivo"));
            this.cmbPago.Items.Add(new ComboItem(2, "Tarjeta"));
        }

        public void ConfigurarTabla()
        {
            dtgPedido.AutoGenerateColumns = false;
            foreach (DataGridViewColumn c in dtgPedido.Columns)
                if (c.Name != "cCantidad") c.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem item = this.cmbPago.SelectedItem as ComboItem;
            decimal desc = 0.10m;
            if (list.Count != 0)
            {
                if (item.Key == 2)
                {
                    this.lblTotal.Text = "$" + decimal.Round(Totalizar() + Totalizar() * desc, 2).ToString();
                }
                else
                {
                    this.lblTotal.Text = "$" + (Totalizar()).ToString();
                }
            }
            else
            {
                this.lblTotal.Text = "$0.00";
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void CargarTable()
        {
            dtgPedido.Rows.Clear();
            dtgPedido.Refresh();
            for (int i = 0; i < list.Count; i++)
            {
                DetallePedidos o = list[i];
                dtgPedido.Rows.Add(o.IdOrden, CLS.Utility.getOrdenById(o.IdOrden).nombre, o.Precio, o.Cantidad, (o.Precio * o.Cantidad));
            }
            this.lblCantidadOrdenes.Text = list.Count.ToString() + " Orden(es) Registradas";
            dtgPedido.CurrentCell = null;
        }

        public void AgregarOrdenes(int id)
        {
            OrdenDAO od = new OrdenDAO();
            Ordenes o = new Ordenes();

            o = od.ObtenerOrdenById(id);

            DetallePedidos dp = new DetallePedidos();
            dp.IdOrden = o.idOrden;
            dp.Precio = o.precio;
            dp.Cantidad = 1;
            list.Add(dp);
            this.lblTotal.Text = "$" + decimal.Round(Totalizar(), 2).ToString();
            CargarTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<TextBox> list = new List<TextBox>();
            list.Add(this.txbSearch);
            searchForm s = new searchForm(this, this.list, this.txbSearch.Text);
            if (CLS.Utility.textBoxIsEmpty(list))
            {
                if (s.valido)
                {
                    CLS.Utility.ClearTextbox(list);
                    s.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se Encontró ninguna orden en los Registros.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Rellene este Campo.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public decimal Totalizar()
        {
            decimal total = 0;
            for (int i = 0; i < list.Count; i++)
            {
                total += list[i].Precio * list[i].Cantidad;
            }
            return total;
        }

        private void dtgPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgPedido_SelectionChanged(object sender, EventArgs e)
        {
          /*DataGridViewCell cell = dtgPedido.Rows[0].Cells[3];
            dtgPedido.CurrentCell = cell;
            dtgPedido.BeginEdit(true);*/
        }

        private void dtgPedido_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgPedido.Columns[e.ColumnIndex].Name == "cCantidad")
            {
                if ((dtgPedido.Rows[e.RowIndex].Cells[3].Value) != null)
                {

                    list[e.RowIndex].Cantidad = int.Parse((dtgPedido.Rows[e.RowIndex].Cells[3].Value).ToString());
                    if (list[e.RowIndex].Cantidad != 0)
                    {
                        dtgPedido.Rows[e.RowIndex].Cells[4].Value = list[e.RowIndex].Cantidad * list[e.RowIndex].Precio;
                    }
                    else
                    {
                        dtgPedido.Rows[e.RowIndex].Cells[3].Value = 1;
                        list[e.RowIndex].Cantidad  = int.Parse((dtgPedido.Rows[e.RowIndex].Cells[3].Value).ToString());
                        dtgPedido.Rows[e.RowIndex].Cells[4].Value = list[e.RowIndex].Cantidad * list[e.RowIndex].Precio;
                    }

                }
                else
                {
                    dtgPedido.Rows[e.RowIndex].Cells[3].Value = 1;
                    MessageBox.Show("No se puede dejar vacio.");
                }
                this.lblTotal.Text = "$" + decimal.Round(Totalizar(), 2).ToString();
            }

        }

        private void txbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<TextBox> list = new List<TextBox>();
                list.Add(this.txbSearch);
                searchForm s = new searchForm(this, this.list, this.txbSearch.Text);
                if (CLS.Utility.textBoxIsEmpty(list))
                {
                    if (s.valido)
                    {
                        CLS.Utility.ClearTextbox(list);
                        s.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No se Encontró ninguna orden en los Registros.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Rellene este Campo.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.pedidos != null)
            {
                Entidades.Entidades.Pedidos.Pedidos pp = new Entidades.Entidades.Pedidos.Pedidos();
                ComboItem item = this.cmbPago.SelectedItem as ComboItem;
                PedidosDAO pdo = new PedidosDAO();
                pp.nombreCliente = txbCliente.Text;
                pp.tipoPago = item.Key;
                pp.total = Decimal.Parse(lblTotal.Text.Remove(0, 1));
                pp.id = this.pedidos.id;
                pp.listaDetalles = this.pedidos.listaDetalles;

                List<DetallePedidos> listanueva = new List<DetallePedidos>();
                ///List<DetallePedidos> listeliminada = new List<DetallePedidos>();

                ///Comprobar si hay nuevas ordenes

                int lenght1 = list.Count;
                int lenght2 = pdo.GetDetallePedidos(pp.id).Count;
                List<DetallePedidos> l = pdo.GetDetallePedidos(pp.id);
                if (lenght1 > lenght2)
                {


                    for (int i = (lenght1 - 1); i >= (lenght2); i--)
                    {
                        listanueva.Add(list[i]);
                    }

                }


                pp.listaDetalles = list;



                pdo.updatePedido(pp);
                pdo.InsertarDetalles(listanueva, pp);
                this.df.DisplayDatos();
                Close();



            }
            else
            {
                List<TextBox> Lista = new List<TextBox>();
                Lista.Add(this.txbCliente);



                if (list.Count != 0 && CLS.Utility.textBoxIsEmpty(Lista) && this.cmbPago.Text != string.Empty)
                {


                    ComboItem item = this.cmbPago.SelectedItem as ComboItem;
                    Entidades.Entidades.Pedidos.Pedidos pe = new Entidades.Entidades.Pedidos.Pedidos();
                    pe.nombreCliente = this.txbCliente.Text;
                    pe.idUsuario = SessionManager.CLS.Sesion.Instance.Datos.getUsuario().idUsuario;
                    pe.estado = 1;
                    pe.total = decimal.Round(Totalizar(), 2);
                    pe.tipoPago = item.Key;
                    pe.listaDetalles = list;


                    PedidosDAO p = new PedidosDAO();
                    if (p.InsertarPedido(pe) != null)
                    {
                        MessageBox.Show("Se inserto una nueva orden pendiente", "información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.df.DisplayDatos();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar");
                    }
                }
                else
                {
                    MessageBox.Show("Se deben insertar ordenes! o Rellenar todos los campos", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void dtgPedido_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtgPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgPedido.CurrentRow.Index;
            this.txbIndex.Text = index.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.txbIndex.Text != String.Empty)
            {
                if (MessageBox.Show("Desea Eliminar el Pedido seleccionado?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                 {
                
                
                    list.RemoveAt(int.Parse(this.txbIndex.Text));
                    dtgPedido.Rows.RemoveAt(int.Parse(this.txbIndex.Text));
                    CargarTable();
                    this.lblTotal.Text = "$" + (Totalizar()).ToString();
                    this.txbIndex.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Operacion Cancelada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Seleccione una Opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
