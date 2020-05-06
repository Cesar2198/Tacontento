using Entidades.Entidades.Empleados;
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
    public partial class PapeleraEmpleados : Form
    {
        BindingSource _DATOS = new BindingSource();
        /// <summary>
        /// Abrimos el formulario en ejecucion para que haga los cambios instantaneamente
        /// </summary>
        EmpleadosForm obj = (EmpleadosForm)Application.OpenForms["EmpleadosForm"];

        private void CargarRegistros()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Papelera.TODOS_LOS_EMPLEADOS_ELIMINADOS();
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
                    int idEmpleado;
                    idEmpleado = int.Parse(dtgDatos.CurrentRow.Cells["idEmpleado"].Value.ToString());
                    Empleados empleado = new Empleados();
                    empleado.idEmpleado = idEmpleado;

                    EmpleadosDAO dao = new EmpleadosDAO();
                    if (dao.RecuperarEmpleados(empleado) != null)
                    {
                        MessageBox.Show("Empleado Restaurado!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        public PapeleraEmpleados()
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
            }
        }
    }
}
