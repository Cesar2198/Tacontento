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
    public partial class ReporteVentasAnioForm : Form
    {

        int lx, ly;
        int sw, sh;

        public void Generar()
        {
            REP.VentasporAnio Reporte = new REP.VentasporAnio();
            Reporte.SetDataSource(CacheManager.CLS.Cache.VentasPorAnio());
            crpVisorReporte.ReportSource = Reporte;
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

       

        public ReporteVentasAnioForm()
        {
            InitializeComponent();
            Generar();
        }
    }
}
