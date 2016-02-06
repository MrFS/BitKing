namespace BitKing
{
    partial class frmLauncher
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.pbCloud1 = new System.Windows.Forms.PictureBox();
            this.pbCloud3 = new System.Windows.Forms.PictureBox();
            this.pbCloud2 = new System.Windows.Forms.PictureBox();
            this.tmrClouds = new System.Windows.Forms.Timer(this.components);
            this.pbCloud4 = new System.Windows.Forms.PictureBox();
            this.pbCloud5 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud5)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.toolStripMenuItem1,
            this.consoleToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(26, 20);
            this.xToolStripMenuItem.Text = "X";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "_";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.consoleToolStripMenuItem.Text = "Console";
            this.consoleToolStripMenuItem.Click += new System.EventHandler(this.consoleToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "Fil&e";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "He&lp";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aboutToolStripMenuItem.Text = "Ab&out Bit&King";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.Color.Transparent;
            this.pbUser.BackgroundImage = global::BitKing.Properties.Resources.Menyknapp;
            this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbUser.Location = new System.Drawing.Point(238, 160);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(150, 31);
            this.pbUser.TabIndex = 2;
            this.pbUser.TabStop = false;
            // 
            // pbPass
            // 
            this.pbPass.BackColor = System.Drawing.Color.Transparent;
            this.pbPass.BackgroundImage = global::BitKing.Properties.Resources.Menyknapp;
            this.pbPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPass.Location = new System.Drawing.Point(238, 197);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(150, 31);
            this.pbPass.TabIndex = 3;
            this.pbPass.TabStop = false;
            // 
            // pbCloud1
            // 
            this.pbCloud1.BackColor = System.Drawing.Color.Transparent;
            this.pbCloud1.BackgroundImage = global::BitKing.Properties.Resources.cloud2;
            this.pbCloud1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbCloud1.Location = new System.Drawing.Point(25, 33);
            this.pbCloud1.Name = "pbCloud1";
            this.pbCloud1.Size = new System.Drawing.Size(76, 19);
            this.pbCloud1.TabIndex = 4;
            this.pbCloud1.TabStop = false;
            // 
            // pbCloud3
            // 
            this.pbCloud3.BackColor = System.Drawing.Color.Transparent;
            this.pbCloud3.BackgroundImage = global::BitKing.Properties.Resources.cloud2;
            this.pbCloud3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbCloud3.Location = new System.Drawing.Point(163, 39);
            this.pbCloud3.Name = "pbCloud3";
            this.pbCloud3.Size = new System.Drawing.Size(76, 22);
            this.pbCloud3.TabIndex = 5;
            this.pbCloud3.TabStop = false;
            // 
            // pbCloud2
            // 
            this.pbCloud2.BackColor = System.Drawing.Color.Transparent;
            this.pbCloud2.BackgroundImage = global::BitKing.Properties.Resources.cloud2;
            this.pbCloud2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbCloud2.Location = new System.Drawing.Point(336, 52);
            this.pbCloud2.Name = "pbCloud2";
            this.pbCloud2.Size = new System.Drawing.Size(77, 20);
            this.pbCloud2.TabIndex = 6;
            this.pbCloud2.TabStop = false;
            // 
            // tmrClouds
            // 
            this.tmrClouds.Enabled = true;
            this.tmrClouds.Interval = 500;
            this.tmrClouds.Tick += new System.EventHandler(this.tmrClouds_Tick);
            // 
            // pbCloud4
            // 
            this.pbCloud4.BackColor = System.Drawing.Color.Transparent;
            this.pbCloud4.BackgroundImage = global::BitKing.Properties.Resources.cloud2;
            this.pbCloud4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCloud4.Location = new System.Drawing.Point(479, 33);
            this.pbCloud4.Name = "pbCloud4";
            this.pbCloud4.Size = new System.Drawing.Size(38, 12);
            this.pbCloud4.TabIndex = 7;
            this.pbCloud4.TabStop = false;
            // 
            // pbCloud5
            // 
            this.pbCloud5.BackColor = System.Drawing.Color.Transparent;
            this.pbCloud5.BackgroundImage = global::BitKing.Properties.Resources.cloud2;
            this.pbCloud5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCloud5.Location = new System.Drawing.Point(524, 52);
            this.pbCloud5.Name = "pbCloud5";
            this.pbCloud5.Size = new System.Drawing.Size(35, 15);
            this.pbCloud5.TabIndex = 8;
            this.pbCloud5.TabStop = false;
            // 
            // frmLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BitKing.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(600, 320);
            this.Controls.Add(this.pbCloud5);
            this.Controls.Add(this.pbCloud4);
            this.Controls.Add(this.pbCloud2);
            this.Controls.Add(this.pbCloud3);
            this.Controls.Add(this.pbCloud1);
            this.Controls.Add(this.pbPass);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLauncher_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.PictureBox pbCloud1;
        private System.Windows.Forms.PictureBox pbCloud3;
        private System.Windows.Forms.PictureBox pbCloud2;
        private System.Windows.Forms.Timer tmrClouds;
        private System.Windows.Forms.PictureBox pbCloud4;
        private System.Windows.Forms.PictureBox pbCloud5;
    }
}

