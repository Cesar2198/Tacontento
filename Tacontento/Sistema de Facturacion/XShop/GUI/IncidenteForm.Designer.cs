namespace XShop.GUI
{
    partial class IncidenteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCobro = new System.Windows.Forms.TextBox();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agrega el cobro $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Describe el incidente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbCobro
            // 
            this.txbCobro.Location = new System.Drawing.Point(127, 28);
            this.txbCobro.Name = "txbCobro";
            this.txbCobro.Size = new System.Drawing.Size(109, 20);
            this.txbCobro.TabIndex = 2;
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(24, 103);
            this.txbDesc.Multiline = true;
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(212, 51);
            this.txbDesc.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(24, 186);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 36);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IncidenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 234);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txbDesc);
            this.Controls.Add(this.txbCobro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IncidenteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Incidentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCobro;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button2;
    }
}