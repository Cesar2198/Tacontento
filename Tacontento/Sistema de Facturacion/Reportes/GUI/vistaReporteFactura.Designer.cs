namespace Reportes.GUI
{
    partial class vistaReporteFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vistaReporteFactura));
            this.crpFactura = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpFactura
            // 
            this.crpFactura.ActiveViewIndex = -1;
            this.crpFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpFactura.Location = new System.Drawing.Point(0, 0);
            this.crpFactura.Name = "crpFactura";
            this.crpFactura.Size = new System.Drawing.Size(800, 450);
            this.crpFactura.TabIndex = 0;
            this.crpFactura.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // vistaReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crpFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vistaReporteFactura";
            this.Text = "VISTA PREVIA DE FACTURA";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpFactura;
    }
}