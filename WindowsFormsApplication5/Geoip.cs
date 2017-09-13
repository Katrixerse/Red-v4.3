using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace WindowsFormsApplication5
{
    public partial class Geoip : MaterialSkin.Controls.MaterialForm
    {
        public Geoip()
        {
            InitializeComponent();
        }

        private void Geoip_Load(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.hwidcheck();
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

        private void materialFlatButton26_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
        }
    }
}
