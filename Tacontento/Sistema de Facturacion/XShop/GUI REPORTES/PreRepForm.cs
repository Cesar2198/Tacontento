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
    public partial class PreRepForm : Form
    {
        BindingSource _DATOS = new BindingSource();

        public void CargarRegistros()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.VentasPorAnio();
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



        public PreRepForm()
        {
            InitializeComponent();
            CargarRegistros();
            VacioRegistro();
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
            Reportes.GUI.ReporteVentasAnioForm f = new Reportes.GUI.ReporteVentasAnioForm();
            f.ShowDialog();
        }

        private void PreRepForm_Load(object sender, EventArgs e)
        {
            dtgDatos.CurrentCell = null;
        }
    }
}
