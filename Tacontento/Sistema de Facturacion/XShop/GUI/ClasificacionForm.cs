using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Entidades.ClasificacionOrden;
using Entidades.Entidades.Roles;
using XShop.GUI_AUXILIAR;

namespace XShop.GUI
{
    public partial class ClasificacionForm : Form
    {
        BindingSource _DATOS = new BindingSource();

        public void CargarRegistros()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.TODAS_LAS_CLASIFCACIONES();
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
                    _DATOS.Filter = "clasificacionOrden LIKE '%" + this.txbFiltro.Text + "%' ";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgDatos.AutoGenerateColumns = false;
                dtgDatos.DataSource = _DATOS;
                this.lblRegistros.Text = dtgDatos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {


            }
        }

        public ClasificacionForm()
        {
            InitializeComponent();
            CargarRegistros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

                List<TextBox> Lista = new List<TextBox>();
                Lista.Add(this.txbId);
                Lista.Add(this.txbNombre);


                if (CLS.Utility.textBoxIsEmpty(Lista))
                {
                    ClasificacionesOrdenes Cla = new ClasificacionesOrdenes();
                   
                    Cla.ClasificacionOrden = this.txbNombre.Text;

                    ClasificacionesOrdenesDAO dao = new ClasificacionesOrdenesDAO();


                    if (dao.InsertarClasificacion(Cla) != null)
                    {

                        CLS.Utility.ClearTextbox(Lista);
                        CargarRegistros();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un Error!", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Rellene todos los Campos", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                CargarRegistros();

        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(this.txbId);
            Lista.Add(this.txbNombre);

            if (CLS.Utility.textBoxIsEmpty(Lista))
            {
                if (MessageBox.Show("Desea Editar el registro seleccionado?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    ClasificacionesOrdenes Cla = new ClasificacionesOrdenes();
                    Cla.IdClasificacionOrden = int.Parse(this.txbId.Text);
                    Cla.ClasificacionOrden = this.txbNombre.Text;

                    ClasificacionesOrdenesDAO dao = new ClasificacionesOrdenesDAO();
                    try
                    {
                        if (dao.ModificarClasificacion(Cla) != null)
                        {
                            CLS.Utility.ClearTextbox(Lista);
                            CargarRegistros();
                        }
                    }
                    catch (Exception eh)
                    {
                        MessageBox.Show("Ocurrió un Error!" + eh, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }

                }
                else
                {
                    CLS.Utility.ClearTextbox(Lista);
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los Campos", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            CargarRegistros();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            List<TextBox> List = new List<TextBox>();
            List.Add(this.txbId);
            List.Add(this.txbNombre);

            CLS.Utility.ClearTextbox(List);
            txbFiltro.Text = string.Empty;
        }

        private void txbFiltro_Click(object sender, EventArgs e)
        {

        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void dtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgDatos.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                ///Esto, cuando se selecciona una fila rellena los textbox y el combobox
                ///son strings ya que el textbox solo eso detecta 
                String Id = dtgDatos.SelectedRows[0].Cells[0].Value + string.Empty;
                string Nombre = dtgDatos.SelectedRows[0].Cells[1].Value + string.Empty;

                txbId.Text = Id;
                txbNombre.Text = Nombre;
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(this.txbId);
            Lista.Add(this.txbNombre);
            if (CLS.Utility.textBoxIsEmpty(Lista))
            {

                if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClasificacionesOrdenes cla = new ClasificacionesOrdenes();
                    cla.IdClasificacionOrden = int.Parse(this.txbId.Text);

                    ClasificacionesOrdenesDAO dao = new ClasificacionesOrdenesDAO();
                    try
                    {
                        if (dao.EliminarClasificacion(cla) != null)
                        {
                            CLS.Utility.ClearTextbox(Lista);

                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un Error!", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }

                }
                else
                {
                    CLS.Utility.ClearTextbox(Lista);
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los Campos", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            CargarRegistros();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PapeleraClasificaciones f = new PapeleraClasificaciones();
            f.ShowDialog();
        }
    }
}
