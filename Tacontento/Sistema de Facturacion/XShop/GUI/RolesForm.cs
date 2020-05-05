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
    public partial class RolesForm : Form
    {
        BindingSource _DATOS = new BindingSource();

        public void CargarRegistros()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.TODOS_LOS_ROLES();
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
                this.lblRegistros.Text = dtgDatos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {


            }
        }




        public RolesForm()
        {
            InitializeComponent();
            CargarRegistros();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dtgDatos.Rows.Count < 10){

                List<TextBox> Lista = new List<TextBox>();
                Lista.Add(this.txbId);
                Lista.Add(this.txbNombre);
                Lista.Add(this.txbDescripcion);

                if (CLS.Utility.textBoxIsEmpty(Lista))
                {
                    Rol r = new Rol();

                    r.RolName = this.txbNombre.Text;
                    r.Descripcion = this.txbDescripcion.Text;
                    r.estado = 1;

                    RolesDAO dao = new RolesDAO();


                    if (dao.InsertarRol(r) != null)
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
            else
            {
                MessageBox.Show("Solamente se permiten 10 Roles", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                CargarRegistros();
            }
            
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(this.txbId);
            Lista.Add(this.txbNombre);
            Lista.Add(this.txbDescripcion);

            if (CLS.Utility.textBoxIsEmpty(Lista))
            {
                if (MessageBox.Show("Desea Editar el registro seleccionado?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Rol r = new Rol();
                    r.idRol = int.Parse(this.txbId.Text);
                    r.RolName = this.txbNombre.Text;
                    r.Descripcion = this.txbDescripcion.Text;
                    r.estado = 1;

                    RolesDAO dao = new RolesDAO();
                    try
                    {
                        if (dao.Modificar(r) != null)
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
            List.Add(this.txbDescripcion);

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
                string Descripcion = dtgDatos.SelectedRows[0].Cells[2].Value + string.Empty;

                txbId.Text = Id;
                txbNombre.Text = Nombre;
                txbDescripcion.Text = Descripcion;
                
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }
    }
}
