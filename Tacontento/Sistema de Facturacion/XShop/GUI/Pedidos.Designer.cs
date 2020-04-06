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
            this.dtgPedido = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedido)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dtgPedido.BackgroundColor = System.Drawing.Color.White;
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
            this.dtgPedido.ReadOnly = true;
            this.dtgPedido.RowHeadersVisible = false;
            this.dtgPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPedido.Size = new System.Drawing.Size(699, 261);
            this.dtgPedido.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgPedido);
            this.panel1.Location = new System.Drawing.Point(24, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 261);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(469, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 2;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(567, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(24, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 20);
            this.textBox3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "TIPO DE PAGO";
            // 
            // cID
            // 
            this.cID.HeaderText = "ID ORDEN";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            // 
            // cOrden
            // 
            this.cOrden.HeaderText = "ORDEN";
            this.cOrden.Name = "cOrden";
            this.cOrden.ReadOnly = true;
            // 
            // cPrecio
            // 
            this.cPrecio.HeaderText = "PRECIO";
            this.cPrecio.Name = "cPrecio";
            this.cPrecio.ReadOnly = true;
            // 
            // cCantidad
            // 
            this.cCantidad.HeaderText = "CANTIDAD";
            this.cCantidad.Name = "cCantidad";
            this.cCantidad.ReadOnly = true;
            // 
            // cSubtotal
            // 
            this.cSubtotal.HeaderText = "SUBTOTAL";
            this.cSubtotal.Name = "cSubtotal";
            this.cSubtotal.ReadOnly = true;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(651, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "$0.00";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "Terminar Pedido";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(411, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 38);
            this.button3.TabIndex = 13;
            this.button3.Text = "Guardar Pedido";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 579);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSubtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}