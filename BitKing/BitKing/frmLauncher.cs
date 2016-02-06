using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitKing
{
    public partial class frmLauncher : Form
    {
        public frmLauncher()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void frmLauncher_Load(object sender, EventArgs e)
        {
            this.Text = "Bitking Launcher";
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsole frm = new frmConsole();
            frm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.Show();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHelp frm = new frmHelp();
            frm.Show();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tmrClouds_Tick(object sender, EventArgs e)
        {
            PictureBox[] clouds =
            {
                pbCloud1,
                pbCloud2,
                pbCloud3,
                pbCloud4,
                pbCloud5
            };
            
        }
    }
}
