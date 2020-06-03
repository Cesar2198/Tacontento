namespace Reportes.GUI
{
    partial class ReporteVentasMesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentasMesForm));
            this.crpVisorMes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpVisorMes
            // 
            this.crpVisorMes.ActiveViewIndex = -1;
            this.crpVisorMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpVisorMes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpVisorMes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpVisorMes.Location = new System.Drawing.Point(0, 0);
            this.crpVisorMes.Name = "crpVisorMes";
            this.crpVisorMes.Size = new System.Drawing.Size(748, 587);
            this.crpVisorMes.TabIndex = 0;
            // 
            // ReporteVentasMesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 587);
            this.Controls.Add(this.crpVisorMes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteVentasMesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Ventas Mes";
            this.Load += new System.EventHandler(this.ReporteVentasAnioForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpVisorMes;
    }
}