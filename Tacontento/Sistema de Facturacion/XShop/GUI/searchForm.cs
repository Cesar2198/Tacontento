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
    public partial class searchForm : Form
    {
        private Pedidos pedidoForm;
        private string key;
        private List<Ordenes> list;
        public Boolean valido = false;
        private List<DetallePedidos> myList;
        public searchForm(Pedidos f, List<DetallePedidos> lst, string name)
        {
            this.pedidoForm = f;
            this.myList = lst;
            this.key = name;
            InitializeComponent();
            Configurar();
            LoadTable();
            
        }

        private void Configurar()
        {

            //No generar las columnas automaticamente
            dtgOrdenes.AutoGenerateColumns = false;
        }

        public void LoadTable()
        {
            OrdenDAO ordenDao = new OrdenDAO();
            list = ordenDao.getOrdenByName(this.key);
            if (list.Count == 0 )
            {
                valido = false;
            }
            else
            {
                valido = true;
                for (int i = 0; i < list.Count; i++)
                {

                    Ordenes Orden = new Ordenes();
                    Orden = list[i];
                    dtgOrdenes.Rows.Add(Orden.idOrden, Orden.nombre, Orden.precio);
                }
            }
 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = (int)dtgOrdenes.SelectedRows[0].Cells[0].Value;
            Boolean valido = false;
            for (int i = 0; i < this.myList.Count; i++)
            {
                if (this.myList[i].IdOrden == id)
                {
                    valido = true;
                    break;
                }
            }
            

            if (valido)
            {
                MessageBox.Show("Ya se encuentra agregada esta orden.");

            }
            else
            {
                this.pedidoForm.AgregarOrdenes(id);
            }
         
            this.Close();
        }
    }
}
