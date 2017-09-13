using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication5
{
    public partial class Processk : MaterialSkin.Controls.MaterialForm
    {
        public Processk()
        {
            InitializeComponent();
        }

        Process[] procs;

        public int GetProcessId(string proc)
        {
            return Process.GetProcessesByName(proc)[0].Id;
        }

        public void RefreshList()
        {
            try
            {
                Process[] procs;
                procs = Process.GetProcesses();
                listBox1.Items.Clear();
                for (int i = 0; i < procs.Length; i++)
                {
                    listBox1.Items.Add(procs[i].ProcessName);
                }
            }
            catch
            {
                MessageBox.Show("A error occured with red!", "Red - Error");
            }
        }

        public void RefreshList2()
        {
            try
            {
                Process[] procs;
                procs = Process.GetProcesses();
                listBox2.Items.Clear();
                for (int i = 0; i < procs.Length; i++)
                {
                    listBox2.Items.Add(procs[i].Id);
                }
            }
            catch
            {
                MessageBox.Show("A error occured with red!", "Red - Error");
            }
        }

        private void Processk_Load(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.hwidcheck();
            RefreshList();
            RefreshList2();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            procs[listBox1.SelectedIndex].Kill();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            procs[listBox1.SelectedIndex].Kill();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            RefreshList();
            RefreshList2();
        }
    }
}
