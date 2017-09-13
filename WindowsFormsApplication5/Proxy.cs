using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security;
using System.Collections;
using System.Diagnostics;
using System.Web;
using System.Threading;
using FastColoredTextBoxNS;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace WindowsFormsApplication5
{
    public partial class Proxy : MaterialSkin.Controls.MaterialForm
    {
        public Proxy()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        class Defaults
        {
            public Regex REGEX = new Regex(@"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\:[0-9]{1,5}\b");
        }

        private void GatherTheProxies()
        {
            try
            {
                WebClient _WC = new WebClient();
                Defaults _DF = new Defaults();

                foreach (string Source in TB_Sources.Lines)
                {
                    string UnparsedWebSource = _WC.DownloadString(TB_Sources.Text);

                    MatchCollection _MC = _DF.REGEX.Matches(UnparsedWebSource);
                    foreach (Match Proxy2 in _MC)
                    {
                        LB_GatheredProxies.Items.Add(Proxy2);
                        //LB_GatheredProxies.Text = Proxy2;
                    }
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void Proxy_Load(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.hwidcheck();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            GatherTheProxies();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Notepad = new OpenFileDialog();
                Notepad.Filter = "Text Files (.txt)|*.txt";
                Notepad.Title = "Open a file...";
                if (Notepad.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(Notepad.FileName);
                    TB_Sources.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch
            {
                MessageBox.Show("You didn't select a txt file to open!.", "Red -Error");
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog NotepadSave = new SaveFileDialog();
                NotepadSave.Filter = "Text Files (.txt)|*.txt";
                NotepadSave.Title = "Save a file...";
                if (NotepadSave.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(NotepadSave.FileName);
                    sw.Write(TB_Sources.Text);
                    sw.Close();
                }
            }
            catch
            {
                MessageBox.Show("You didn't select a place to save the txt file!.", "Red - Error");
            }
        }
    }
 }

