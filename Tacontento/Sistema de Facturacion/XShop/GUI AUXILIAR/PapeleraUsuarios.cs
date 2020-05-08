using Entidades.Entidades.Usuarios;
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

namespace Cache.GUI
{
    public partial class PapeleraUsuarios : Form
    {
        BindingSource _DATOS = new BindingSource();
        public Boolean valido = false;
        public enum ACCION { RESTAURAR };
        ACCION _Eleccion = ACCION.RESTAURAR;

        private void CargarRegistros()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Papelera.TODOS_LOS_USUARIOS_ELIMINADOS();
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
                this.lblContador.Text = dtgDatos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public void AccionRealizada()
        {

            try
            {
                int idUsuario;
                idUsuario = int.Parse(dtgDatos.CurrentRow.Cells["idUsuario"].Value.ToString());
                Usuarios user = new Usuarios();
                user.idUsuario = idUsuario;
                UsuarioDAO dao = new UsuarioDAO();
                if (dao.RecuperarUsuario(user) != null)
                {
                    MessageBox.Show("Usuario Restaurado!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }


        public PapeleraUsuarios(ACCION pAccion)
        {
            InitializeComponent();
            CargarRegistros();
            _Eleccion = pAccion;
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (dtgDatos.Rows.Count != 0 && dtgDatos.CurrentCell != null)
            {
                if (_Eleccion == ACCION.RESTAURAR)
                {
                    AccionRealizada();
                    valido = true;
                    this.Close();
                }
                else
                {
                    valido = true;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No se Ha podido Restaurar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PapeleraUsuarios_Load(object sender, EventArgs e)
        {
            dtgDatos.CurrentCell = null;
        }
    }
}
