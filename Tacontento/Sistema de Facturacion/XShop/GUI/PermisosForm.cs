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
using Entidades.Entidades.Roles;
using Entidades.Entidades.Usuarios;
using Microsoft.VisualBasic;
using System.Security.Cryptography;
using Entidades.Entidades.Empleados;
using Cache.GUI;
using Entidades.Entidades.Permisos;
using Entidades.Entidades.Permiso;

namespace XShop.GUI
{
    public partial class PermisosForm : Form

    {

        BindingSource _DATOS = new BindingSource();

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

        private void SetCombobox()
        {
            RolesDAO dao = new RolesDAO();

            for (int i = 0; i < dao.getRol().Count; i++)
            {
                int id = dao.getRol()[i].idRol;
                string nombre = dao.getRol()[i].RolName;

                this.cmbRol.Items.Add(new ComboItem(id, nombre));
            }
        }

        private void setComboBox2()
        {
            OpcionDAO dao2 = new OpcionDAO();

            for (int i = 0; i < dao2.getOpcion().Count; i++)
            {
                int id2 = dao2.getOpcion()[i].idOpcion;
                string nombre2 = dao2.getOpcion()[i].NombreOpcion;

                this.cmbOpciones.Items.Add(new ComboItem(id2, nombre2));
            }
        }


        public void CargarRegistros()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.TODAS_LAS_OPCIONES();
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
                    _DATOS.Filter = "rol LIKE '%" + this.txbFiltro.Text + "%' ";
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



        public PermisosForm()
        {
            InitializeComponent();
            SetCombobox();
            setComboBox2();
            CargarRegistros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            ////CLS.Utility.textBoxIsEmpty(this.txbDescripcion);
            if (this.cmbRol.Text != String.Empty && this.cmbOpciones.Text != String.Empty)
            {
                Permisos p = new Permisos();

                ComboItem item = this.cmbRol.SelectedItem as ComboItem;
                ComboItem item2 = this.cmbOpciones.SelectedItem as ComboItem;
                p.idRol = item.Key;
                p.idOpcion = item2.Key;

                PermisosDAO dao = new PermisosDAO();


                if (dao.InsertarPermiso(p) != null)
                {
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
                String IdPermiso = dtgDatos.SelectedRows[0].Cells[0].Value + string.Empty;
                string IdRol = dtgDatos.SelectedRows[0].Cells[1].Value + string.Empty;
                String IdOpcion = dtgDatos.SelectedRows[0].Cells[2].Value + string.Empty;



                txbId.Text = IdPermiso;
                this.cmbRol.SelectedIndex = this.cmbRol.FindStringExact(CLS.Utility.DevolverRolName((IdRol)));
                this.cmbOpciones.SelectedIndex = this.cmbOpciones.FindStringExact(CLS.Utility.DevolverOpcion((IdOpcion)));
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(this.txbId);

            if (CLS.Utility.textBoxIsEmpty(Lista) && this.cmbRol.Text != String.Empty && this.cmbOpciones.Text != String.Empty)
            {
                if (MessageBox.Show("Desea Editar el registro seleccionado?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Permisos p = new Permisos();
                    p.idPermiso = int.Parse(this.txbId.Text);

                    ComboItem item = this.cmbRol.SelectedItem as ComboItem;
                    ComboItem item2 = this.cmbOpciones.SelectedItem as ComboItem;
                    p.idRol = item.Key;
                    p.idOpcion = item2.Key;

                    if (p.idRol == 1)
                    {
                        MessageBox.Show("No se pueden Modificar Los Permisos del Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CLS.Utility.ClearTextbox(Lista);
                        this.cmbRol.Text = "";
                        this.cmbOpciones.Text = "";
                    }
                    else
                    {
                        PermisosDAO dao = new PermisosDAO();
                        try
                        {
                            if (dao.Modificar(p) != null)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dtgDatos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbPrecio_KeyPress(object sender, KeyPressEventArgs v)
        {


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            List<TextBox> List = new List<TextBox>();
            List.Add(this.txbId);


            CLS.Utility.ClearTextbox(List);
            txbFiltro.Text = string.Empty;
            this.cmbRol.Text = "";
            this.cmbOpciones.Text = "";
        }

        private void OrdenesForm_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(this.txbId);

            if (CLS.Utility.textBoxIsEmpty(Lista) && this.cmbRol.Text != String.Empty && this.cmbOpciones.Text != String.Empty)
            {

                if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Permisos f = new Permisos();
                    f.idPermiso = int.Parse(this.txbId.Text);
                    ComboItem item = this.cmbRol.SelectedItem as ComboItem;
                    f.idRol = item.Key;

                    if (f.idRol == 1)
                    {
                        MessageBox.Show("No se pueden Eliminar Los Permisos del Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CLS.Utility.ClearTextbox(Lista);
                        this.cmbRol.Text = "";
                        this.cmbOpciones.Text = "";
                    }
                    else
                    {
                        PermisosDAO dao = new PermisosDAO();
                        try
                        {
                            if (dao.Eliminar(f) != null)
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
    }
}
