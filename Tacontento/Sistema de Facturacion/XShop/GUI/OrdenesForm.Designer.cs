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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIdClasificacion
            // 
            this.cmbIdClasificacion.FormattingEnabled = true;
            this.cmbIdClasificacion.Location = new System.Drawing.Point(602, 71);
            this.cmbIdClasificacion.Name = "cmbIdClasificacion";
            this.cmbIdClasificacion.Size = new System.Drawing.Size(121, 21);
            this.cmbIdClasificacion.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(648, 108);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.AcceptsTab = true;
            this.txbDescripcion.Location = new System.Drawing.Point(78, 79);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(257, 36);
            this.txbDescripcion.TabIndex = 8;
            // 
            // txbPrecio
            // 
            this.txbPrecio.AcceptsTab = true;
            this.txbPrecio.Location = new System.Drawing.Point(640, 37);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(83, 20);
            this.txbPrecio.TabIndex = 7;
            this.txbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecio_KeyPress);
            // 
            // txbNombre
            // 
            this.txbNombre.AcceptsTab = true;
            this.txbNombre.Location = new System.Drawing.Point(58, 34);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(230, 20);
            this.txbNombre.TabIndex = 6;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(536, 108);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(430, 108);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgDatos);
            this.panel1.Location = new System.Drawing.Point(13, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 456);
            this.panel1.TabIndex = 13;
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            this.dtgDatos.AllowUserToDeleteRows = false;
            this.dtgDatos.AllowUserToResizeColumns = false;
            this.dtgDatos.AllowUserToResizeRows = false;
            this.dtgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dtgDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cNombre,
            this.cPrecio,
            this.cDescripcion,
            this.cClasificacion});
            this.dtgDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDatos.Location = new System.Drawing.Point(0, 0);
            this.dtgDatos.MultiSelect = false;
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.ReadOnly = true;
            this.dtgDatos.RowHeadersVisible = false;
            this.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDatos.Size = new System.Drawing.Size(739, 456);
            this.dtgDatos.TabIndex = 2;
            this.dtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_CellClick);
            this.dtgDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_CellContentClick);
            this.dtgDatos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_RowEnter);
            // 
            // cId
            // 
            this.cId.HeaderText = "Id";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            // 
            // cPrecio
            // 
            this.cPrecio.HeaderText = "Precio";
            this.cPrecio.Name = "cPrecio";
            this.cPrecio.ReadOnly = true;
            // 
            // cDescripcion
            // 
            this.cDescripcion.HeaderText = "Descripcion";
            this.cDescripcion.Name = "cDescripcion";
            this.cDescripcion.ReadOnly = true;
            // 
            // cClasificacion
            // 
            this.cClasificacion.HeaderText = "Clasificacion";
            this.cClasificacion.Name = "cClasificacion";
            this.cClasificacion.ReadOnly = true;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRegistros.Location = new System.Drawing.Point(10, 596);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(60, 13);
            this.lblRegistros.TabIndex = 14;
            this.lblRegistros.Text = "0 Registros";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(11, 12);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(24, 20);
            this.txbId.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(8, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Descripción";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrecio.Location = new System.Drawing.Point(588, 44);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 13);
            this.lblPrecio.TabIndex = 18;
            this.lblPrecio.Text = "Precio $";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategoria.Location = new System.Drawing.Point(533, 79);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 19;
            this.lblCategoria.Text = "Categoría";
            // 
            // OrdenesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(764, 618);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cmbIdClasificacion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbNombre);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdenesForm";
            this.Text = "OrdenesForm";
            this.Load += new System.EventHandler(this.OrdenesForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIdClasificacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cClasificacion;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
    }
}