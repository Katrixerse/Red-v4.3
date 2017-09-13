using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace WindowsFormsApplication5
{
    public partial class Lag : MaterialSkin.Controls.MaterialForm
    {
        public Lag()
        {
            InitializeComponent();
        }

        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwflags, int dx, int dy, int cbuttons, int dwExtraInfo);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool GetCursorPos(out Point lpPoint);
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Keys vkeys);
        public static int xPos, yPos;

        private void Lag_Load(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.hwidcheck();
        }

        private void materialFlatButton21_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label13.Text = "Lagging";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "ipconfig /release";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(materialSingleLineTextField1.Text))
            {
                MessageBox.Show("Lag Switch speed needs a valid time", "Red error");
            }
            else
            {
                MessageBox.Show("Lag switch speed has been set", "Red - Speed");
                int myInt;
                bool isNumerical = int.TryParse(materialSingleLineTextField1.Text, out myInt);
                {
                    timer1.Interval = int.Parse(materialSingleLineTextField1.Text);
                }
            }
        }

        private void materialFlatButton23_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton22_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label13.Text = "Connected";
        }
    }
}
