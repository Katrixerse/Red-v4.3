using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApplication5
{
    public partial class EmailSender : MaterialSkin.Controls.MaterialForm
    {
        public EmailSender()
        {
            InitializeComponent();
        }

        private void EmailSender_Load(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.hwidcheck();
        }

        private void materialFlatButton34_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton35_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton35_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Notepad = new OpenFileDialog();
                Notepad.Filter = "Text Files (.txt)|*.txt";
                Notepad.Title = "Open a file...";
                if (Notepad.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(Notepad.FileName);
                    textBox12.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch
            {
                MessageBox.Show("You didn't select a txt file to open!.", "Red -Error");
            }
        }
    

        private void materialFlatButton34_Click_1(object sender, EventArgs e)
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

        Email frm2 = new Email();

        public void materialFlatButton33_Click(object sender, EventArgs e)
        {
            MailMessage mailMessage = new MailMessage()
            {
            
            From = new MailAddress(frm2.materialSingleLineTextField5.Text)
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
                Credentials = new NetworkCredential(frm2.materialSingleLineTextField5.Text, frm2.materialSingleLineTextField6.Text),
                Timeout = 25000
            };
            if (materialSingleLineTextField9 == null)
            {
                mailMessage.Attachments.Add(new Attachment(materialSingleLineTextField9.Text));
            }
            else
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
    }
}
