namespace Reportes.GUI
{
    partial class ReporteMejorProductoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteMejorProductoForm));
            this.crpVisorMejoresProductos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpVisorMejoresProductos
            // 
            this.crpVisorMejoresProductos.ActiveViewIndex = -1;
            this.crpVisorMejoresProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpVisorMejoresProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpVisorMejoresProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpVisorMejoresProductos.Location = new System.Drawing.Point(0, 0);
            this.crpVisorMejoresProductos.Name = "crpVisorMejoresProductos";
            this.crpVisorMejoresProductos.Size = new System.Drawing.Size(748, 587);
            this.crpVisorMejoresProductos.TabIndex = 0;
            // 
            // ReporteMejorProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 587);
            this.Controls.Add(this.crpVisorMejoresProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteMejorProductoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Mejores Productos";
            this.Load += new System.EventHandler(this.ReporteVentasAnioForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpVisorMejoresProductos;
    }
}