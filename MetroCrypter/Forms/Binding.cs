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
using System.IO;

namespace MetroCrypter.Forms
{
    public partial class Binding : Form
    {
        public Binding()
        {
            InitializeComponent();
        }

        private void Binding_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CID.BindReply== true)
            {
                CID.BindReply = false;
                button2.Enabled = false;
                button3.Text = "Disabled";
            }
            else
            {
                button2.Enabled = true;
                CID.BindReply = true;
                button3.Text = "Enabled";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            if (String.IsNullOrEmpty(bFilename.Text) && CID.BindReply == true)
            {
                MessageBox.Show("You didn't enter everything");

            }
            else
            {
                CID.binding = bFilename.Text;
               

                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OpenFD = new OpenFileDialog())
            {
                if (OpenFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    OpenFD.Filter = "Binding File|*.exe";
                    bFilename.Text = OpenFD.FileName;
                   
                
                }
                if (OpenFD.FileName != String.Empty)
                {
                    MessageBox.Show("Loaded" + " " + OpenFD.SafeFileName + " Succesfully");
                }

            }
        }
    }
}
