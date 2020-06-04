using System.Drawing;
using System.Windows.Forms;

namespace XShop.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.userRolLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarRoles = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.subMenuReportes = new System.Windows.Forms.Panel();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.btnReportesMes = new System.Windows.Forms.Button();
            this.btnReportesxAnio = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.pnSubMenuLocal = new System.Windows.Forms.Panel();
            this.btnPermisos = new System.Windows.Forms.Button();
            this.btnAgregarUsuarios = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.panelOrdenes = new System.Windows.Forms.Panel();
            this.btnClasificaciones = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnMenuOrdenes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnRecordP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.subMenuReportes.SuspendLayout();
            this.pnSubMenuLocal.SuspendLayout();
            this.panelOrdenes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // userRolLabel
            // 
            this.userRolLabel.AutoSize = true;
            this.userRolLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.userRolLabel.ForeColor = System.Drawing.Color.Snow;
            this.userRolLabel.Location = new System.Drawing.Point(100, 52);
            this.userRolLabel.Name = "userRolLabel";
            this.userRolLabel.Size = new System.Drawing.Size(28, 16);
            this.userRolLabel.TabIndex = 3;
            this.userRolLabel.Text = "Rol";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(73, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Snow;
            this.usernameLabel.Location = new System.Drawing.Point(73, 12);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(112, 16);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Nombre Usuario";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(0, 35);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(207, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Control Empleados";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAgregarRoles
            // 
            this.btnAgregarRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnAgregarRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarRoles.FlatAppearance.BorderSize = 0;
            this.btnAgregarRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRoles.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarRoles.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregarRoles.Location = new System.Drawing.Point(0, 69);
            this.btnAgregarRoles.Name = "btnAgregarRoles";
            this.btnAgregarRoles.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarRoles.Size = new System.Drawing.Size(207, 36);
            this.btnAgregarRoles.TabIndex = 7;
            this.btnAgregarRoles.Text = "Control Roles";
            this.btnAgregarRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRoles.UseVisualStyleBackColor = false;
            this.btnAgregarRoles.Click += new System.EventHandler(this.btnAgregarRoles_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 617);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.subMenuReportes);
            this.panel5.Controls.Add(this.btnReportes);
            this.panel5.Controls.Add(this.btnLock);
            this.panel5.Controls.Add(this.pnSubMenuLocal);
            this.panel5.Controls.Add(this.btnLocal);
            this.panel5.Controls.Add(this.panelOrdenes);
            this.panel5.Controls.Add(this.btnMenuOrdenes);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.btnSalir);
            this.panel5.Location = new System.Drawing.Point(0, 83);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(207, 534);
            this.panel5.TabIndex = 2;
            // 
            // subMenuReportes
            // 
            this.subMenuReportes.Controls.Add(this.btnRecordP);
            this.subMenuReportes.Controls.Add(this.btnRecord);
            this.subMenuReportes.Controls.Add(this.btnBitacora);
            this.subMenuReportes.Controls.Add(this.btnReportesMes);
            this.subMenuReportes.Controls.Add(this.btnReportesxAnio);
            this.subMenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuReportes.Location = new System.Drawing.Point(0, 366);
            this.subMenuReportes.Name = "subMenuReportes";
            this.subMenuReportes.Size = new System.Drawing.Size(207, 169);
            this.subMenuReportes.TabIndex = 12;
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRecord.ForeColor = System.Drawing.Color.LightGray;
            this.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.Location = new System.Drawing.Point(0, 105);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRecord.Size = new System.Drawing.Size(207, 35);
            this.btnRecord.TabIndex = 9;
            this.btnRecord.Text = "Récord Vendedores";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnBitacora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBitacora.FlatAppearance.BorderSize = 0;
            this.btnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitacora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBitacora.ForeColor = System.Drawing.Color.LightGray;
            this.btnBitacora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBitacora.Location = new System.Drawing.Point(0, 70);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBitacora.Size = new System.Drawing.Size(207, 35);
            this.btnBitacora.TabIndex = 8;
            this.btnBitacora.Text = "Bitácora de Pedidos";
            this.btnBitacora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBitacora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBitacora.UseVisualStyleBackColor = false;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // btnReportesMes
            // 
            this.btnReportesMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnReportesMes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportesMes.FlatAppearance.BorderSize = 0;
            this.btnReportesMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesMes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReportesMes.ForeColor = System.Drawing.Color.LightGray;
            this.btnReportesMes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesMes.Location = new System.Drawing.Point(0, 35);
            this.btnReportesMes.Name = "btnReportesMes";
            this.btnReportesMes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReportesMes.Size = new System.Drawing.Size(207, 35);
            this.btnReportesMes.TabIndex = 7;
            this.btnReportesMes.Text = "Reportes Ventas Mes";
            this.btnReportesMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesMes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportesMes.UseVisualStyleBackColor = false;
            this.btnReportesMes.Click += new System.EventHandler(this.btnReportesMes_Click);
            // 
            // btnReportesxAnio
            // 
            this.btnReportesxAnio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnReportesxAnio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportesxAnio.FlatAppearance.BorderSize = 0;
            this.btnReportesxAnio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesxAnio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReportesxAnio.ForeColor = System.Drawing.Color.LightGray;
            this.btnReportesxAnio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesxAnio.Location = new System.Drawing.Point(0, 0);
            this.btnReportesxAnio.Name = "btnReportesxAnio";
            this.btnReportesxAnio.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReportesxAnio.Size = new System.Drawing.Size(207, 35);
            this.btnReportesxAnio.TabIndex = 6;
            this.btnReportesxAnio.Text = "Reportes Ventas Año";
            this.btnReportesxAnio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesxAnio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportesxAnio.UseVisualStyleBackColor = false;
            this.btnReportesxAnio.Click += new System.EventHandler(this.btnReportesxAnio_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(142)))), ((int)(((byte)(61)))));
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReportes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReportes.Location = new System.Drawing.Point(0, 331);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(207, 35);
            this.btnReportes.TabIndex = 11;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(142)))), ((int)(((byte)(61)))));
            this.btnLock.FlatAppearance.BorderSize = 0;
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLock.Image = ((System.Drawing.Image)(resources.GetObject("btnLock.Image")));
            this.btnLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLock.Location = new System.Drawing.Point(0, 458);
            this.btnLock.Name = "btnLock";
            this.btnLock.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLock.Size = new System.Drawing.Size(207, 35);
            this.btnLock.TabIndex = 10;
            this.btnLock.Text = "Bloquear";
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // pnSubMenuLocal
            // 
            this.pnSubMenuLocal.Controls.Add(this.btnPermisos);
            this.pnSubMenuLocal.Controls.Add(this.btnAgregarRoles);
            this.pnSubMenuLocal.Controls.Add(this.button1);
            this.pnSubMenuLocal.Controls.Add(this.btnAgregarUsuarios);
            this.pnSubMenuLocal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubMenuLocal.Location = new System.Drawing.Point(0, 180);
            this.pnSubMenuLocal.Name = "pnSubMenuLocal";
            this.pnSubMenuLocal.Size = new System.Drawing.Size(207, 151);
            this.pnSubMenuLocal.TabIndex = 9;
            // 
            // btnPermisos
            // 
            this.btnPermisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnPermisos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPermisos.FlatAppearance.BorderSize = 0;
            this.btnPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermisos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPermisos.ForeColor = System.Drawing.Color.LightGray;
            this.btnPermisos.Location = new System.Drawing.Point(0, 105);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPermisos.Size = new System.Drawing.Size(207, 40);
            this.btnPermisos.TabIndex = 9;
            this.btnPermisos.Text = "Control Permisos";
            this.btnPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermisos.UseVisualStyleBackColor = false;
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // btnAgregarUsuarios
            // 
            this.btnAgregarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnAgregarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarUsuarios.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregarUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarUsuarios.Name = "btnAgregarUsuarios";
            this.btnAgregarUsuarios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarUsuarios.Size = new System.Drawing.Size(207, 35);
            this.btnAgregarUsuarios.TabIndex = 6;
            this.btnAgregarUsuarios.Text = "Control Usuarios";
            this.btnAgregarUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarUsuarios.UseVisualStyleBackColor = false;
            this.btnAgregarUsuarios.Click += new System.EventHandler(this.btnAgregarUsuarios_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(142)))), ((int)(((byte)(61)))));
            this.btnLocal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocal.FlatAppearance.BorderSize = 0;
            this.btnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLocal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLocal.Location = new System.Drawing.Point(0, 145);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLocal.Size = new System.Drawing.Size(207, 35);
            this.btnLocal.TabIndex = 8;
            this.btnLocal.Text = "Mantenimiento Local";
            this.btnLocal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocal.UseVisualStyleBackColor = false;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click_1);
            // 
            // panelOrdenes
            // 
            this.panelOrdenes.Controls.Add(this.btnClasificaciones);
            this.panelOrdenes.Controls.Add(this.btnOrdenes);
            this.panelOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrdenes.Location = new System.Drawing.Point(0, 70);
            this.panelOrdenes.Name = "panelOrdenes";
            this.panelOrdenes.Size = new System.Drawing.Size(207, 75);
            this.panelOrdenes.TabIndex = 6;
            // 
            // btnClasificaciones
            // 
            this.btnClasificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnClasificaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClasificaciones.FlatAppearance.BorderSize = 0;
            this.btnClasificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasificaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClasificaciones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClasificaciones.Location = new System.Drawing.Point(0, 35);
            this.btnClasificaciones.Name = "btnClasificaciones";
            this.btnClasificaciones.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnClasificaciones.Size = new System.Drawing.Size(207, 34);
            this.btnClasificaciones.TabIndex = 9;
            this.btnClasificaciones.Text = "Control Clasificaciones";
            this.btnClasificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClasificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClasificaciones.UseVisualStyleBackColor = false;
            this.btnClasificaciones.Click += new System.EventHandler(this.btnClasificaciones_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenes.FlatAppearance.BorderSize = 0;
            this.btnOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOrdenes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrdenes.Location = new System.Drawing.Point(0, 0);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOrdenes.Size = new System.Drawing.Size(207, 35);
            this.btnOrdenes.TabIndex = 8;
            this.btnOrdenes.Text = "Control Ordenes";
            this.btnOrdenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click_1);
            // 
            // btnMenuOrdenes
            // 
            this.btnMenuOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(142)))), ((int)(((byte)(61)))));
            this.btnMenuOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuOrdenes.FlatAppearance.BorderSize = 0;
            this.btnMenuOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuOrdenes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMenuOrdenes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuOrdenes.Location = new System.Drawing.Point(0, 35);
            this.btnMenuOrdenes.Name = "btnMenuOrdenes";
            this.btnMenuOrdenes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuOrdenes.Size = new System.Drawing.Size(207, 35);
            this.btnMenuOrdenes.TabIndex = 6;
            this.btnMenuOrdenes.Text = "Mantenimiento Ordenes";
            this.btnMenuOrdenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuOrdenes.UseVisualStyleBackColor = false;
            this.btnMenuOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(142)))), ((int)(((byte)(61)))));
            this.btnPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrincipal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrincipal.Size = new System.Drawing.Size(207, 35);
            this.btnPrincipal.TabIndex = 0;
            this.btnPrincipal.Text = "Panel Principal";
            this.btnPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrincipal.UseVisualStyleBackColor = false;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(142)))), ((int)(((byte)(61)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 499);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(207, 35);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.usernameLabel);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.userRolLabel);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 77);
            this.panel4.TabIndex = 2;
            // 
            // panelContainer
            // 
            this.panelContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelContainer.Location = new System.Drawing.Point(206, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(769, 618);
            this.panelContainer.TabIndex = 2;
            // 
            // btnRecordP
            // 
            this.btnRecordP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnRecordP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecordP.FlatAppearance.BorderSize = 0;
            this.btnRecordP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRecordP.ForeColor = System.Drawing.Color.LightGray;
            this.btnRecordP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecordP.Location = new System.Drawing.Point(0, 140);
            this.btnRecordP.Name = "btnRecordP";
            this.btnRecordP.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRecordP.Size = new System.Drawing.Size(207, 35);
            this.btnRecordP.TabIndex = 10;
            this.btnRecordP.Text = "Récord Productos";
            this.btnRecordP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecordP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecordP.UseVisualStyleBackColor = false;
            this.btnRecordP.Click += new System.EventHandler(this.btnRecordP_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 617);
            this.ControlBox = false;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.subMenuReportes.ResumeLayout(false);
            this.pnSubMenuLocal.ResumeLayout(false);
            this.panelOrdenes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label userRolLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Button button1;
        private Button btnAgregarRoles;
        private Panel panel3;
        private Panel panel4;
        private Panel panelContainer;
        private Button btnPrincipal;
        private Button btnAgregarUsuarios;
        private Panel panel5;
        private Button btnMenuOrdenes;
        private Button btnClasificaciones;
        private Button btnOrdenes;
        private Panel panel1;
        private Button btnSalir;
        private Panel panelOrdenes;
        private Panel pnSubMenuLocal;
        private Button btnLocal;
        private Button btnPermisos;
        private Button btnLock;
        private Button btnReportes;
        private Panel subMenuReportes;
        private Button btnReportesxAnio;
        private Button btnReportesMes;
        private Button btnBitacora;
        private Button btnRecord;
        private Button btnRecordP;
    }
}