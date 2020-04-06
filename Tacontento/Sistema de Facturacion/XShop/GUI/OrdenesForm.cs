using System;
using System.Activities.Expressions;
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
using Microsoft.VisualBasic;

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
            for (int i = 0; i < orden.getClasificacionesOrdenes().Count; i++)
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

            if (list != null)
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
            //setStyle();
            txbId.Visible = false;
            setComboBox();
            ///Configurar();
            CargarRegistros();




        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(this.txbId);
            Lista.Add(this.txbNombre);
            Lista.Add(this.txbDescripcion);
            Lista.Add(this.txbPrecio);

            ////CLS.Utility.textBoxIsEmpty(this.txbDescripcion);
            if (CLS.Utility.textBoxIsEmpty(Lista) && this.cmbIdClasificacion.Text != String.Empty)
            {
                Ordenes orden = new Ordenes();
                orden.nombre = this.txbNombre.Text;
                orden.precio = Convert.ToDecimal(this.txbPrecio.Text);
                orden.descripcion = this.txbDescripcion.Text;

                ComboItem item = this.cmbIdClasificacion.SelectedItem as ComboItem;

                orden.idClasificacion = item.Key;

                OrdenDAO dao = new OrdenDAO();


                if (dao.InsertarOrden(orden) != null)
                {
                    CLS.Utility.ClearTextbox(Lista);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error...");
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los Campos.");
            }
            CargarRegistros();
        }

        private void OrdenesForm_Load(object sender, EventArgs e)
        {

        }

        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void dtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgDatos.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                ///Esto, cuando se selecciona una fila rellena los textbox y el combobox
                ///son strings ya que el textbox solo eso detecta 
                String Id = dtgDatos.SelectedRows[0].Cells[0].Value + string.Empty;
                string Nombre = dtgDatos.SelectedRows[0].Cells[1].Value + string.Empty;
                string Descripcion = dtgDatos.SelectedRows[0].Cells[3].Value + string.Empty;
                String precio = dtgDatos.SelectedRows[0].Cells[2].Value + string.Empty;
                String Clasificacion = dtgDatos.SelectedRows[0].Cells[4].Value + string.Empty;

                txbNombre.Text = Nombre;
                txbDescripcion.Text = Descripcion;
                txbPrecio.Text = precio;
                txbId.Text = Id;///Con esto buscas el valor de un combobox y lo ubicas, asi.
                this.cmbIdClasificacion.SelectedIndex = this.cmbIdClasificacion.FindStringExact(Clasificacion);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(this.txbId);
            Lista.Add(this.txbNombre);
            Lista.Add(this.txbDescripcion);
            Lista.Add(this.txbPrecio);

            if (CLS.Utility.textBoxIsEmpty(Lista) && this.cmbIdClasificacion.Text != String.Empty)
            {
                if (MessageBox.Show("Desea Editar el registro seleccionado?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Ordenes _orden = new Ordenes();
                    _orden.idOrden = int.Parse(this.txbId.Text);
                    _orden.nombre = this.txbNombre.Text;
                    _orden.descripcion = this.txbDescripcion.Text;
                    _orden.precio = decimal.Parse(this.txbPrecio.Text);
                    var x = (ComboItem)this.cmbIdClasificacion.Items[this.cmbIdClasificacion.SelectedIndex] as ComboItem;
                    _orden.idClasificacion = x.Key;


                    OrdenDAO dao = new OrdenDAO();
                    try
                    {
                        if (dao.Modificar(_orden) != null)
                        {
                            CLS.Utility.ClearTextbox(Lista);

                        }
                    }
                    catch (Exception eh)
                    {
                        MessageBox.Show("Ocurrio un error... " + eh.Message);
                        throw;
                    }

                }
                else
                {
                    CLS.Utility.ClearTextbox(Lista);
                    this.cmbIdClasificacion.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los Campos.");
            }

            CargarRegistros();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(this.txbId);
            Lista.Add(this.txbNombre);
            Lista.Add(this.txbDescripcion);
            Lista.Add(this.txbPrecio);
            if (CLS.Utility.textBoxIsEmpty(Lista) && this.cmbIdClasificacion.Text != String.Empty)
            {

                if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Ordenes orden = new Ordenes();
                    orden.idOrden = int.Parse(this.txbId.Text);

                    OrdenDAO dao = new OrdenDAO();
                    try
                    {
                        if (dao.Eliminar(orden) != null)
                        {
                            CLS.Utility.ClearTextbox(Lista);

                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrio un error...");
                        throw;
                    }

                }
                else
                {
                    CLS.Utility.ClearTextbox(Lista);
                    this.cmbIdClasificacion.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.");
            }
            CargarRegistros();
        }

        private void dtgDatos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbPrecio_KeyPress(object sender, KeyPressEventArgs v)
        {
            String Cadena = txbPrecio.Text;
            var filtro = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            /*
            if (Strings.Len(Cadena) > 0)
            {
                filtro += ".";
            }

            foreach (var caracter in filtro)
            {
                if (v.KeyChar.ToString() == caracter)
                {
                    v.Handled = false;
                }
                else
                {
                    v.Handled = true;
                }
            }*/

            if (v.KeyChar.ToString().Equals("0") && Strings.Mid(Cadena,1,1) == "0" && Strings.Len(Cadena) == 1)
            {
                txbPrecio.Text = "";
            }else if (!v.KeyChar.ToString().Equals("0") && !v.KeyChar.ToString().Equals(".") && Strings.Mid(Cadena,1,1) == "0" && Strings.Len(Cadena).Equals(1))
            {
                txbPrecio.Text = "";
            }


            if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }

           
            
        }
    }
}
