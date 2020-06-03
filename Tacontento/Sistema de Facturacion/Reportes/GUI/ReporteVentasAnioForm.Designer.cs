namespace Reportes.GUI
{
    partial class ReporteVentasAnioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentasAnioForm));
            this.crpVisorReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpVisorReporte
            // 
            this.crpVisorReporte.ActiveViewIndex = -1;
            this.crpVisorReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpVisorReporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpVisorReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpVisorReporte.Location = new System.Drawing.Point(0, 0);
            this.crpVisorReporte.Name = "crpVisorReporte";
            this.crpVisorReporte.Size = new System.Drawing.Size(748, 587);
            this.crpVisorReporte.TabIndex = 0;
            // 
            // ReporteVentasAnioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 587);
            this.Controls.Add(this.crpVisorReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteVentasAnioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Ventas por Año";
            this.Load += new System.EventHandler(this.ReporteVentasAnioForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpVisorReporte;
    }
}