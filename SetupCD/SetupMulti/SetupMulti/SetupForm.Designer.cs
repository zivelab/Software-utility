namespace SetupMulti
{
    partial class SetupForm
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
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.pBoxMain = new System.Windows.Forms.PictureBox();
            this.linkLabelW = new System.Windows.Forms.LinkLabel();
            this.linkLabelZ = new System.Windows.Forms.LinkLabel();
            this.flPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelLogoSize = new System.Windows.Forms.Label();
            this.labelImageSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxLogo.Location = new System.Drawing.Point(32, 12);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(235, 106);
            this.pBoxLogo.TabIndex = 0;
            this.pBoxLogo.TabStop = false;
            // 
            // pBoxMain
            // 
            this.pBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pBoxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxMain.Location = new System.Drawing.Point(12, 124);
            this.pBoxMain.Name = "pBoxMain";
            this.pBoxMain.Size = new System.Drawing.Size(274, 569);
            this.pBoxMain.TabIndex = 1;
            this.pBoxMain.TabStop = false;
            // 
            // linkLabelW
            // 
            this.linkLabelW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabelW.AutoSize = true;
            this.linkLabelW.Location = new System.Drawing.Point(12, 708);
            this.linkLabelW.Name = "linkLabelW";
            this.linkLabelW.Size = new System.Drawing.Size(168, 14);
            this.linkLabelW.TabIndex = 2;
            this.linkLabelW.TabStop = true;
            this.linkLabelW.Text = "http://www.wonatech.com";
            this.linkLabelW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelW_LinkClicked);
            // 
            // linkLabelZ
            // 
            this.linkLabelZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabelZ.AutoSize = true;
            this.linkLabelZ.Location = new System.Drawing.Point(192, 708);
            this.linkLabelZ.Name = "linkLabelZ";
            this.linkLabelZ.Size = new System.Drawing.Size(161, 14);
            this.linkLabelZ.TabIndex = 3;
            this.linkLabelZ.TabStop = true;
            this.linkLabelZ.Text = "http://www.zivelab.com";
            this.linkLabelZ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelZ_LinkClicked);
            // 
            // flPanel
            // 
            this.flPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flPanel.AutoScroll = true;
            this.flPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flPanel.Location = new System.Drawing.Point(302, 12);
            this.flPanel.Name = "flPanel";
            this.flPanel.Size = new System.Drawing.Size(378, 681);
            this.flPanel.TabIndex = 4;
            // 
            // labelLogoSize
            // 
            this.labelLogoSize.AutoSize = true;
            this.labelLogoSize.Location = new System.Drawing.Point(43, 24);
            this.labelLogoSize.Name = "labelLogoSize";
            this.labelLogoSize.Size = new System.Drawing.Size(49, 14);
            this.labelLogoSize.TabIndex = 5;
            this.labelLogoSize.Text = "label1";
            // 
            // labelImageSize
            // 
            this.labelImageSize.AutoSize = true;
            this.labelImageSize.Location = new System.Drawing.Point(29, 137);
            this.labelImageSize.Name = "labelImageSize";
            this.labelImageSize.Size = new System.Drawing.Size(49, 14);
            this.labelImageSize.TabIndex = 6;
            this.labelImageSize.Text = "label1";
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 736);
            this.Controls.Add(this.labelImageSize);
            this.Controls.Add(this.labelLogoSize);
            this.Controls.Add(this.flPanel);
            this.Controls.Add(this.linkLabelZ);
            this.Controls.Add(this.linkLabelW);
            this.Controls.Add(this.pBoxMain);
            this.Controls.Add(this.pBoxLogo);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WonATech Instruments Software Installation";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.PictureBox pBoxMain;
        private System.Windows.Forms.LinkLabel linkLabelW;
        private System.Windows.Forms.LinkLabel linkLabelZ;
        private System.Windows.Forms.FlowLayoutPanel flPanel;
        private System.Windows.Forms.Label labelLogoSize;
        private System.Windows.Forms.Label labelImageSize;
    }
}

