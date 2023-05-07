using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Notepad
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Notepad File|*.txt|Word Pad File|*.rtf|AllFiles|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.FileName = "";
           if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                
                //string Fname = saveFileDialog1.FileName;
                //if (Fname.EndsWith(".txt"))
                //{
                //    richTextBoxNotepad.SaveFile(Fname, RichTextBoxStreamType.PlainText);
                //}
                //else if (Fname.EndsWith(".txt"))
                //{
                //    richTextBoxNotepad.SaveFile(Fname, RichTextBoxStreamType.RichText);
                //}
                //else
                //{
                //    MessageBox.Show("invalid file format");
               // }
            }
           
        }
        public void getdata(string data)
        {
              
        }
    }
}
