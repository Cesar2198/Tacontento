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

namespace XShop.GUI
{
    public partial class Pedidos : Form
    {
        private List<DetallePedidos> list;
        public Pedidos()
        {
            InitializeComponent();
            ConfigurarTabla();
            list = new List<DetallePedidos>();

        }

        public void ConfigurarTabla()
        {
            dtgPedido.AutoGenerateColumns = false;
            foreach (DataGridViewColumn c in dtgPedido.Columns)
                if (c.Name != "cCantidad") c.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            this.lblTotal.Text = "$ " + Totalizar().ToString();
            CargarTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<TextBox> list = new List<TextBox>();
            list.Add(this.txbSearch);
            searchForm s = new searchForm(this, this.txbSearch.Text);
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
            for (int i =0; i< list.Count; i++)
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
            dtgPedido.CurrentCell = dtgPedido.CurrentRow.Cells["cCantidad"];
            dtgPedido.BeginEdit(true);
        }

        private void dtgPedido_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgPedido.Columns[e.ColumnIndex].Name == "cCantidad")
            {
                if ((dtgPedido.Rows[e.RowIndex].Cells[3].Value) != null)
                {
                    list[e.RowIndex].Cantidad = int.Parse((dtgPedido.Rows[e.RowIndex].Cells[3].Value).ToString());
                    dtgPedido.Rows[e.RowIndex].Cells[4].Value = list[e.RowIndex].Cantidad * list[e.RowIndex].Precio;
                }
                else
                {
                    dtgPedido.Rows[e.RowIndex].Cells[3].Value = 1;
                    MessageBox.Show("No se puede dejar vacio.");
                }
                this.lblTotal.Text = "$ " + Totalizar().ToString();
            }
            
        }
    }
}
