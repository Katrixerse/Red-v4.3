using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using FastColoredTextBoxNS;

namespace WindowsFormsApplication5
{
    public partial class Editor : MaterialSkin.Controls.MaterialForm
    {
        public Editor()
        {
            InitializeComponent();
        }

        private TextStyle SlateGrey = new TextStyle(Brushes.SlateGray, null, FontStyle.Regular);

        private TextStyle Blue = new TextStyle(Brushes.Blue, null, FontStyle.Regular);

        private TextStyle Teal = new TextStyle(Brushes.Teal, null, FontStyle.Regular);

        private TextStyle Red = new TextStyle(Brushes.Red, null, FontStyle.Bold);

        private TextStyle c = new TextStyle(Brushes.Blue, null, FontStyle.Bold);

        private TextStyle VB = new TextStyle(Brushes.Blue, null, FontStyle.Bold);

        private TextStyle Comments = new TextStyle(Brushes.Green, null, FontStyle.Bold);

        private void Editor_Load(object sender, EventArgs e)
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

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.WordWrap = true;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.WordWrap = false;
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Notepad = new OpenFileDialog();
                Notepad.Filter = "Text Files (.txt)|*.txt";
                Notepad.Title = "Open a file...";
                if (Notepad.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(Notepad.FileName);
                    fastColoredTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch
            {
                MessageBox.Show("You didn't select a txt file to open!.", "Red -Error");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show("You didn't select a place to save the txt file!.", "Red -Error");
                }
            }
        }

        private void saveAsToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog NotePadC = new PrintDialog();
            if (NotePadC.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Print();
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
    }
}
