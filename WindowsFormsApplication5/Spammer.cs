using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace WindowsFormsApplication5
{
    public partial class Spammer : MaterialSkin.Controls.MaterialForm
    {
        public Spammer()
        {
            InitializeComponent();
        }

        ImageFormat img; Bitmap bt; Graphics screenShot;

        private void Spammer_Load(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.hwidcheck();
        }

        private void MaterialFlatButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(materialSingleLineTextField1.Text))
            {
                MessageBox.Show("Spam speed needs a valid time", "Red error");
            }
            else
            {
                MessageBox.Show("Spam speed has been set", "Red - Speed");
                int myInt;
                bool isNumerical = int.TryParse(materialSingleLineTextField1.Text, out myInt);
                {
                    timer1.Interval = int.Parse(materialSingleLineTextField1.Text);
                }
            }
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

        private void MaterialFlatButton4_Click(object sender, EventArgs e)
        {
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(TextBox1.Text);
            SendKeys.Send("{Enter}");
        }
    }
}
