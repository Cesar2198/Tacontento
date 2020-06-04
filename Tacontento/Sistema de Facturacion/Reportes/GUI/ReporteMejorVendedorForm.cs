using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes.GUI
{
    public partial class ReporteMejorVendedorForm : Form
    {
        int anioReporte;
        int mes;
        string mesReporte;

        int lx, ly;
        int sw, sh;

        public void Generar()
        {
            REP.MejorVendedor Reporte = new REP.MejorVendedor();
            Reporte.SetDataSource(CacheManager.CLS.Cache.MejorVendedor(anioReporte,mes));
            Reporte.SetParameterValue("PMes", mesReporte.ToUpper());
            Reporte.SetParameterValue("pAnio",anioReporte.ToString()); 
            crpVisorMejores.ReportSource = Reporte;
        }

        public void pantallaCompleta()
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }



        private void ReporteVentasAnioForm_Load(object sender, EventArgs e)
        {
            pantallaCompleta();
        }

       

        public ReporteMejorVendedorForm(int anio, int mes,string nombremes)
        {
            this.anioReporte = anio;
            this.mes = mes;
            this.mesReporte = nombremes;
            InitializeComponent();
            Generar();
        }
    }
}
