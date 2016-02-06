namespace BitKing
{
    partial class frmHelp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabHelp = new System.Windows.Forms.TabControl();
            this.tabGen = new System.Windows.Forms.TabPage();
            this.tabMov = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSum = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabHelp.SuspendLayout();
            this.tabMov.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
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
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.tabGen);
            this.tabHelp.Controls.Add(this.tabMov);
            this.tabHelp.Controls.Add(this.tabSum);
            this.tabHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHelp.ItemSize = new System.Drawing.Size(49, 30);
            this.tabHelp.Location = new System.Drawing.Point(0, 24);
            this.tabHelp.Multiline = true;
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.SelectedIndex = 0;
            this.tabHelp.Size = new System.Drawing.Size(500, 326);
            this.tabHelp.TabIndex = 1;
            // 
            // tabGen
            // 
            this.tabGen.Location = new System.Drawing.Point(4, 34);
            this.tabGen.Name = "tabGen";
            this.tabGen.Padding = new System.Windows.Forms.Padding(3);
            this.tabGen.Size = new System.Drawing.Size(492, 288);
            this.tabGen.TabIndex = 0;
            this.tabGen.Text = "General";
            this.tabGen.UseVisualStyleBackColor = true;
            // 
            // tabMov
            // 
            this.tabMov.Controls.Add(this.label3);
            this.tabMov.Controls.Add(this.label4);
            this.tabMov.Controls.Add(this.label2);
            this.tabMov.Controls.Add(this.label1);
            this.tabMov.Location = new System.Drawing.Point(4, 34);
            this.tabMov.Name = "tabMov";
            this.tabMov.Padding = new System.Windows.Forms.Padding(3);
            this.tabMov.Size = new System.Drawing.Size(492, 288);
            this.tabMov.TabIndex = 1;
            this.tabMov.Text = "Movement";
            this.tabMov.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Additional Info Label";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jump:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Left: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Right:";
            // 
            // tabSum
            // 
            this.tabSum.Location = new System.Drawing.Point(4, 34);
            this.tabSum.Name = "tabSum";
            this.tabSum.Padding = new System.Windows.Forms.Padding(3);
            this.tabSum.Size = new System.Drawing.Size(492, 288);
            this.tabSum.TabIndex = 3;
            this.tabSum.Text = "Summary";
            this.tabSum.UseVisualStyleBackColor = true;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.tabHelp);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHelp";
            this.Text = "frmHelp";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabHelp.ResumeLayout(false);
            this.tabMov.ResumeLayout(false);
            this.tabMov.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabControl tabHelp;
        private System.Windows.Forms.TabPage tabGen;
        private System.Windows.Forms.TabPage tabMov;
        private System.Windows.Forms.TabPage tabSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}