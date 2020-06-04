using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Entidades.Roles;
using XShop.GUI_AUXILIAR;

namespace XShop.GUI
{
    public partial class PreRepBitacora : Form
    {
        BindingSource _DATOS = new BindingSource();

        int anio = 2020;
        int anioselected;
        public void CargarRegistros(int anio)
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.Bitacora(anio);
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



        public PreRepBitacora()
        {
            InitializeComponent();
            CargarRegistros(anio);
            VacioRegistro();
            setearAnioActual();
            this.txbanio.Text = System.DateTime.Now.Year.ToString();
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
            Reportes.GUI.ReporteBitacoraForm f = new Reportes.GUI.ReporteBitacoraForm(int.Parse(this.txbanio.Text));
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
            
            if (CLS.Utility.textBoxIsEmpty(list))
            {
                anioselected = int.Parse(this.txbanio.Text);
            }
            else
            {
                MessageBox.Show("Rellene todos los Campos", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txbanio.Text = anio.ToString();
            }

            CargarRegistros(anioselected);
        }

        private void txbanio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<TextBox> list = new List<TextBox>();
                list.Add(this.txbanio);

                if (CLS.Utility.textBoxIsEmpty(list))
                {
                    anioselected = int.Parse(this.txbanio.Text);
                }
                else
                {
                    MessageBox.Show("Rellene todos los Campos", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.txbanio.Text = anio.ToString();
                }

                CargarRegistros(anioselected);
            }
            else
            {

            }
            }
    }
}
