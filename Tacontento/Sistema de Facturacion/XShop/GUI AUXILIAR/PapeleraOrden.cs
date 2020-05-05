using Entidades.Entidades.Ordenes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XShop.GUI;

namespace XShop.GUI_AUXILIAR
{
    public partial class PapeleraOrden : Form
    {
        BindingSource _DATOS = new BindingSource();
        /// <summary>
        /// Abrimos el formulario en ejecucion para que haga los cambios instantaneamente
        /// </summary>
        OrdenesForm obj = (OrdenesForm)Application.OpenForms["OrdenesForm"];

        private void CargarRegistros()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Papelera.TODOS_LAS_ORDENES_ELIMINADOS();
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
                if (this.txbFiltro.TextLength > 0)
                {
                    _DATOS.Filter = "nombre LIKE '%" + this.txbFiltro.Text + "%' ";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgDatos.AutoGenerateColumns = false;
                dtgDatos.DataSource = _DATOS;
                this.lblContador.Text = dtgDatos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public Boolean AccionRealizada()
        {
            Boolean valido = false;
            try
            {
                if (dtgDatos.Rows.Count != 0)
                {
                    int idOrden;
                    idOrden = int.Parse(dtgDatos.CurrentRow.Cells["idOrden"].Value.ToString());
                    Ordenes orden = new Ordenes();
                    orden.idOrden = idOrden;

                    OrdenDAO dao = new OrdenDAO();
                    if (dao.RecuperarOrdenes(orden) != null)
                    {
                        MessageBox.Show("Orden Restaurada!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        valido = true;
                    }
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un Error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                valido = false;
                MessageBox.Show("Ha ocurrido un Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            return valido;
        }


        public PapeleraOrden()
        {
            InitializeComponent();
            CargarRegistros();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (AccionRealizada())
            {
                CargarRegistros();
                obj.CargarRegistros();
                obj.dtgDatos.Update();
                obj.dtgDatos.Refresh();
            }
        }
    }
}
