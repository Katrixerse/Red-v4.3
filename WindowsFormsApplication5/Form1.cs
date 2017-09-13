using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Pipes;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security;
using System.Collections;
using System.Windows.Forms;
using MaterialSkin;
using System.Diagnostics;
using System.Web;

namespace WindowsFormsApplication5
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {

        public void UpdateAvhub()
        {
            using (var webClient = new WebClient())
            {
                try
                {
                    System.Net.WebClient WC = new System.Net.WebClient();
                    string http1 = WC.DownloadString("https://static18.icyboards.net/inferno/images/RedHosting/version.txt");
                    webClient.DownloadFile("https://dl.dropbox.com/s/iagfqmcxoq6bzrg/Red.exe?dl=0", "Red V" + http1 + ".exe");
                }
                catch
                {
                    MessageBox.Show("There was a error downloading the latest version!.", "Red - Auto Updater");
                }
            }
        }

        public void GetUserIP()
        {
            try
            {
                UTF8Encoding utf8 = new UTF8Encoding(); WebClient webClient = new WebClient(); String externalIp = utf8.GetString(webClient.DownloadData("https://icanhazip.com"));
                txtIP.Text = externalIp;
            } catch
            {
                MessageBox.Show("A Error happened with the whitelist", "Red Wl Failed");
                System.Environment.Exit(0);
            }
        }

        public int GetProcessId(string proc)
        {
            return Process.GetProcessesByName(proc)[0].Id;
        }

        public void hwidcheck()
        {
            try
            {
                if (materialSingleLineTextField1.Text == "") return;
                if (materialSingleLineTextField2.Text == "") return;

                System.Net.WebClient WC = new System.Net.WebClient();
                string http1 = WC.DownloadString("https://static18.icyboards.net/inferno/images/RedHosting/hwid.txt");
                string http2 = WC.DownloadString("https://static18.icyboards.net/inferno/images/RedHosting/username.txt");
                string http3 = WC.DownloadString("https://static18.icyboards.net/inferno/images/RedHosting/password.txt");
                string http4 = WC.DownloadString("https://static18.icyboards.net/inferno/images/RedHosting/IP.txt");
                if (http1.Contains(materialSingleLineTextField5.Text))
                    if (http2.Contains(materialSingleLineTextField4.Text))
                        if (http3.Contains(materialSingleLineTextField3.Text))
                            if (http4.Contains(materialSingleLineTextField6.Text))
                            {
                                Form3 frm2 = new Form3();
                                MessageBox.Show("Welcome, " + materialSingleLineTextField1.Text + " login successful enjoy using Red", "Red Wl Success");
                                this.Hide();
                                frm2.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("You're not whitelisted if you believe this is a error please contact Caleb#2044 or Doppler#3837 1", "Red Wl Failed");
                                //System.Environment.Exit(0);
                            }
                        else
                        {
                            MessageBox.Show("You're not whitelisted if you believe this is a error please contact Caleb#2044 or Doppler#3837 2 ", "Red Wl Failed");
                           // System.Environment.Exit(0);
                        }
                    else
                    {
                        MessageBox.Show("You're not whitelisted if you believe this is a error please contact Caleb#2044 or Doppler#3837 3", "Red Wl Failed");
                       // System.Environment.Exit(0);
                    }
                else 
                {
                    MessageBox.Show("You're not whitelisted if you believe this is a error please contact Caleb#2044 or Doppler#3837 4", "Red Wl Failed");
                    //System.Environment.Exit(0);
                }
            }
            catch
            {
                MessageBox.Show("A error occured fetching the whitelist please try again", "Red error");
                System.Environment.Exit(0);
            }
        }

        public void hwidgrab()
        {
            try
            {
                string HWID = string.Empty;//creating a empty string
                System.Management.ManagementClass Management = new System.Management.ManagementClass("win32_processor");//declaring the system management calss
                System.Management.ManagementObjectCollection MObject = Management.GetInstances();//decalring the system management object collection 
                foreach (System.Management.ManagementObject mob in MObject)//having a foreach loop
                {
                    if (string.IsNullOrEmpty(HWID))
                    {
                        HWID = mob.GetPropertyValue("processorID").ToString();//converting the HWID to string
                        break;
                    }
                }
                txtHWID.Text = HWID;
            }
            catch
            {
                MessageBox.Show("Error occurred sorry!. please try again", "Red");
            }
        }

        public void processcheck()
        {
            foreach (Process proc in Process.GetProcessesByName("Fiddler"))
            {
                proc.CloseMainWindow();
                //ask the process to exit.
                proc.WaitForExit(10);
                //wait up to 10 seconds.

                if (!proc.HasExited)
                {
                    proc.Kill();
                    //force the process to exit.
                }
            }
            foreach (Process proc in Process.GetProcessesByName("idab"))
            {
                proc.CloseMainWindow();
                //ask the process to exit.
                proc.WaitForExit(10);
                //wait up to 10 seconds.

                if (!proc.HasExited)
                {
                    proc.Kill();
                    //force the process to exit.
                }
            }
            foreach (Process proc in Process.GetProcessesByName("JustDecompile"))
            {
                proc.CloseMainWindow();
                //ask the process to exit.
                proc.WaitForExit(10);
                //wait up to 10 seconds.

                if (!proc.HasExited)
                {
                    proc.Kill();
                    //force the process to exit.
                }
            }
            foreach (Process proc in Process.GetProcessesByName("dnSpy"))
            {
                proc.CloseMainWindow();
                //ask the process to exit.
                proc.WaitForExit(10);
                //wait up to 10 seconds.

                if (!proc.HasExited)
                {
                    proc.Kill();
                    //force the process to exit.
                }
            }
            foreach (Process proc in Process.GetProcessesByName("Fiddler.exe"))
            {
                proc.CloseMainWindow();
                //ask the process to exit.
                proc.WaitForExit(10);
                //wait up to 10 seconds.

                if (!proc.HasExited)
                {
                    proc.Kill();
                    //force the process to exit.
                }
            }
            foreach (Process proc in Process.GetProcessesByName("dotPeek"))
            {
                proc.CloseMainWindow();
                //ask the process to exit.
                proc.WaitForExit(10);
                //wait up to 10 seconds.

                if (!proc.HasExited)
                {
                    proc.Kill();
                    //force the process to exit.
                }
            }
            foreach (Process proc in Process.GetProcessesByName("ILSpy"))
            {
                proc.CloseMainWindow();
                //ask the process to exit.
                proc.WaitForExit(10);
                //wait up to 10 seconds.

                if (!proc.HasExited)
                {
                    proc.Kill();
                    //force the process to exit.
                }
            }
        }

        public void updatecheck()
        {
            try
            {
                System.Net.WebClient WC = new System.Net.WebClient();
                string http1 = WC.DownloadString("https://static18.icyboards.net/inferno/images/RedHosting/version.txt");
                string http2 = WC.DownloadString("https://static18.icyboards.net/inferno/images/RedHosting/oldversion.txt");
                if (http1.Contains(txtVersion.Text))
                {
                    this.Visible = false;

                    MessageBox.Show("Red is currently up to date!", "Red - Auto Updater");
                    this.Visible = true;
                }
                else
                {
                    this.Visible = false;

                    MessageBox.Show("Red needs to update! Pressing OK will automatically update Red.", "Red - Auto Updater");
                    UpdateAvhub();

                    StreamWriter sw = new StreamWriter("update.bat");
                    MessageBox.Show("Installing red updates, please wait!", "Red - Auto Updater");
                    sw.WriteLine("@echo off");
                    sw.WriteLine("PING 1.1.1.1 -n 1 -w 1500 >NUL");
                    sw.WriteLine("del Red-v" + http2 + ".exe");
                    sw.WriteLine("echo Updated Red New version: " + http1);
                    sw.WriteLine("del update.bat");
                    sw.WriteLine("pause>nul");
                    sw.Close();

                    Process.Start("update.bat");

                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("Error occurred updating sorry!. please restart and try again", "Red - update error");
                System.Environment.Exit(0);
            }
        }

        public void matrialskincheck()
        {

        }

        public void internetcheck()
        {
            bool internet = NetworkInterface.GetIsNetworkAvailable();
            if (internet == false)
            {
                MessageBox.Show("Error occurred sorry!. please restart and try again", "Red");
                Application.Exit();
            }
        }

        public void namecheck()
        {
             try
            {
                string exePath = Application.ExecutablePath;
                System.Net.WebClient WC = new System.Net.WebClient();
                string http1 = WC.DownloadString("https://static18.icyboards.net/inferno/images/RedHosting/oldversion.txt");
                System.IO.File.Move(exePath, "Red-v" + http1 + ".exe");
            } catch
           {
               MessageBox.Show("Error occurred sorry!. please restart and try again", "Red");
               Application.Exit();
           }
        }

     /*   public void updateversiondetection()
        {
             System.Net.WebClient WC = new System.Net.WebClient();
            string http1 = WC.DownloadString("https://static18.icyboards.net/inferno/images/RedHosting/oldversion.txt");
            txtVersion.Text = http1;
        } */

        public Form1()
        {
            InitializeComponent();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            internetcheck();
            //updateversiondetection();
            processcheck();
            GetUserIP();
            namecheck();
            processcheck();
            updatecheck();
            processcheck();
            hwidgrab();
            processcheck();
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            string hash = "%4h&bn9873*7^><?:'";
            //encrpyt for password
            byte[] data = UTF8Encoding.UTF8.GetBytes(materialSingleLineTextField2.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    materialSingleLineTextField3.Text = Convert.ToBase64String(result, 0, result.Length);
                }
            }

            // encrpyt for username
            byte[] data2 = UTF8Encoding.UTF8.GetBytes(materialSingleLineTextField1.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data2, 0, data2.Length);
                    materialSingleLineTextField4.Text = Convert.ToBase64String(result, 0, result.Length);
                }
            }

            // encrpyt for hwid
            byte[] data3 = UTF8Encoding.UTF8.GetBytes(txtHWID.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data3, 0, data3.Length);
                    materialSingleLineTextField5.Text = Convert.ToBase64String(result, 0, result.Length);
                }
            }

            //encrypt IP
            byte[] data4 = UTF8Encoding.UTF8.GetBytes(txtIP.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data4, 0, data4.Length);
                    materialSingleLineTextField6.Text = Convert.ToBase64String(result, 0, result.Length);
                }
            }

            internetcheck();
            processcheck();
            hwidcheck();
            materialSingleLineTextField2.Text = "";
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        public void txtIP_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtHWID_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtIP_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
 }
