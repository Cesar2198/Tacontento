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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardForm));
            this.btnNew = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtgPedidos = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantidadOrdenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIncidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotalPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIncidente = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblConteo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txbidPedido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 41);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(114, 35);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nuevo Pedido";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(210, 41);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(129, 35);
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
            this.dtgPedidos.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cCliente,
            this.cCantidadOrdenes,
            this.cTotal,
            this.cIncidente,
            this.cTotalPagar});
            this.dtgPedidos.Location = new System.Drawing.Point(12, 150);
            this.dtgPedidos.MultiSelect = false;
            this.dtgPedidos.Name = "dtgPedidos";
            this.dtgPedidos.ReadOnly = true;
            this.dtgPedidos.RowHeadersVisible = false;
            this.dtgPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPedidos.Size = new System.Drawing.Size(740, 400);
            this.dtgPedidos.TabIndex = 2;
            this.dtgPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPedidos_CellClick);
            // 
            // cID
            // 
            this.cID.HeaderText = "ID PEDIDO";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            // 
            // cCliente
            // 
            this.cCliente.HeaderText = "CLIENTE";
            this.cCliente.Name = "cCliente";
            this.cCliente.ReadOnly = true;
            // 
            // cCantidadOrdenes
            // 
            this.cCantidadOrdenes.HeaderText = "CANTIDAD ORDENES";
            this.cCantidadOrdenes.Name = "cCantidadOrdenes";
            this.cCantidadOrdenes.ReadOnly = true;
            // 
            // cTotal
            // 
            this.cTotal.HeaderText = "TOTAL";
            this.cTotal.Name = "cTotal";
            this.cTotal.ReadOnly = true;
            // 
            // cIncidente
            // 
            this.cIncidente.HeaderText = "COBRO DE INCIDENTE";
            this.cIncidente.Name = "cIncidente";
            this.cIncidente.ReadOnly = true;
            // 
            // cTotalPagar
            // 
            this.cTotalPagar.HeaderText = "TOTAL A PAGAR";
            this.cTotalPagar.Name = "cTotalPagar";
            this.cTotalPagar.ReadOnly = true;
            // 
            // btnIncidente
            // 
            this.btnIncidente.Location = new System.Drawing.Point(427, 41);
            this.btnIncidente.Name = "btnIncidente";
            this.btnIncidente.Size = new System.Drawing.Size(133, 35);
            this.btnIncidente.TabIndex = 3;
            this.btnIncidente.Text = "Agregar Incidente";
            this.btnIncidente.UseVisualStyleBackColor = true;
            this.btnIncidente.Click += new System.EventHandler(this.btnIncidente_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(637, 41);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(115, 35);
            this.btnFacturar.TabIndex = 4;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblConteo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 585);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(764, 33);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblConteo
            // 
            this.lblConteo.Name = "lblConteo";
            this.lblConteo.Size = new System.Drawing.Size(133, 28);
            this.lblConteo.Text = "0 Registros Encontrados";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(764, 31);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel2.Image")));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(153, 28);
            this.toolStripLabel2.Text = "Manejo de Pedidos";
            // 
            // txbidPedido
            // 
            this.txbidPedido.Location = new System.Drawing.Point(651, 118);
            this.txbidPedido.Name = "txbidPedido";
            this.txbidPedido.Size = new System.Drawing.Size(100, 20);
            this.txbidPedido.TabIndex = 24;
            this.txbidPedido.Visible = false;
            // 
            // dashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 618);
            this.Controls.Add(this.txbidPedido);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnIncidente);
            this.Controls.Add(this.dtgPedidos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboardForm";
            this.Text = "dashboardForm";
            this.Load += new System.EventHandler(this.dashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dtgPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantidadOrdenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIncidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotalPagar;
        private System.Windows.Forms.Button btnIncidente;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblConteo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TextBox txbidPedido;
    }
}