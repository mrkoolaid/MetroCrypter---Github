using System;
using System.Diagnostics;
using System.Windows.Forms;
using static MetroCrypter.Form1;

namespace MetroCrypter
{
    public partial class Assembly : Form
    {
        public Assembly()
        {
            InitializeComponent();
            fversion.Text = CID.fversion;
            name.Text = CID.title;
            company.Text = CID.company;
            product.Text = CID.product;
            copyright.Text = CID.copyright;
            trademark.Text = CID.trademark;
            version.Text = CID.version;
            desc.Text = CID.description;
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

        //Making a random string from the pool




        private string RandomNumbersp(int _length)
        {
            //Making a random number for the random assemblys version
            string pool = "012";

            string tmp = "";
            Random R = new Random();
            for (int x = 0; x < _length; x++)
            {
                tmp += pool[R.Next(0, pool.Length)].ToString();
            }
            return tmp;
        }
        private string RandomNumber(int _length)
        {
            //Making a random number for the random assemblys version
            string pool = "0123456789";

            string tmp = "";
            Random R = new Random();
            for (int x = 0; x < _length; x++)
            {
                tmp += pool[R.Next(0, pool.Length)].ToString();
            }
            return tmp;
        }
        private string RandomString(int length)
        {
            //Making a random string from the pool
            string pool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWKYZ1234567890";
            pool += pool.ToUpper();
            string tmp = "";
            Random R = new Random();
            for (int x = 0; x < length; x++)
            {
                tmp += pool[R.Next(0, pool.Length)].ToString();
            }
            return tmp;
        }
        string[] namer2 =
{ 
            
           /////Steam/////
          "Steam Client Bootstrapper", //file description//0
          "3.65.13.80", //file version//1
          "Steam Client Bootstrapper",// Product Name//2
          "01.00.00.01",//product version//3
          "Copyright (C) 2010 Valve Corporation",//copyright//4
          "",//company//5
          "",//TradeMark//6
          "Steam"//Title///7
          /////Steam/////
        };

        string[] namer =
        { 
            
           /////Steam/////
          "Skype", //file description
          "3.65.13.44", //file version
          "Skype S.a.r.l",// Product Name
          "01.81",//product version
          "Copyright (C) 2016 Skype",//copyright
          "Skype S.A.R.L",//company
          "Skype",//TradeMark
          "Skype"//Title
          /////Steam/////
        };
        string[] namer1 =
        { 
            
           /////Steam/////
          "Instagram", //file description//0
          "3.2", //file version//1
          "Instagram Client",// Product Name//2
          "01.21",//product version//3
          "Copyright (C) 2016 Instagram / Facebook",//copyright//4
          "Instagram",//company//5
          "Instagram",//TradeMark//6
          "Instagram"//Title///7
          /////Steam/////
        };
        string[] namers =
        {
            "namer",
            "namer1",
            "namer2"
        };
        private void button3_Click(object sender, EventArgs e)
        {
            string what = namers[Int32.Parse(RandomNumbersp(1))];
          
            if (what == "namer")
            {
                desc.Text = namer[0];
                fversion.Text = namer[1];
                product.Text = namer[2];
                version.Text = namer[3];
                copyright.Text = namer[4];
                company.Text = namer[5];
                trademark.Text = namer[6];          
                name.Text = namer[7];
                                                
            }
            else if (what == "namer1")
            {
                desc.Text = namer1[0];
                fversion.Text = namer1[1];
                product.Text = namer1[2];
                version.Text = namer1[3];
                copyright.Text = namer1[4];
                company.Text = namer1[5];
                trademark.Text = namer1[6];
                name.Text = namer1[7];
            }
            else if (what == "namer2")
            {
                desc.Text = namer2[0];
                fversion.Text = namer2[1];
                product.Text = namer2[2];
                version.Text = namer2[3];
                copyright.Text = namer2[4];
                company.Text = namer2[5];
                trademark.Text = namer2[6];
                name.Text = namer2[7];
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            CID.title = name.Text;
            CID.company = company.Text;
            CID.product = product.Text;
            CID.copyright = copyright.Text;
            CID.trademark = trademark.Text;
            CID.version = version.Text;
            CID.description = desc.Text;
            CID.fversion = fversion.Text;
            this.Close();
            if (String.IsNullOrEmpty(CID.title))
            {
                MessageBox.Show("Pleaes enter the assembly");

            }


        }

        private void Assembly_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Exe Cute Ables|*.exe";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string filepath = ofd.FileName;
                    if (ofd.FileName.Contains(".exe") == false)
                    {
                        MessageBox.Show("Please load a .exe file");
                    }
                    else
                    {

                        FileVersionInfo myFileVersionInfo =
                        FileVersionInfo.GetVersionInfo(ofd.FileName);


                        version.Text = myFileVersionInfo.ProductVersion;
                        fversion.Text = myFileVersionInfo.FileVersion;
                        company.Text = myFileVersionInfo.CompanyName;
                        desc.Text = myFileVersionInfo.FileDescription;
                        copyright.Text = myFileVersionInfo.LegalCopyright;
                        trademark.Text = myFileVersionInfo.LegalTrademarks;
                        product.Text = myFileVersionInfo.ProductName;
                        name.Text = myFileVersionInfo.InternalName;

                    }
                }


            }
        }


    }
}
