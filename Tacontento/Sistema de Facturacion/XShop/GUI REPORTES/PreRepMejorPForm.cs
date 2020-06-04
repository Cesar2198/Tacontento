using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Entidades.Roles;
using XShop.GUI_AUXILIAR;

namespace XShop.GUI
{
    public partial class PreRepMejorPForm : Form
    {
        BindingSource _DATOS = new BindingSource();

        int anio = int.Parse(System.DateTime.Now.Year.ToString());

        static int mes = int.Parse(System.DateTime.Now.Month.ToString());

        string nombremes = CLS.Utility.DevolverNombreMes(mes);

        int anioselected;
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
            this.cmbMes.Items.Add(new ComboItem(1, "Enero"));
            this.cmbMes.Items.Add(new ComboItem(2, "Febrero"));
            this.cmbMes.Items.Add(new ComboItem(3, "Marzo"));
            this.cmbMes.Items.Add(new ComboItem(4, "Abril"));
            this.cmbMes.Items.Add(new ComboItem(5, "Mayo"));
            this.cmbMes.Items.Add(new ComboItem(6, "Junio"));
            this.cmbMes.Items.Add(new ComboItem(7, "Julio"));
            this.cmbMes.Items.Add(new ComboItem(8, "Agosto"));
            this.cmbMes.Items.Add(new ComboItem(9, "Septiembre"));
            this.cmbMes.Items.Add(new ComboItem(10, "Octubre"));
            this.cmbMes.Items.Add(new ComboItem(11, "Noviembre"));
            this.cmbMes.Items.Add(new ComboItem(12, "Diciembre"));
        }


        public void CargarRegistros(int anio,int numeromes)
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.MejorProducto(anio,numeromes);
                FiltrarLocalmente();
            }
            catch (Exception)
            {

            }
        }

        private void FiltrarLocalmente()
        {
            try
            {
                dtgDatos.AutoGenerateColumns = false;
                dtgDatos.DataSource = _DATOS;
                this.lblRegistros.Text = dtgDatos.Rows.Count.ToString() + " Registros Encontrados";
                VacioRegistro();
            }
            catch (Exception)
            {


            }
        }

        public void VacioRegistro()
        {
            if(dtgDatos.Rows.Count == 0)
            {
                this.btnVer.Enabled = false;
            }
            else
            {
                this.btnVer.Enabled = true;
            }
        }

        public void setearAnioActual()
        {
            this.txtbAnioActual.Text = "Año Actual : " + System.DateTime.Now.Year.ToString();
        }



        public PreRepMejorPForm()
        {
            InitializeComponent();
            CargarRegistros(anio,mes);
            setComboBox();
            VacioRegistro();
            setearAnioActual();
            this.txbanio.Text = System.DateTime.Now.Year.ToString();
            this.lblMes.Text = "Mes Actual : "+  nombremes;
            this.cmbMes.SelectedIndex = this.cmbMes.FindStringExact(nombremes);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
      
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
           

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void txbFiltro_Click(object sender, EventArgs e)
        {

        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            ComboItem item = this.cmbMes.SelectedItem as ComboItem;
            Reportes.GUI.ReporteMejorProductoForm f = new Reportes.GUI.ReporteMejorProductoForm(this.anio, item.Key,CLS.Utility.DevolverNombreMes(item.Key));
            f.ShowDialog();
        }

        private void PreRepForm_Load(object sender, EventArgs e)
        {
            dtgDatos.CurrentCell = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbanio_KeyPress(object sender, KeyPressEventArgs v)
        {
            if (char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            List<TextBox> list = new List<TextBox>();
            list.Add(this.txbanio);
            ComboItem item = this.cmbMes.SelectedItem as ComboItem;
            int mesSelected = item.Key;
            if (CLS.Utility.textBoxIsEmpty(list) && this.cmbMes.Text != string.Empty)
            {
                anioselected = int.Parse(this.txbanio.Text);
            }
            else
            {
                MessageBox.Show("Rellene todos los Campos", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txbanio.Text = anio.ToString();
            }

            CargarRegistros(anioselected,mesSelected);
        }

        private void txbanio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<TextBox> list = new List<TextBox>();
                list.Add(this.txbanio);
                ComboItem item = this.cmbMes.SelectedItem as ComboItem;
                int mesSelected = item.Key;
                if (CLS.Utility.textBoxIsEmpty(list) && this.cmbMes.Text != string.Empty)
                {
                    anioselected = int.Parse(this.txbanio.Text);
                }
                else
                {
                    MessageBox.Show("Rellene todos los Campos", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.txbanio.Text = anio.ToString();
                }

                CargarRegistros(anioselected, mesSelected);
            }
            else
            {

            }
            }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
