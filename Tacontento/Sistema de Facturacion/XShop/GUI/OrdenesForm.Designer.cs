namespace XShop.GUI
{
    partial class OrdenesForm
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
            this.cmbIdClasificacion = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbIdClasificacion
            // 
            this.cmbIdClasificacion.FormattingEnabled = true;
            this.cmbIdClasificacion.Location = new System.Drawing.Point(520, 25);
            this.cmbIdClasificacion.Name = "cmbIdClasificacion";
            this.cmbIdClasificacion.Size = new System.Drawing.Size(121, 21);
            this.cmbIdClasificacion.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(703, 415);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(344, 25);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(116, 67);
            this.txbDescripcion.TabIndex = 8;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(189, 25);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(100, 20);
            this.txbPrecio.TabIndex = 7;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(46, 25);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 6;
            // 
            // OrdenesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbIdClasificacion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdenesForm";
            this.Text = "OrdenesForm";
            this.Load += new System.EventHandler(this.OrdenesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIdClasificacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.TextBox txbNombre;
    }
}