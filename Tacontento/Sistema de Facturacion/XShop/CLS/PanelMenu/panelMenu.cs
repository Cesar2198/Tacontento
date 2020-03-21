using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XShop.CLS.PanelMenu
{
    partial class panelMenu
    {
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label labelMenuPanel;
        private System.Windows.Forms.PictureBox imagePanel;
        public panelMenu()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.imagePanel = new System.Windows.Forms.PictureBox();
            this.labelMenuPanel = new System.Windows.Forms.Label();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.labelMenuPanel);
            this.menuPanel.Controls.Add(this.imagePanel);
            this.menuPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuPanel.Location = new System.Drawing.Point(0, 104);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(243, 32);
            this.menuPanel.TabIndex = 1;
            //this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler();
            // 
            // imagePanel
            // 
            this.imagePanel.Image = Image.FromFile("../../../../images/active.png");
            this.imagePanel.Location = new System.Drawing.Point(12, 3);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(34, 25);
            this.imagePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePanel.TabIndex = 2;
            this.imagePanel.TabStop = false;
            // 
            // labelMenuPanel
            // 
            this.labelMenuPanel.AutoSize = true;
            this.labelMenuPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMenuPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuPanel.ForeColor = System.Drawing.Color.Snow;
            this.labelMenuPanel.Location = new System.Drawing.Point(52, 8);
            this.labelMenuPanel.Name = "labelMenuPanel";
            this.labelMenuPanel.Size = new System.Drawing.Size(106, 16);
            this.labelMenuPanel.TabIndex = 3;
            this.labelMenuPanel.Text = "Panel Principal 2";
        }

        
    }
}
