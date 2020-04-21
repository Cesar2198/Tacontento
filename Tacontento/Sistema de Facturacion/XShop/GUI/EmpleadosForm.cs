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

namespace XShop.GUI
{
    public partial class EmpleadosForm : Form

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
  
            this.cmbGenero.Items.Add(new ComboItem(1, "MASCULINO"));
            this.cmbGenero.Items.Add(new ComboItem(2, "FEMENINO"));
        }




        private void CargarRegistros()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.TODOS_LOS_EMPLEADOS();
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
                    _DATOS.Filter = "Nombres LIKE '%" + this.txbFiltro.Text + "%' ";
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



        public EmpleadosForm()
        {

            InitializeComponent();
            SetCombobox();
            CargarRegistros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(this.txbId);
            Lista.Add(this.txbNombres);
            Lista.Add(this.txbApellido);
            Lista.Add(this.txbDUI);
            Lista.Add(this.txbNIT);
            Lista.Add(this.txbDireccion);
           

            ////CLS.Utility.textBoxIsEmpty(this.txbDescripcion);
            if (CLS.Utility.textBoxIsEmpty(Lista) && this.cmbGenero.Text != String.Empty && dtPicker.Text != String.Empty)
            {
                
                Empleados empleado = new Empleados();
                ComboItem item = this.cmbGenero.SelectedItem as ComboItem;

                empleado.Nombres = this.txbNombres.Text;
                empleado.Apellidos = this.txbApellido.Text;
                empleado.DUI = this.txbDUI.Text;
                empleado.NIT = this.txbNIT.Text;
                empleado.Direccion = this.txbDireccion.Text;
                empleado.FechaNacimiento = dtPicker.Text;
                empleado.Genero = item.Key;
                EmpleadosDAO dao = new EmpleadosDAO();


                if (dao.CrearEmpleado(empleado) != null)
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
                string Nombres = dtgDatos.SelectedRows[0].Cells[1].Value + string.Empty;
                string Apellidos = dtgDatos.SelectedRows[0].Cells[2].Value + string.Empty;
                String DUI = dtgDatos.SelectedRows[0].Cells[3].Value + string.Empty;
                String NIT = dtgDatos.SelectedRows[0].Cells[4].Value + string.Empty;
                String Direccion = dtgDatos.SelectedRows[0].Cells[5].Value + string.Empty;
                String Genero = dtgDatos.SelectedRows[0].Cells[6].Value + string.Empty;
                String Fecha = dtgDatos.SelectedRows[0].Cells[7].Value + string.Empty;

                txbNombres.Text = Nombres;
                txbApellido.Text= Apellidos;
                txbDUI.Text = DUI;
                txbNIT.Text = NIT;
                txbDireccion.Text = Direccion;
                dtPicker.Text = Fecha;
                txbId.Text = Id;
                this.cmbGenero.SelectedIndex = this.cmbGenero.FindStringExact(Genero);

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(this.txbId);
            Lista.Add(this.txbNombres);
            Lista.Add(this.txbApellido);
            Lista.Add(this.txbDUI);
            Lista.Add(this.txbNIT);
            Lista.Add(this.txbDireccion);

            if (CLS.Utility.textBoxIsEmpty(Lista) && this.cmbGenero.Text != String.Empty)
            {
                if (MessageBox.Show("Desea Editar el registro seleccionado?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    Empleados empleado = new Empleados();
                    ComboItem item = this.cmbGenero.SelectedItem as ComboItem;
                    empleado.idEmpleado = int.Parse(this.txbId.Text);
                    empleado.Nombres = this.txbNombres.Text;
                    empleado.Apellidos = this.txbApellido.Text;
                    empleado.DUI = this.txbDUI.Text;
                    empleado.NIT = this.txbNIT.Text;
                    empleado.Direccion = this.txbDireccion.Text;
                    empleado.FechaNacimiento = dtPicker.Text;
                    empleado.Genero = item.Key;

                    EmpleadosDAO dao = new EmpleadosDAO();
                    try
                    {
                        if (dao.Modificar(empleado) != null)
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
                    this.cmbGenero.Text = "";
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
            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(this.txbId);
            Lista.Add(this.txbNombres);
            Lista.Add(this.txbApellido);
            Lista.Add(this.txbDUI);
            Lista.Add(this.txbNIT);
            Lista.Add(this.txbDireccion);

            if (CLS.Utility.textBoxIsEmpty(Lista) && this.cmbGenero.Text != String.Empty && dtPicker.Text != String.Empty)
            {

                if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Empleados f = new Empleados();
                    f.idEmpleado = int.Parse(this.txbId.Text);

                    EmpleadosDAO dao = new EmpleadosDAO();
                    try
                    {
                        if (dao.Eliminar(f) != null)
                        {
                            CLS.Utility.ClearTextbox(Lista);

                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un Error! Verifique sus Datos.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }

                }
                else
                {
                    CLS.Utility.ClearTextbox(Lista);
                    this.cmbGenero.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los Campos", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            CargarRegistros();
        }

        private void dtgDatos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbPrecio_KeyPress(object sender, KeyPressEventArgs v)
        {
           

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(this.txbId);
            Lista.Add(this.txbNombres);
            Lista.Add(this.txbApellido);
            Lista.Add(this.txbDUI);
            Lista.Add(this.txbNIT);
            Lista.Add(this.txbDireccion);

            CLS.Utility.ClearTextbox(Lista);
            txbFiltro.Text = string.Empty;
        }

        private void OrdenesForm_KeyUp(object sender, KeyEventArgs e)
        {


        }
       
        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        } 
    }
}
