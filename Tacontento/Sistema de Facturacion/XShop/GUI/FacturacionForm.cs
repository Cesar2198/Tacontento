using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XShop.GUI
{
    public partial class FacturacionForm : Form
    {
        private int idpedido;
        private dashboardForm df;
        private decimal total1;
        private decimal monto;
        public FacturacionForm(int id, decimal total, dashboardForm d)
        {
            idpedido = id;
            df = d;
            total1 = total;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Facturar Realmente? ", "Pregunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
            else
            {
                this.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal TotalVuelto;
            if (this.txbMonto.Text == string.Empty || this.txbMonto.Text == " ")
            {
                this.monto = 0;

                TotalVuelto = this.monto - this.total1;

                this.lblVuelto.Text = "Cambio: $ " + 0;
            }
            else
            {
               
                monto = decimal.Parse(this.txbMonto.Text);

                TotalVuelto = this.monto - this.total1;

                this.lblVuelto.Text = "Cambio: $ " + TotalVuelto.ToString();
            }

        }

        private void FacturacionForm_Load(object sender, EventArgs e)
        {
            this.txbTotal.Text = this.total1.ToString();
            this.lblid.Text = "Pedido C"+this.idpedido.ToString();
        }

        private void txbMonto_KeyDown(object sender, KeyEventArgs e)
        {
            decimal TotalVuelto;
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txbMonto.Text == string.Empty || this.txbMonto.Text == " ")
                {
                    this.monto = 0;
                    TotalVuelto = this.monto - this.total1;

                    this.lblVuelto.Text = "Cambio: $ " + 0;
                }
                else
                {
                    
                    monto = decimal.Parse(this.txbMonto.Text);

                    TotalVuelto = this.monto - this.total1;

                    this.lblVuelto.Text = "Cambio: $ " + TotalVuelto.ToString();

                }
            }
        }

        private void txbMonto_KeyPress(object sender, KeyPressEventArgs v)
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
    }
}
