using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Entidades.Ordenes;

namespace XShop.GUI
{
    public partial class OrdenesForm : Form

    {
        DataTable _DATOS = new DataTable();
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


        public void setStyle()
        {
            dtgDatos.BorderStyle = BorderStyle.None;
            dtgDatos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgDatos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgDatos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(34, 32, 33); 
            dtgDatos.DefaultCellStyle.SelectionForeColor = Color.FromArgb(34, 32, 33);
            dtgDatos.BackgroundColor = Color.Black;

            dtgDatos.EnableHeadersVisualStyles = false;
            dtgDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dtgDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void Configurar()
        {
            //Creamos las columnas
            _DATOS.Columns.Add("cId");
            _DATOS.Columns.Add("cNombre");
            _DATOS.Columns.Add("cPrecio");
            _DATOS.Columns.Add("cDescripcion");
            _DATOS.Columns.Add("cClasificacion");

            //No generar las columnas automaticamente
            dtgDatos.AutoGenerateColumns = false;

            /// Agregamos los datos a la DataGridView
            dtgDatos.DataSource = _DATOS;
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

        public void CargarRegistros()
        {
            
            OrdenDAO orderDao = new OrdenDAO();
            List<Ordenes> list = orderDao.TodasLasOrdenes();
            
            if (list!=null)
            {

                dtgDatos.Rows.Clear();
                dtgDatos.Refresh();

                for (int i = 0; i < list.Count; i++)
                {
                    DataRow NuevaFila = _DATOS.NewRow();
                    Ordenes Orden = new Ordenes();
                    Orden = list[i];
                    dtgDatos.Rows.Add(Orden.idOrden, Orden.nombre, Orden.precio, Orden.descripcion, CLS.Utility.DevolverClasificacion(Orden.idClasificacion));

                   
                }

                this.lblRegistros.Text = dtgDatos.Rows.Count + " Registros para este formulario";
            }
            else
            {
                this.lblRegistros.Text = "0 Registros para este formulario";
            }
        }



        public OrdenesForm()
        {

            InitializeComponent();
            setStyle();
            setComboBox();
            ///Configurar();
            CargarRegistros();



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            ////CLS.Utility.textBoxIsEmpty(this.txbDescripcion);
            Ordenes orden = new Ordenes();
            orden.nombre = this.txbNombre.Text;
            orden.precio = Convert.ToDecimal(this.txbPrecio.Text, new CultureInfo("en-US"));
            orden.descripcion = this.txbDescripcion.Text;

            ComboItem item = this.cmbIdClasificacion.SelectedItem as ComboItem;

            orden.idClasificacion = item.Key;

            OrdenDAO dao = new OrdenDAO();
            if (dao.InsertarOrden(orden)!=null) {
                this.txbNombre.Text = "";
                this.txbPrecio.Text = "";
                this.txbDescripcion.Text = "";
            }
            else
            {
                MessageBox.Show("Ocurrio un error...");
            }


            CargarRegistros();
        }

        private void OrdenesForm_Load(object sender, EventArgs e)
        {

        }

        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
