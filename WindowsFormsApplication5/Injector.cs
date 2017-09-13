using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Security.Cryptography;
using System.Security;

namespace WindowsFormsApplication5
{
    public partial class Injector : MaterialSkin.Controls.MaterialForm
    {
        public Injector()
        {
            InitializeComponent();
        }

        public int GetProcessId(string proc)
        {
            return Process.GetProcessesByName(proc)[0].Id;
        }

        public void InjectDLL(IntPtr hProcess, string strDLLName)
        {
            {
                IntPtr intPtr;
                int length = strDLLName.Length + 1;
                IntPtr intPtr1 = Injector.VirtualAllocEx(hProcess, (IntPtr)0, (uint)length, 4096, 64);
                Injector.WriteProcessMemory(hProcess, intPtr1, strDLLName, (UIntPtr)((long)length), out intPtr);
                UIntPtr procAddress = Injector.GetProcAddress(Injector.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
                IntPtr intPtr2 = Injector.CreateRemoteThread(hProcess, (IntPtr)0, 0, procAddress, intPtr1, 0, out intPtr);
                int num = Injector.WaitForSingleObject(intPtr2, 10000);
                if (((long)num == (long)128 || (long)num == (long)258 ? false : (long)num != (long)-1))
                {
                    Injector.VirtualFreeEx(hProcess, intPtr1, (UIntPtr)((long)0), 32768);
                    Injector.CloseHandle(intPtr2);
                    Label19.Text = "Injected!";
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
                int processId = this.GetProcessId(textBox2.Text);
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

        private void Injector_Load(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton16_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "DLL (*.dll) |*.dll";
                openFileDialog1.ShowDialog();
                string FileName = null;
                FileName = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf("\\"));
                string DllFileName = FileName.Replace("\\", "");
                this.textBox5.Text = (DllFileName);
            }
            catch
            {
                MessageBox.Show("You didn't select a dll to add!.", "Red - Error");
            }
        }

        private void MaterialFlatButton14_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void MaterialFlatButton15_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void MaterialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MaterialCheckBox3_CheckedChanged(object sender, EventArgs e)
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

        private void MaterialCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            whitelistinject();
        }

        private void materialCheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "RobloxPlayerBeta";
        }

        private void MaterialFlatButton13_Click(object sender, EventArgs e)
        {
            whitelistinject();
        }
    }
}
