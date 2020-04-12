namespace XShop.GUI
{
    partial class dashboardForm
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(50, 41);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(114, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nuevo Pedido";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(188, 41);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(129, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar Pedido";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // dashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 618);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboardForm";
            this.Text = "dashboardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnModificar;
    }
}