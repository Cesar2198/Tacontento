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
            this.btnLocal = new System.Windows.Forms.Button();
            this.pnSubMenuLocal = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarRoles = new System.Windows.Forms.Button();
            this.btnAgregarUsuarios = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnSubMenuLocal.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // userRolLabel
            // 
            this.userRolLabel.AutoSize = true;
            this.userRolLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.userRolLabel.ForeColor = System.Drawing.Color.Snow;
            this.userRolLabel.Location = new System.Drawing.Point(133, 64);
            this.userRolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userRolLabel.Name = "userRolLabel";
            this.userRolLabel.Size = new System.Drawing.Size(34, 19);
            this.userRolLabel.TabIndex = 3;
            this.userRolLabel.Text = "Rol";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(97, 57);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Snow;
            this.usernameLabel.Location = new System.Drawing.Point(97, 15);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(140, 19);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Nombre Usuario";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnLocal
            // 
            this.btnLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(142)))), ((int)(((byte)(61)))));
            this.btnLocal.FlatAppearance.BorderSize = 0;
            this.btnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLocal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLocal.Location = new System.Drawing.Point(0, 101);
            this.btnLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnLocal.Size = new System.Drawing.Size(276, 43);
            this.btnLocal.TabIndex = 5;
            this.btnLocal.Text = "Mantenimiento de Local";
            this.btnLocal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocal.UseVisualStyleBackColor = false;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // pnSubMenuLocal
            // 
            this.pnSubMenuLocal.Controls.Add(this.button1);
            this.pnSubMenuLocal.Controls.Add(this.btnAgregarRoles);
            this.pnSubMenuLocal.Controls.Add(this.btnAgregarUsuarios);
            this.pnSubMenuLocal.Location = new System.Drawing.Point(0, 151);
            this.pnSubMenuLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnSubMenuLocal.Name = "pnSubMenuLocal";
            this.pnSubMenuLocal.Size = new System.Drawing.Size(272, 137);
            this.pnSubMenuLocal.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(0, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(272, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Control incidencias";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAgregarRoles
            // 
            this.btnAgregarRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnAgregarRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarRoles.FlatAppearance.BorderSize = 0;
            this.btnAgregarRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRoles.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarRoles.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregarRoles.Location = new System.Drawing.Point(0, 43);
            this.btnAgregarRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarRoles.Name = "btnAgregarRoles";
            this.btnAgregarRoles.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnAgregarRoles.Size = new System.Drawing.Size(272, 43);
            this.btnAgregarRoles.TabIndex = 7;
            this.btnAgregarRoles.Text = "Control Roles";
            this.btnAgregarRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRoles.UseVisualStyleBackColor = false;
            this.btnAgregarRoles.Click += new System.EventHandler(this.btnAgregarRoles_Click);
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
            this.btnAgregarUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarUsuarios.Name = "btnAgregarUsuarios";
            this.btnAgregarUsuarios.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnAgregarUsuarios.Size = new System.Drawing.Size(272, 43);
            this.btnAgregarUsuarios.TabIndex = 6;
            this.btnAgregarUsuarios.Text = "Control Usuarios";
            this.btnAgregarUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarUsuarios.UseVisualStyleBackColor = false;
            this.btnAgregarUsuarios.Click += new System.EventHandler(this.btnAgregarUsuarios_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 759);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSalir);
            this.panel5.Controls.Add(this.btnOrdenes);
            this.panel5.Controls.Add(this.btnPrincipal);
            this.panel5.Controls.Add(this.pnSubMenuLocal);
            this.panel5.Controls.Add(this.btnLocal);
            this.panel5.Location = new System.Drawing.Point(0, 102);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(276, 657);
            this.panel5.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(142)))), ((int)(((byte)(61)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.Location = new System.Drawing.Point(0, 614);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(276, 43);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(142)))), ((int)(((byte)(61)))));
            this.btnOrdenes.FlatAppearance.BorderSize = 0;
            this.btnOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOrdenes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrdenes.Location = new System.Drawing.Point(0, 50);
            this.btnOrdenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnOrdenes.Size = new System.Drawing.Size(276, 43);
            this.btnOrdenes.TabIndex = 6;
            this.btnOrdenes.Text = "Control Ordenes";
            this.btnOrdenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(142)))), ((int)(((byte)(61)))));
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrincipal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.btnPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnPrincipal.Size = new System.Drawing.Size(276, 43);
            this.btnPrincipal.TabIndex = 0;
            this.btnPrincipal.Text = "Panel Principal";
            this.btnPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrincipal.UseVisualStyleBackColor = false;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.usernameLabel);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.userRolLabel);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 95);
            this.panel4.TabIndex = 2;
            // 
            // panelContainer
            // 
            this.panelContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelContainer.Location = new System.Drawing.Point(275, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1025, 761);
            this.panelContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 759);
            this.ControlBox = false;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnSubMenuLocal.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label userRolLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Button btnLocal;
        private Panel pnSubMenuLocal;
        private Button btnAgregarUsuarios;
        private Button button1;
        private Button btnAgregarRoles;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Panel panelContainer;
        private Button btnPrincipal;
        private Button btnOrdenes;
        private Button btnSalir;
    }
}