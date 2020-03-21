namespace XShop.GUI
{
    partial class PruebaConector
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
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.txbConsulta = new System.Windows.Forms.TextBox();
            this.btnDatos = new System.Windows.Forms.Button();
            this.txbSentencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSentencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Location = new System.Drawing.Point(574, 34);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(514, 150);
            this.dtgDatos.TabIndex = 0;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(12, 9);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(48, 13);
            this.lblConsulta.TabIndex = 1;
            this.lblConsulta.Text = "Consulta";
            // 
            // txbConsulta
            // 
            this.txbConsulta.Location = new System.Drawing.Point(12, 34);
            this.txbConsulta.Multiline = true;
            this.txbConsulta.Name = "txbConsulta";
            this.txbConsulta.Size = new System.Drawing.Size(543, 119);
            this.txbConsulta.TabIndex = 2;
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(441, 161);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(114, 23);
            this.btnDatos.TabIndex = 3;
            this.btnDatos.Text = "Consultar";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // txbSentencia
            // 
            this.txbSentencia.Location = new System.Drawing.Point(12, 315);
            this.txbSentencia.Multiline = true;
            this.txbSentencia.Name = "txbSentencia";
            this.txbSentencia.Size = new System.Drawing.Size(543, 119);
            this.txbSentencia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sentencia";
            // 
            // btnSentencia
            // 
            this.btnSentencia.Location = new System.Drawing.Point(441, 442);
            this.btnSentencia.Name = "btnSentencia";
            this.btnSentencia.Size = new System.Drawing.Size(114, 23);
            this.btnSentencia.TabIndex = 6;
            this.btnSentencia.Text = "Ejecutar";
            this.btnSentencia.UseVisualStyleBackColor = true;
            this.btnSentencia.Click += new System.EventHandler(this.btnSentencia_Click);
            // 
            // PruebaConector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 580);
            this.Controls.Add(this.btnSentencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSentencia);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.txbConsulta);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.dtgDatos);
            this.Name = "PruebaConector";
            this.Text = "PruebaConector";
            this.Load += new System.EventHandler(this.PruebaConector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.TextBox txbConsulta;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.TextBox txbSentencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSentencia;
    }
}