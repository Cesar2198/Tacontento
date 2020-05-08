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
            this.dtgPedidos = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantidadOrdenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).BeginInit();
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
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dtgPedidos
            // 
            this.dtgPedidos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtgPedidos.AllowUserToAddRows = false;
            this.dtgPedidos.AllowUserToDeleteRows = false;
            this.dtgPedidos.AllowUserToResizeColumns = false;
            this.dtgPedidos.AllowUserToResizeRows = false;
            this.dtgPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dtgPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cCliente,
            this.cCantidadOrdenes,
            this.cTotal});
            this.dtgPedidos.Location = new System.Drawing.Point(29, 150);
            this.dtgPedidos.MultiSelect = false;
            this.dtgPedidos.Name = "dtgPedidos";
            this.dtgPedidos.RowHeadersVisible = false;
            this.dtgPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPedidos.Size = new System.Drawing.Size(699, 261);
            this.dtgPedidos.TabIndex = 2;
            // 
            // cID
            // 
            this.cID.HeaderText = "ID PEDIDO";
            this.cID.Name = "cID";
            // 
            // cCliente
            // 
            this.cCliente.HeaderText = "CLIENTE";
            this.cCliente.Name = "cCliente";
            // 
            // cCantidadOrdenes
            // 
            this.cCantidadOrdenes.HeaderText = "CANTIDAD ORDENES";
            this.cCantidadOrdenes.Name = "cCantidadOrdenes";
            // 
            // cTotal
            // 
            this.cTotal.HeaderText = "TOTAL";
            this.cTotal.Name = "cTotal";
            // 
            // dashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 618);
            this.Controls.Add(this.dtgPedidos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboardForm";
            this.Text = "dashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dtgPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantidadOrdenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
    }
}