using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MetroCrypter.Form1;

namespace MetroCrypter.Forms
{
    public partial class Timer : Form
    {
        Forms.Popup pop;
        public Timer()
        {    
            InitializeComponent();
            
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CID.tmreply == true)
            {
                CID.tmreply = false;
                button2.Enabled = false;
                button3.Text = "Disabled";
            }
            else
            {
                button2.Enabled = true;
                CID.tmreply = true;
                button3.Text = "Enabled";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(timerr.Text))
            {
                pop = new Popup("Please enter everything");
                pop.Show();

            }
            else
            {
                CID.delay = timerr.Text;
         
                this.Close();
            }
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            timerr.Text = CID.delay;
            if (CID.tmreply == true)
            {
                button2.Enabled = true;
                button3.Text = "Enabled";
            }
            else
            {
                button3.Text = "Disabled";
            }
        }
    }
}
