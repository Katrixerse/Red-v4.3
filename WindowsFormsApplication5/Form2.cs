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
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        Process[] procs;

        private TextStyle SlateGrey = new TextStyle(Brushes.SlateGray, null, FontStyle.Regular);

        private TextStyle Blue = new TextStyle(Brushes.Blue, null, FontStyle.Regular);

        private TextStyle Teal = new TextStyle(Brushes.Teal, null, FontStyle.Regular);

        private TextStyle Red = new TextStyle(Brushes.Red, null, FontStyle.Bold);

        private TextStyle c = new TextStyle(Brushes.Blue, null, FontStyle.Bold);

        private TextStyle VB = new TextStyle(Brushes.Blue, null, FontStyle.Bold);

        private TextStyle Comments = new TextStyle(Brushes.Green, null, FontStyle.Bold);

        public void internetcheck()
        {
            bool internet = NetworkInterface.GetIsNetworkAvailable();
            if (internet == false)
            {
                MessageBox.Show("Error occurred sorry!. please restart and try again", "Red");
                Application.Exit();
            }
        }

        public void InjectDLL(IntPtr hProcess, string strDLLName)
        {
            {
                IntPtr intPtr;
                int length = strDLLName.Length + 1;
                IntPtr intPtr1 = Form2.VirtualAllocEx(hProcess, (IntPtr)0, (uint)length, 4096, 64);
                Form2.WriteProcessMemory(hProcess, intPtr1, strDLLName, (UIntPtr)((long)length), out intPtr);
                UIntPtr procAddress = Form2.GetProcAddress(Form2.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
                IntPtr intPtr2 = Form2.CreateRemoteThread(hProcess, (IntPtr)0, 0, procAddress, intPtr1, 0, out intPtr);
                int num = Form2.WaitForSingleObject(intPtr2, 10000);
                if (((long)num == (long)128 || (long)num == (long)258 ? false : (long)num != (long)-1))
                {
                    Form2.VirtualFreeEx(hProcess, intPtr1, (UIntPtr)((long)0), 32768);
                    Form2.CloseHandle(intPtr2);
                    Label17.Text = "Injected!";
                }
                else
                {
                    Form2.CloseHandle(intPtr2);
                }
            }
        }

        public void whitelistinject()
        {
            try
            {
                string str = string.Concat(AppDomain.CurrentDomain.BaseDirectory, textBox5.Text);
                str = string.Concat(str, "Dlls\\" + textBox5.Text);
                string str1 = string.Concat(AppDomain.CurrentDomain.BaseDirectory, textBox5.Text);
                int processId = this.GetProcessId(TextBox2.Text);
                if (processId >= 0)
                {
                    IntPtr intPtr = Form2.OpenProcess(2035711, 1, processId);
                    this.InjectDLL(intPtr, str1);
                }
            }
            catch
            {
                MessageBox.Show("Error injecting the dll!");
                System.Environment.Exit(0);
            }
        }

        [DllImport("kernel32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int CloseHandle(IntPtr hObject);

        [DllImport("kernel32", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, UIntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out IntPtr lpThreadId);

        [DllImport("kernel32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", CharSet = CharSet.None, ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", CharSet = CharSet.None, ExactSpelling = true, SetLastError = true)]
        private static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint dwFreeType);

        [DllImport("kernel32", CharSet = CharSet.None, ExactSpelling = true, SetLastError = true)]
        internal static extern int WaitForSingleObject(IntPtr handle, int milliseconds);

        [DllImport("kernel32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, string lpBuffer, UIntPtr nSize, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = false)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
        public static extern UIntPtr GetProcAddress(IntPtr hModule, string procName);

        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwflags, int dx, int dy, int cbuttons, int dwExtraInfo);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Keys vkeys);
        public static int xPos, yPos;

        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern new bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern new int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        public int GetProcessId(string proc)
        {
            return Process.GetProcessesByName(proc)[0].Id;
        }

        public void ProcessCheck()
        {
            try
            {
                string HWID = string.Empty;//creating a empty string
                System.Management.ManagementClass Management = new System.Management.ManagementClass("win32_processor");//declaring the system management calss
                System.Management.ManagementObjectCollection MObject = Management.GetInstances();//decalring the system management object collection 
                IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
                foreach (IPAddress address in localIP)
                    foreach (System.Management.ManagementObject mob in MObject)//having a foreach loop
                    {
                        if (address.AddressFamily == AddressFamily.InterNetwork)
                            textBox6.Text = address.ToString();
                        HWID = mob.GetPropertyValue("processorID").ToString();//converting the HWID to string
                        textBox7.Text = HWID;
                        break;
                    }
            }
            catch
            {
                MessageBox.Show("A error occured with the whitelist now closing please try again!.", "Red - Error!");
            }
        }

        public Form2()
        {
            InitializeComponent();

            // double check measures 
        }

        public void RefreshList()
        {
            try {
                Process[] procs;
                procs = Process.GetProcesses();
                    listBox1.Items.Clear();
                    for (int i = 0; i < procs.Length; i++)
                    {
                        listBox1.Items.Add(procs[i].ProcessName);
                    }
            } catch
            {
                MessageBox.Show("A error occured with red!", "Red - Error");
            }
                }

       public void RefreshList2()
        {
            try {
        Process[] procs;
        procs = Process.GetProcesses();
                listBox2.Items.Clear();
                    for (int i = 0; i < procs.Length; i++)
                    {
                        listBox2.Items.Add(procs[i].Id);
                    }
            } catch
            {
                MessageBox.Show("A error occured with red!", "Red - Error");
            }
        }

        public void OnlineCheck()
        {
            try
            {
                System.Net.WebClient WC = new System.Net.WebClient();
                Form1 frm1 = new Form1();
                string http1 = WC.DownloadString("https://hades-hosting.000webhostapp.com/misc/hwid.txt");
                if (http1.Contains(textBox7.Text))
                {
                    //double checking something go away lawliet or gordon nothing to see
                }
                else
                {
                    MessageBox.Show("A error occured with the whitelist now closing!", "Red Wl Failed");
                    System.Environment.Exit(0);
                }
            }
            catch
            {
                MessageBox.Show("A error occured fetching the whitelist please try again", "Red error");
                System.Environment.Exit(0);
            }
        }


        ImageFormat img; Bitmap bt; Graphics screenShot;
        private void Form2_Load(object sender, EventArgs e)
        {
            RefreshList();
            RefreshList2();
            materialTabControl2.TabPages.Remove(tabPage10);
            materialTabControl2.Visible = false;
            ProcessCheck();
            OnlineCheck();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {
            materialTabControl1.Visible = true;
            materialTabControl2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(TextBox1.Text);
            SendKeys.Send("{Enter}");
        }

        private void MaterialFlatButton4_Click(object sender, EventArgs e)
        {
            ProcessCheck();
            OnlineCheck();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                Thread.Sleep(500);
                bt = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                screenShot = Graphics.FromImage(bt);
                screenShot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                switch (saveFileDialog1.FilterIndex)
                {
                    case 0: img = ImageFormat.Bmp; break;
                    case 1: img = ImageFormat.Png; break;
                    case 2: img = ImageFormat.Jpeg; break;
                }
                bt.Save(saveFileDialog1.FileName, img);
                this.Show();
            }
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton9_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void materialFlatButton10_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void materialFlatButton11_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void materialFlatButton7_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Undo();
        }

        private void materialFlatButton8_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Redo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                OpenFileDialog Notepad = new OpenFileDialog();
                Notepad.Filter = "Text Files (.txt)|*.txt";
                Notepad.Title = "Open a file...";
                if (Notepad.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(Notepad.FileName);
                    fastColoredTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
            } catch {
                MessageBox.Show("You didn't select a txt file to open!.", "Red -Error");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                try {
                    SaveFileDialog NotepadSave = new SaveFileDialog();
                    NotepadSave.Filter = "Text Files (.txt)|*.txt";
                    NotepadSave.Title = "Save a file...";
                    if (NotepadSave.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.StreamWriter sw = new System.IO.StreamWriter(NotepadSave.FileName);
                        sw.Write(fastColoredTextBox1.Text);
                        sw.Close();
                    }
                } catch {
                    MessageBox.Show("You didn't select a place to save the txt file!.", "Red -Error");
                }
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Undo();
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem1.Enabled = true;
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Redo();
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem1.Enabled = false;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void MaterialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MaterialCheckBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MaterialCheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton13_Click(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton14_Click(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton15_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void MaterialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton16_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton10_Click_1(object sender, EventArgs e)
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Lime800, Primary.Lime900, Primary.Lime500, Accent.Lime200, TextShade.WHITE);
        }

        private void MaterialFlatButton6_Click_1(object sender, EventArgs e)
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MaterialFlatButton9_Click_1(object sender, EventArgs e)
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.Amber200, TextShade.WHITE);
        }

        private void MaterialFlatButton5_Click(object sender, EventArgs e)
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
        }

        private void MaterialFlatButton8_Click_1(object sender, EventArgs e)
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.Yellow200, TextShade.WHITE);
        }

        private void MaterialFlatButton7_Click_1(object sender, EventArgs e)
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
        }

        private void MaterialFlatButton11_Click_1(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MaterialFlatButton18_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE);
        }

        private void MaterialFlatButton12_Click(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton17_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton12_Click_1(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink800, Primary.Pink900, Primary.Pink500, Accent.Pink200, TextShade.WHITE);
        }

        private void materialFlatButton17_Click_1(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE);
        }

        private void materialFlatButton19_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
        }

        private void materialFlatButton20_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo200, TextShade.WHITE);
        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Label17.Text = "Spamming";
        }

        private void MaterialFlatButton2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Label17.Text = "Stopped";
        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(materialSingleLineTextField1.Text)) {
                MessageBox.Show("Spam speed needs a valid time", "Red error");
            } else {
                MessageBox.Show("Spam speed has been set", "Red - Speed");
                int myInt;
                bool isNumerical = int.TryParse(materialSingleLineTextField1.Text, out myInt);
                {
                    timer1.Interval = int.Parse(materialSingleLineTextField1.Text);
                }
            }
        }

        private void fontSelectorToolStripMenuItem_Click(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
      
        }

        private void colorSelectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog NotePadC = new ColorDialog();
            if (NotePadC.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.ForeColor = NotePadC.Color;
            }
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regex rx = new Regex("class");
            int index = fastColoredTextBox1.SelectionStart;

            foreach (Match m in rx.Matches(fastColoredTextBox1.Text))
            {

                fastColoredTextBox1.Select();
                fastColoredTextBox1.SelectionColor = Color.Blue;
                fastColoredTextBox1.SelectionStart = index;
                fastColoredTextBox1.SelectionColor = Color.Black;

            }
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (fastColoredTextBox1.Text.Length > 0)
            {
                undoToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                selectAllToolStripMenuItem.Enabled = true;
                e.ChangedRange.SetStyle(c, @"\b(class|struct|enum|private|void|public|else|if)\s+(?<range>[\w_]+?)\b");
                e.ChangedRange.SetStyle(VB, "\\b(ERROR)\\b|#region\\b|#endregion\\b");
                e.ChangedRange.SetStyle(Comments, @"//.*$", RegexOptions.Multiline);
                e.ChangedRange.SetStyle(Comments, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
                e.ChangedRange.SetStyle(Comments, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline |
                            RegexOptions.RightToLeft);
            }
            else
            {
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                undoToolStripMenuItem.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
                selectAllToolStripMenuItem.Enabled = false;
            }
        }

        private void TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog NotepadSave = new SaveFileDialog();
                NotepadSave.Filter = "Text Files (.txt)|*.txt";
                NotepadSave.Title = "Save a file...";
                if (NotepadSave.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(NotepadSave.FileName);
                    sw.Write(fastColoredTextBox1.Text);
                    sw.Close();
                }
            }
            catch
            {
                MessageBox.Show("You didn't select a place to save the txt file!.", "Red - Error");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.SelectAll();
        }

        private void syntaxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog NotePadC = new PrintDialog();
            if (NotePadC.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Print();
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.WordWrap = true;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.WordWrap = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton16_Click_1(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "DLL (*.dll) |*.dll";
                openFileDialog1.ShowDialog();
                string FileName = null;
                FileName = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf("\\"));
                string DllFileName = FileName.Replace("\\", "");
                this.textBox5.Text = (DllFileName);
            } catch
            {
                MessageBox.Show("You didn't select a dll to add!.", "Red - Error");
            }
        }

        private void materialCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (this.TopMost == true)
                {
                    this.TopMost = false;
                }
                else
                {
                    if (this.TopMost == false)
                    {
                        this.TopMost = true;
                    }
                }
            }
        }

        private void materialCheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialCheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            TextBox2.Text = "RobloxPlayerBeta";
        }

        private void MaterialCheckBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (MaterialCheckBox3.Checked == true)
            {
                MaterialFlatButton13.Show();
            }
            else
            {
                if (MaterialCheckBox3.Checked == false)
                {
                    MaterialFlatButton13.Hide();
                }
            }
        }

        private void MaterialCheckBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            whitelistinject();
            timer1.Enabled = true;
        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton13_Click_1(object sender, EventArgs e)
        {
            whitelistinject();
        }

        private void materialTabSelector2_Click(object sender, EventArgs e)
        {
            RefreshList();
            RefreshList2();
            materialTabControl1.Visible = false;
            materialTabControl2.Visible = true;
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            procs[listBox1.SelectedIndex].Kill();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            procs[listBox1.SelectedIndex].Start();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void materialFlatButton21_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label13.Text = "Lagging";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "ipconfig /release";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void materialFlatButton22_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            label13.Text = "Normal";
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.LShiftKey) == -32767)
            {
                timer2.Start();
            }
            if (GetAsyncKeyState(Keys.LControlKey) == -32767)
            {
                timer2.Stop();
            }
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon in the next update", "Red - Error");
        }

        private void materialFlatButton24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon in the next update", "Red - Error");
        }

        private void materialFlatButton25_Click(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                if (materialSingleLineTextField4.Text == "") return;
                string str = webClient.DownloadString(string.Concat("https://api.apithis.net/geoip.php?ip=", materialSingleLineTextField4.Text));
                textBox9.Text = str.Replace("<br />", Environment.NewLine);
            }
        }

        private void materialFlatButton27_Click(object sender, EventArgs e)
        {
            try
            {
                if (materialSingleLineTextField5.Text.Split(new char[] { '@' })[1] != "gmail.com")
                {
                    MessageBox.Show("Please enter a valid gmail email address.");
                }
                else if (materialSingleLineTextField6.Text != "")
                {
                    materialTabControl2.TabPages.Remove(tabPage9);
                    materialTabControl2.TabPages.Add(tabPage10);
                }
                else
                {
                    MessageBox.Show("Please enter a password!");
                }
            }
            catch
            {
            }
        }

        private void materialFlatButton30_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton35_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog NotepadSave = new SaveFileDialog();
                NotepadSave.Filter = "Text Files (.txt)|*.txt";
                NotepadSave.Title = "Save a file...";
                if (NotepadSave.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(NotepadSave.FileName);
                    sw.Write(textBox12.Text);
                    sw.Close();
                }
            }
            catch
            {
                MessageBox.Show("You didn't select a place to save the txt file!.", "Red - Error");
            }
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton33_Click(object sender, EventArgs e)
        {
            MailMessage mailMessage = new MailMessage()
            {
                From = new MailAddress(materialSingleLineTextField5.Text)
            };
            mailMessage.To.Add(textBox12.Text);
            mailMessage.Subject = materialSingleLineTextField10.Text;
            mailMessage.Body = textBox10.Text;
            SmtpClient smtpClient = new SmtpClient()
            {
                UseDefaultCredentials = true,
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(materialSingleLineTextField5.Text, materialSingleLineTextField6.Text),
                Timeout = 25000
            };
            if (materialSingleLineTextField9 == null)
            {
                mailMessage.Attachments.Add(new Attachment(materialSingleLineTextField9.Text));
            } else
            try
            {
                try
                {
                    smtpClient.Send(mailMessage);
                    MessageBox.Show("Successfully sending the emails", "Red - Success");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error sending the emails", "Red - Error");
                }
            }
            finally
            {
                mailMessage.Dispose();
            }
        }

        private void materialFlatButton32_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "*.txt | *.lua | *.html | *.zip | *.rar | *.exe | *.dll | *.css";
                openFileDialog1.ShowDialog();
                string FileName = null;
                FileName = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf("\\"));
                string DllFileName = FileName.Replace("\\", "");
                this.textBox5.Text = (DllFileName);
            }
            catch
            {
                MessageBox.Show("You didn't select a attachment to add!.", "Red - Error");
            }
        }

        private void materialFlatButton34_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog NotepadSave = new SaveFileDialog();
                NotepadSave.Filter = "Text Files (.txt)|*.txt";
                NotepadSave.Title = "Save a file...";
                if (NotepadSave.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(NotepadSave.FileName);
                    sw.Write(textBox12.Text);
                    sw.Close();
                }
            }
            catch
            {
                MessageBox.Show("You didn't select a place to save the txt file!.", "Red - Error");
            }
        }

        private void materialTabSelector2_Click_1(object sender, EventArgs e)
        {
            materialTabControl1.Visible = false;
            materialTabControl2.Visible = true;
        }

        private void materialFlatButton26_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField4_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton15_Click_1(object sender, EventArgs e)
        {

        }

        private void MaterialCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void materialCheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton14_Click_1(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
    
