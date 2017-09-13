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
    public partial class Email : MaterialSkin.Controls.MaterialForm
    {
        public Email()
        {
            InitializeComponent();
        }

        private void Email_Load(object sender, EventArgs e)
        {

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
                    EmailSender frm2 = new EmailSender();
                    this.Hide();
                    frm2.ShowDialog();
                    this.Close();
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

        public void materialSingleLineTextField6_Click(object sender, EventArgs e)
        {

        }

        public void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }
    }
}
