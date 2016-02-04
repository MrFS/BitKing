using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace BitKing
{
    public partial class frmConsole : Form
    {
        PerformanceCounter cpuCounter;
        PerformanceCounter ramCounter;

        public frmConsole()
        {
            InitializeComponent();
        }
        private void frmConsole_Load(object sender, EventArgs e)
        {
            tmrDebug.Enabled = true;

            cpuCounter = new PerformanceCounter();
            ramCounter = new PerformanceCounter("Memory", "Available Bytes");

            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

        }

        private void tmrDebug_Tick(object sender, EventArgs e)
        {

            
            listBox1.Items.Clear();
            listBox1.Items.Add("BitKing Console - " + this.ProductVersion + " | " + this.ProductName + " | " + this.Name);
            
            listBox1.Items.Add(getCPU());
            listBox1.Items.Add(getRAM());
            

        }

        public string getCPU()
        {
            return "CPU: " + cpuCounter.NextValue() + "%";
        }

        public string getRAM()
        {
            return "RAM: " + ramCounter.NextValue() / 1024 + "B";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    txtConsole.CharacterCasing = CharacterCasing.Lower;
                    if (txtConsole.Text == "exit")
                    {
                        Application.Exit();
                    }

                    if (txtConsole.Text == "tmrpaus")
                    {
                        tmrDebug.Enabled = false;

                        txtConsole.Clear();
                    }

                    if (txtConsole.Text == "tmrunp")
                    {
                        tmrDebug.Enabled = true;

                        txtConsole.Clear();
                    }

                    if (txtConsole.Text == "clear")
                    {
                        listBox1.Items.Clear();

                        txtConsole.Clear();
                    }

                    if (txtConsole.Text == "help")
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add("BitKing Console - " + this.ProductVersion + " | " + this.ProductName + " | " + this.Name);
                        listBox1.Items.Add("Available console commands:");
                        listBox1.Items.Add("-- List Of CMDs --");

                        txtConsole.Clear();
                    }



                    break;
            }
        }
    }
}
