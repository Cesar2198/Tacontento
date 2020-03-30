using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Entidades.Ordenes;

namespace XShop.GUI
{
    public partial class OrdenesForm : Form

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
        public void setComboBox()
        {
            OrdenDAO orden = new OrdenDAO();
            for (int i =0; i<orden.getClasificacionesOrdenes().Count;i++)
            {
                int id = orden.getClasificacionesOrdenes()[i].idClasificacion;
                string nombre = orden.getClasificacionesOrdenes()[i].nombre;

                this.cmbIdClasificacion.Items.Add(new ComboItem(id, nombre));
            }
        }
        public OrdenesForm()
        {
            InitializeComponent();
            setComboBox();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            ////CLS.Utility.textBoxIsEmpty(this.txbDescripcion);
            Ordenes orden = new Ordenes();
            orden.nombre = this.txbNombre.Text;
            orden.precio = Decimal.Parse(this.txbPrecio.Text);
            orden.descripcion = this.txbDescripcion.Text;

            ComboItem item = this.cmbIdClasificacion.SelectedItem as ComboItem;

            orden.idClasificacion = item.Key;

            OrdenDAO dao = new OrdenDAO();
            if (dao.InsertarOrden(orden)!=null) {
                MessageBox.Show("se ha ingresado la orden:" + orden.nombre);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
            this.Close(); 
        }

        private void OrdenesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
