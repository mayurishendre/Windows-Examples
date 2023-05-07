using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Windows_Notepad
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

       

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxNotepad.Copy();

        }

        public string  rtb;
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog()==DialogResult.OK)
            {
                // richTextBox1.Font = fontDialog1.Font;
               // richTextBox1.SelectedText = fontDialog1.Font;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Filter = "Notepad File|*.txt|Word Pad File|*.rtf|AllFiles|*.*";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Fname = saveFileDialog1.FileName;
                if (Fname.EndsWith(".txt"))
                {
                    richTextBoxNotepad.SaveFile(Fname, RichTextBoxStreamType.PlainText);
                }
                else if (Fname.EndsWith(".txt"))
                {
                    richTextBoxNotepad.SaveFile(Fname, RichTextBoxStreamType.RichText);
                }
                else
                {
                    MessageBox.Show("invalid file format");
                }
            }
        }
        //find box or search box code
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string data = richTextBoxNotepad.Text;
            frmFind obj = new frmFind();
            //obj.ShowDialog(frmFind);
           
            obj.Getdata(data);
            obj.Show();

            richTextBoxNotepad.Text = rtb;

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();
           // help.getdata();
        }
    }
}
