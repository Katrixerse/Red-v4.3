using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace WindowsFormsApplication5
{
    public partial class Settings : MaterialSkin.Controls.MaterialForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.hwidcheck();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer5.Start();
            pictureBox1.Left -= 10;
            label1.Left -= 10;
            pictureBox2.Left -= 7;
            label2.Left -= 10;
            pictureBox3.Left -= 10;
            label3.Left -= 10;
            label4.Left -= 10;
            textBox2.Left -= 10;
            pictureBox4.Left -= 7;
            tabControl1.Left -= 10;
            tabControl1.Width += 10;
            tabControl2.Left -= 10;
            tabControl2.Width += 10;
            if (pictureBox1.Left <= -142)
            {
                pictureBox2.Visible = false;
                timer1.Stop();
                pictureBox4.Visible = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox4.Left -= 10;
            if (pictureBox4.Location.X <= 20)
            {
                timer2.Stop();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            timer3.Start();
            //timer4.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 10;
            label1.Left += 10;
            pictureBox2.Left += 7;
            label2.Left += 10;
            pictureBox3.Left += 10;
            label3.Left += 10;
            label4.Left += 10;
            textBox2.Left += 10;
            pictureBox4.Left += 7;
            tabControl1.Left += 10;
            tabControl1.Width += 7;
            tabControl2.Left += 10;
            tabControl2.Width += 7;
            if (pictureBox1.Left >= 10)
            {
                pictureBox4.Visible = false;
                timer3.Stop();
                pictureBox2.Visible = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox4.Left += 7;
            if (pictureBox4.Location.X >= 140)
            {
                timer4.Stop();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left -= 7;
            if (pictureBox2.Location.X <= 135)
            {
                timer5.Stop();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl1.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = true;
            tabControl1.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void materialFlatButton22_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Lime;
            textBox2.BackColor = Color.Lime;
            label1.BackColor = Color.Lime;
            label2.BackColor = Color.Lime;
            label3.BackColor = Color.Lime;
            label4.BackColor = Color.Lime;
            pictureBox1.BackColor = Color.Lime;
            pictureBox2.BackColor = Color.Lime;
            pictureBox3.BackColor = Color.Lime;
            pictureBox4.BackColor = Color.Lime;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Lime800, Primary.Lime900, Primary.Lime500, Accent.Lime200, TextShade.WHITE);
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Blue;
            textBox2.BackColor = Color.Blue;
            label1.BackColor = Color.Blue;
            label2.BackColor = Color.Blue;
            label3.BackColor = Color.Blue;
            label4.BackColor = Color.Blue;
            pictureBox1.BackColor = Color.Blue;
            pictureBox2.BackColor = Color.Blue;
            pictureBox3.BackColor = Color.Blue;
            pictureBox4.BackColor = Color.Blue;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialFlatButton16_Click(object sender, EventArgs e)
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.Amber200, TextShade.WHITE);
        }

        private void materialFlatButton23_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Gray;
            textBox2.BackColor = Color.Gray;
            label1.BackColor = Color.Gray;
            label2.BackColor = Color.Gray;
            label3.BackColor = Color.Gray;
            label4.BackColor = Color.Gray;
            pictureBox1.BackColor = Color.Gray;
            pictureBox2.BackColor = Color.Gray;
            pictureBox3.BackColor = Color.Gray;
            pictureBox4.BackColor = Color.Gray;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialFlatButton15_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
            textBox2.BackColor = Color.Yellow;
            label1.BackColor = Color.Yellow;
            label2.BackColor = Color.Yellow;
            label3.BackColor = Color.Yellow;
            label4.BackColor = Color.Yellow;
            pictureBox1.BackColor = Color.Yellow;
            pictureBox2.BackColor = Color.Yellow;
            pictureBox3.BackColor = Color.Yellow;
            pictureBox4.BackColor = Color.Yellow;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.Yellow200, TextShade.WHITE);
        }

        private void materialFlatButton13_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.Green;
            label1.BackColor = Color.Green;
            label2.BackColor = Color.Green;
            label3.BackColor = Color.Green;
            label4.BackColor = Color.Green;
            pictureBox1.BackColor = Color.Green;
            pictureBox2.BackColor = Color.Green;
            pictureBox3.BackColor = Color.Green;
            pictureBox4.BackColor = Color.Green;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Indigo;
            textBox2.BackColor = Color.Indigo;
            label1.BackColor = Color.Indigo;
            label2.BackColor = Color.Indigo;
            label3.BackColor = Color.Indigo;
            label4.BackColor = Color.Indigo;
            pictureBox1.BackColor = Color.Indigo;
            pictureBox2.BackColor = Color.Indigo;
            pictureBox3.BackColor = Color.Indigo;
            pictureBox4.BackColor = Color.Indigo;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo200, TextShade.WHITE);
        }

        private void materialFlatButton24_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Purple;
            textBox2.BackColor = Color.Purple;
            label1.BackColor = Color.Purple;
            label2.BackColor = Color.Purple;
            label3.BackColor = Color.Purple;
            label4.BackColor = Color.Purple;
            pictureBox1.BackColor = Color.Purple;
            pictureBox2.BackColor = Color.Purple;
            pictureBox3.BackColor = Color.Purple;
            pictureBox4.BackColor = Color.Purple;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE);
        }

        private void materialFlatButton21_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Pink;
            textBox2.BackColor = Color.Pink;
            label1.BackColor = Color.Pink;
            label2.BackColor = Color.Pink;
            label3.BackColor = Color.Pink;
            label4.BackColor = Color.Pink;
            pictureBox1.BackColor = Color.Pink;
            pictureBox2.BackColor = Color.Pink;
            pictureBox3.BackColor = Color.Pink;
            pictureBox4.BackColor = Color.Pink;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink800, Primary.Pink900, Primary.Pink500, Accent.Pink200, TextShade.WHITE);
        }

        private void materialFlatButton14_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Teal;
            textBox2.BackColor = Color.Teal;
            label1.BackColor = Color.Teal;
            label2.BackColor = Color.Teal;
            label3.BackColor = Color.Teal;
            label4.BackColor = Color.Teal;
            pictureBox1.BackColor = Color.Teal;
            pictureBox2.BackColor = Color.Teal;
            pictureBox3.BackColor = Color.Teal;
            pictureBox4.BackColor = Color.Teal;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE);
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Orange;
            textBox2.BackColor = Color.Orange;
            label1.BackColor = Color.Orange;
            label2.BackColor = Color.Orange;
            label3.BackColor = Color.Orange;
            label4.BackColor = Color.Orange;
            pictureBox1.BackColor = Color.Orange;
            pictureBox2.BackColor = Color.Orange;
            pictureBox3.BackColor = Color.Orange;
            pictureBox4.BackColor = Color.Orange;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
            textBox2.BackColor = Color.Red;
            label1.BackColor = Color.Red;
            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;
            label4.BackColor = Color.Red;
            pictureBox1.BackColor = Color.Red;
            pictureBox2.BackColor = Color.Red;
            pictureBox3.BackColor = Color.Red;
            pictureBox4.BackColor = Color.Red;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightGreen;
            textBox2.BackColor = Color.LightGreen;
            label1.BackColor = Color.LightGreen;
            label2.BackColor = Color.LightGreen;
            label3.BackColor = Color.LightGreen;
            label4.BackColor = Color.LightGreen;
            pictureBox1.BackColor = Color.LightGreen;
            pictureBox2.BackColor = Color.LightGreen;
            pictureBox3.BackColor = Color.LightGreen;
            pictureBox4.BackColor = Color.LightGreen;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightGreen800, Primary.LightGreen900, Primary.LightGreen500, Accent.LightGreen200, TextShade.WHITE);
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightBlue;
            textBox2.BackColor = Color.LightBlue;
            label1.BackColor = Color.LightBlue;
            label2.BackColor = Color.LightBlue;
            label3.BackColor = Color.LightBlue;
            label4.BackColor = Color.LightBlue;
            pictureBox1.BackColor = Color.LightBlue;
            pictureBox2.BackColor = Color.LightBlue;
            pictureBox3.BackColor = Color.LightBlue;
            pictureBox4.BackColor = Color.LightBlue;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialFlatButton7_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Purple;
            textBox2.BackColor = Color.Purple;
            label1.BackColor = Color.Purple;
            label2.BackColor = Color.Purple;
            label3.BackColor = Color.Purple;
            label4.BackColor = Color.Purple;
            pictureBox1.BackColor = Color.Purple;
            pictureBox2.BackColor = Color.Purple;
            pictureBox3.BackColor = Color.Purple;
            pictureBox4.BackColor = Color.Purple;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.DeepPurple800, Primary.DeepPurple900, Primary.DeepPurple500, Accent.DeepPurple200, TextShade.WHITE);
        }
    }
  }
