namespace XShop.GUI
{
    partial class Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.dtgPedido = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.cmbPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEmpleado = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPago = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCantidadOrdenes = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbIndex = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedido)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgPedido
            // 
            this.dtgPedido.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtgPedido.AllowUserToAddRows = false;
            this.dtgPedido.AllowUserToDeleteRows = false;
            this.dtgPedido.AllowUserToResizeColumns = false;
            this.dtgPedido.AllowUserToResizeRows = false;
            this.dtgPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPedido.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cOrden,
            this.cPrecio,
            this.cCantidad,
            this.cSubtotal});
            this.dtgPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPedido.Location = new System.Drawing.Point(0, 0);
            this.dtgPedido.MultiSelect = false;
            this.dtgPedido.Name = "dtgPedido";
            this.dtgPedido.RowHeadersVisible = false;
            this.dtgPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPedido.Size = new System.Drawing.Size(699, 261);
            this.dtgPedido.TabIndex = 0;
            this.dtgPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPedido_CellClick);
            this.dtgPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPedido_CellContentClick);
            this.dtgPedido.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPedido_CellContentDoubleClick);
            this.dtgPedido.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPedido_CellEndEdit);
            this.dtgPedido.SelectionChanged += new System.EventHandler(this.dtgPedido_SelectionChanged);
            // 
            // cID
            // 
            this.cID.HeaderText = "ID ORDEN";
            this.cID.Name = "cID";
            // 
            // cOrden
            // 
            this.cOrden.HeaderText = "ORDEN";
            this.cOrden.Name = "cOrden";
            // 
            // cPrecio
            // 
            this.cPrecio.HeaderText = "PRECIO";
            this.cPrecio.Name = "cPrecio";
            // 
            // cCantidad
            // 
            this.cCantidad.HeaderText = "CANTIDAD";
            this.cCantidad.Name = "cCantidad";
            // 
            // cSubtotal
            // 
            this.cSubtotal.HeaderText = "SUBTOTAL";
            this.cSubtotal.Name = "cSubtotal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgPedido);
            this.panel1.Location = new System.Drawing.Point(24, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 261);
            this.panel1.TabIndex = 1;
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(469, 87);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(159, 20);
            this.txbSearch.TabIndex = 2;
            this.txbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOMBRE CLIENTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbCliente
            // 
            this.txbCliente.Location = new System.Drawing.Point(24, 34);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(161, 20);
            this.txbCliente.TabIndex = 4;
            // 
            // cmbPago
            // 
            this.cmbPago.FormattingEnabled = true;
            this.cmbPago.Location = new System.Drawing.Point(567, 37);
            this.cmbPago.Name = "cmbPago";
            this.cmbPago.Size = new System.Drawing.Size(156, 21);
            this.cmbPago.TabIndex = 5;
            this.cmbPago.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "MESERO";
            // 
            // txbEmpleado
            // 
            this.txbEmpleado.Location = new System.Drawing.Point(24, 87);
            this.txbEmpleado.Name = "txbEmpleado";
            this.txbEmpleado.ReadOnly = true;
            this.txbEmpleado.Size = new System.Drawing.Size(161, 20);
            this.txbEmpleado.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(648, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(466, 37);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(83, 13);
            this.lblPago.TabIndex = 9;
            this.lblPago.Text = "TIPO DE PAGO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(556, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(651, 409);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 24);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "$0.00";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(585, 501);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 38);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(411, 501);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 38);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar Pedido";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCantidadOrdenes});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(748, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCantidadOrdenes
            // 
            this.lblCantidadOrdenes.Name = "lblCantidadOrdenes";
            this.lblCantidadOrdenes.Size = new System.Drawing.Size(123, 17);
            this.lblCantidadOrdenes.Text = "0 Ordenes Registradas";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(24, 395);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 26);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Eliminar Orden";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbIndex
            // 
            this.txbIndex.Location = new System.Drawing.Point(143, 399);
            this.txbIndex.Name = "txbIndex";
            this.txbIndex.Size = new System.Drawing.Size(24, 20);
            this.txbIndex.TabIndex = 17;
            this.txbIndex.Visible = false;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 579);
            this.Controls.Add(this.txbIndex);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPago);
            this.Controls.Add(this.txbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEDIDOS";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.ComboBox cmbPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEmpleado;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSubtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCantidadOrdenes;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txbIndex;
    }
}