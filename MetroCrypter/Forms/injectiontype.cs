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
    public partial class injectiontype : Form
    {
        public injectiontype()
        {
            InitializeComponent();
            if (CID.ijtype != String.Empty)
            {
                comboBox1.SelectedItem = CID.ijtype;
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            CID.ijtype = comboBox1.SelectedItem.ToString();
            this.Close();
        }

        private void injectiontype_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString().ToLower() == "regasm" || comboBox1.SelectedItem.ToString().ToLower() == "vbc")
            {
                MessageBox.Show(comboBox1.SelectedItem.ToString() + " is currently unavailable, a patch will fix this soon.");
                comboBox1.SelectedItem = "Itself";
            }
        }
    }
}
