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
using CacheManager.CLS;
using Entidades.Entidades.Ordenes;
using Microsoft.VisualBasic;
using XShop.GUI_AUXILIAR;

namespace XShop.GUI
{
    public partial class OrdenesForm : Form

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

        public void CargarRegistros()
        {

            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.TODOS_LAS_ORDENES();
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

        public void setComboBox()
        {
            OrdenDAO orden = new OrdenDAO();
            for (int i = 0; i < orden.getClasificacionesOrdenes().Count; i++)
            {
                int id = orden.getClasificacionesOrdenes()[i].idClasificacion;
                string nombre = orden.getClasificacionesOrdenes()[i].nombre;

                this.cmbIdClasificacion.Items.Add(new ComboItem(id, nombre));
            }
        }


        public OrdenesForm()
        {

            InitializeComponent();
            txbId.Visible = false;
            setComboBox();
            CargarRegistros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(this.txbId);
            Lista.Add(this.txbNombre);
            Lista.Add(this.txbDescripcion);
            Lista.Add(this.txbPrecio);

            ////CLS.Utility.textBoxIsEmpty(this.txbDescripcion);
            if (CLS.Utility.textBoxIsEmpty(Lista) && this.cmbIdClasificacion.Text != String.Empty)
            {
                Ordenes orden = new Ordenes();
                orden.nombre = this.txbNombre.Text;
                orden.precio = Convert.ToDecimal(this.txbPrecio.Text);
                orden.descripcion = this.txbDescripcion.Text;

                ComboItem item = this.cmbIdClasificacion.SelectedItem as ComboItem;

                orden.idClasificacion = item.Key;

                OrdenDAO dao = new OrdenDAO();


                if (dao.InsertarOrden(orden) != null)
                {
                    CLS.Utility.ClearTextbox(Lista);
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
                string Descripcion = dtgDatos.SelectedRows[0].Cells[3].Value + string.Empty;
                String precio = dtgDatos.SelectedRows[0].Cells[2].Value + string.Empty;
                String Clasificacion = dtgDatos.SelectedRows[0].Cells[4].Value + string.Empty;

                txbNombre.Text = Nombre;
                txbDescripcion.Text = Descripcion;
                txbPrecio.Text = precio;
                txbId.Text = Id;///Con esto buscas el valor de un combobox y lo ubicas, asi.
                this.cmbIdClasificacion.SelectedIndex = this.cmbIdClasificacion.FindStringExact(CLS.Utility.DevolverClasificacion(int.Parse(Clasificacion)));
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(this.txbId);
            Lista.Add(this.txbNombre);
            Lista.Add(this.txbDescripcion);
            Lista.Add(this.txbPrecio);

            if (CLS.Utility.textBoxIsEmpty(Lista) && this.cmbIdClasificacion.Text != String.Empty)
            {
                if (MessageBox.Show("Desea Editar el registro seleccionado?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Ordenes _orden = new Ordenes();
                    _orden.idOrden = int.Parse(this.txbId.Text);
                    _orden.nombre = this.txbNombre.Text;
                    _orden.descripcion = this.txbDescripcion.Text;
                    _orden.precio = decimal.Parse(this.txbPrecio.Text);
                    var x = (ComboItem)this.cmbIdClasificacion.Items[this.cmbIdClasificacion.SelectedIndex] as ComboItem;
                    _orden.idClasificacion = x.Key;


                    OrdenDAO dao = new OrdenDAO();
                    try
                    {
                        if (dao.Modificar(_orden) != null)
                        {
                            CLS.Utility.ClearTextbox(Lista);

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
                    this.cmbIdClasificacion.Text = "";
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
            Lista.Add(this.txbNombre);
            Lista.Add(this.txbDescripcion);
            Lista.Add(this.txbPrecio);
            if (CLS.Utility.textBoxIsEmpty(Lista) && this.cmbIdClasificacion.Text != String.Empty)
            {

                if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Ordenes orden = new Ordenes();
                    orden.idOrden = int.Parse(this.txbId.Text);

                    OrdenDAO dao = new OrdenDAO();
                    try
                    {
                        if (dao.Eliminar(orden) != null)
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
                    this.cmbIdClasificacion.Text = "";
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
            else if (v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            List<TextBox> List = new List<TextBox>();
            List.Add(this.txbNombre);
            List.Add(this.txbPrecio);
            List.Add(this.txbDescripcion);
            List.Add(this.txbId);

            CLS.Utility.ClearTextbox(List);
        }

        private void OrdenesForm_KeyUp(object sender, KeyEventArgs e)
        {


            ///Se crea una vista y esta se filtra y se iguala con un String que lleva un predeterminado formato
           /// _DATOS.DefaultView.RowFilter = string.Format("cNombre like '%{0}%'", txbFiltro.Text);
            ///Refrescamos cada vez que se hace una busqueda
            ///dtgDatos.Refresh();

        }
       
        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {}

        private void btnPapeleraOrden_Click(object sender, EventArgs e)
        {
            PapeleraOrden f = new PapeleraOrden(PapeleraOrden.ACCION.RESTAURAR);
            f.ShowDialog();

            if (f.valido)
            {
                CargarRegistros();
            }
            else
            {
                CargarRegistros();
            }
        }

        private void txbPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
