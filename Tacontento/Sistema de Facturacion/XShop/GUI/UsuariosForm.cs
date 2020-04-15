﻿using System;
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

namespace XShop.GUI
{
    public partial class UsuariosForm : Form

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


      

        

        private void CargarRegistros()
        {

            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.TODOS_LOS_USUARIOS();
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
                    _DATOS.Filter = "usuario LIKE '%" + this.txbFiltro.Text + "%' ";
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


        






        public UsuariosForm()
        {

            InitializeComponent();
            SetCombobox();
            CargarRegistros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(this.txbId);
            Lista.Add(this.txbUsuario);
            Lista.Add(this.txbPassword);
            Lista.Add(this.txbTelefono);

            ////CLS.Utility.textBoxIsEmpty(this.txbDescripcion);
            if (CLS.Utility.textBoxIsEmpty(Lista) && this.cmbRol.Text != String.Empty)
            {
                Usuarios f = new Usuarios();

                f.usuario = this.txbUsuario.Text;
                f.password = this.txbPassword.Text;
                f.telefono = this.txbTelefono.Text;
                f.estado = 1;

                ComboItem item = this.cmbRol.SelectedItem as ComboItem;

                f.rol = item.Key;

                UsuarioDAO dao = new UsuarioDAO();


                if (dao.CrearUsuario(f) != null)
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
                string Nombre = dtgDatos.SelectedRows[0].Cells[1].Value + string.Empty;
                string Password = dtgDatos.SelectedRows[0].Cells[2].Value + string.Empty;
                String Telefono = dtgDatos.SelectedRows[0].Cells[3].Value + string.Empty;
                String Rol = dtgDatos.SelectedRows[0].Cells[4].Value + string.Empty;

                txbUsuario.Text = Nombre;
                txbPassword.Text= Password;
                txbTelefono.Text = Telefono;
                txbId.Text = Id;///Con esto buscas el valor de un combobox y lo ubicas, asi.
                this.cmbRol.SelectedIndex = this.cmbRol.FindStringExact(CLS.Utility.DevolverRol(int.Parse(Rol)));
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(this.txbId);
            Lista.Add(this.txbUsuario);
            Lista.Add(this.txbPassword);
            Lista.Add(this.txbTelefono);

            if (CLS.Utility.textBoxIsEmpty(Lista) && this.cmbRol.Text != String.Empty)
            {
                if (MessageBox.Show("Desea Editar el registro seleccionado?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Usuarios f = new Usuarios();
                    f.idUsuario =int.Parse(this.txbId.Text);
                    f.usuario = this.txbUsuario.Text;
                    f.password = this.txbPassword.Text;
                    f.telefono = this.txbTelefono.Text;
                    var x = (ComboItem)this.cmbRol.Items[this.cmbRol.SelectedIndex] as ComboItem;
                    f.rol = x.Key;
                    f.estado = 1;

                    UsuarioDAO dao = new UsuarioDAO();
                    try
                    {
                        if (dao.Modificar(f) != null)
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
                    this.cmbRol.Text = "";
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
            Lista.Add(this.txbUsuario);
            Lista.Add(this.txbPassword);
            Lista.Add(this.txbTelefono);

            if (CLS.Utility.textBoxIsEmpty(Lista) && this.cmbRol.Text != String.Empty)
            {

                if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Usuarios f = new Usuarios();
                    f.idUsuario = int.Parse(this.txbId.Text);

                    UsuarioDAO dao = new UsuarioDAO();
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
                else
                {
                    CLS.Utility.ClearTextbox(Lista);
                    this.cmbRol.Text = "";
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
            List<TextBox> List = new List<TextBox>();
            List.Add(this.txbId);
            List.Add(this.txbUsuario);
            List.Add(this.txbPassword);
            List.Add(this.txbTelefono);

            CLS.Utility.ClearTextbox(List);
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