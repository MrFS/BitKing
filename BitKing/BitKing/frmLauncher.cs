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
    }
}
