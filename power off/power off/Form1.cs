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
using System.Runtime.InteropServices;

namespace power_off
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0");
        }

        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        private void button3_Click(object sender, EventArgs e)
        {
            ExitWindowsEx(0, 0);
        }

        [DllImport("user32")]
        public static extern void LockWorkStation();

        private void button4_Click(object sender, EventArgs e)
        {
            LockWorkStation();
        }

        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        private void button5_Click(object sender, EventArgs e)
        {
            SetSuspendState(true, true, true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetSuspendState(false, true, true);
        }
    }
    
}