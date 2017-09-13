using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form3 : MaterialSkin.Controls.MaterialForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //this.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            timer1.Start();
            Form1 frm1 = new Form1();
            frm1.hwidcheck();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Settings frm2 = new Settings();
            frm2.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            label1.Left -= 5;
            pictureBox2.Left -= 5;
            label2.Left -= 5;
            pictureBox3.Left -= 5;
            label3.Left -= 5;
            pictureBox4.Left -= 5;
            label4.Left -= 5;
            pictureBox5.Left -= 5;
            label5.Left -= 5;
            pictureBox6.Left -= 5;
            label6.Left -= 5;
            pictureBox7.Left -= 5;
            label7.Left -= 5;
            pictureBox8.Left -= 5;
            label8.Left -= 5;
            pictureBox9.Left -= 5;
            label15.Left -= 5;
            if (pictureBox1.Left <= 520)
            {
                timer1.Stop();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Injector frm2 = new Injector();
            frm2.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Geoip frm2 = new Geoip();
            frm2.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Processk frm2 = new Processk();
            frm2.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Lag frm2 = new Lag();
            frm2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Editor frm2 = new Editor();
            frm2.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Spammer frm2 = new Spammer();
            frm2.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Email frm2 = new Email();
            frm2.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Proxy frm2 = new Proxy();
            frm2.ShowDialog();
        }
    }
}
