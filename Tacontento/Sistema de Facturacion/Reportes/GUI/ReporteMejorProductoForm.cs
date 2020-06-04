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
    public partial class ReporteMejorProductoForm : Form
    {
        int anioReporte;
        int mes;
        string mesReporte;

        int lx, ly;
        int sw, sh;

        public void Generar()
        {
            REP.MejorProducto Reporte = new REP.MejorProducto();
            Reporte.SetDataSource(CacheManager.CLS.Cache.MejorProducto(anioReporte,mes));
            Reporte.SetParameterValue("PMes", mesReporte.ToUpper());
            Reporte.SetParameterValue("pAnio",anioReporte.ToString()); 
            crpVisorMejoresProductos.ReportSource = Reporte;
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

       

        public ReporteMejorProductoForm(int anio, int mes,string nombremes)
        {
            this.anioReporte = anio;
            this.mes = mes;
            this.mesReporte = nombremes;
            InitializeComponent();
            Generar();
        }
    }
}
