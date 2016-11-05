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

namespace MetroCrypter
{
    public partial class Options : Form
    {
        Forms.Startup startup;
        Forms.FilePump fp;
        Forms.injectiontype ijtype;
        Forms.Timer tm;
        public Options()
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


        private void Options_Load(object sender, EventArgs e)
        {
            ExeLoad.Text = "\n" + CID.filename;
            ExeLoad.ImageAlign = ContentAlignment.BottomCenter;
            IcoLoad.Text = "\n" + CID.iconame;
            IcoLoad.ImageAlign = ContentAlignment.BottomCenter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OpenFD = new OpenFileDialog())
            {
                if (OpenFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    OpenFD.Filter = "Payload|*.exe";
                    CID.filename =  OpenFD.FileName;
                    
                    ExeLoad.Text = "\n" + OpenFD.SafeFileName.ToString();
                    ExeLoad.ImageAlign = ContentAlignment.BottomCenter;
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OpenFD = new OpenFileDialog())
            {
                OpenFD.Filter = "Icon|*.ico";
                if (OpenFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CID.iconame = OpenFD.FileName;
                    IcoLoad.Text = "\n" + OpenFD.SafeFileName.ToString();
                    IcoLoad.ImageAlign = ContentAlignment.BottomCenter;
                }
            }
        }

        private void delaylabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            startup = new Forms.Startup();
            startup.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            fp = new Forms.FilePump();
            fp.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ijtype = new Forms.injectiontype();
            ijtype.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tm = new Forms.Timer();
            tm.ShowDialog();
        }
    }
}
