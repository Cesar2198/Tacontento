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
    public partial class ReporteBitacoraForm : Form
    {
        int anioReporte;

        int lx, ly;
        int sw, sh;

        public void Generar()
        {
            REP.Bitacora Reporte = new REP.Bitacora();
            Reporte.SetDataSource(CacheManager.CLS.Cache.Bitacora(anioReporte));
            Reporte.SetParameterValue("pAnio",anioReporte.ToString());
            crpVisorBitacora.ReportSource = Reporte;
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

       

        public ReporteBitacoraForm(int anio)
        {
            this.anioReporte = anio;
            InitializeComponent();
            Generar();
        }
    }
}
