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
    public partial class frmFind : Form
    {
        public frmFind()
        {
            InitializeComponent();

        }


        private void btnFindNext_Click(object sender, EventArgs e)
        {
            //  textBoxSerchBox.Text.Contains(string );
            textBoxSerchBox.Text.CompareTo(RichTextBoxFinds.WholeWord);
            // textBoxSerchBox.Text.Contains(rich);
            // Getdata();

            //frmMDI md = new frmMDI();
            //md.rtb() ;

            string words = textBoxSerchBox.Text;
            foreach(char word in words)
            {
                if(words==textBoxSerchBox.Text)
                {
                   // string Substring(int startIndexx);
                }
            }


        }
        public void Getdata(string obj)
        {
            textBoxSerchBox.Text = obj;
            if (textBoxSerchBox.Text == obj)
            {
                btnFindNext.Enabled = true;
            }


        }
        public void SubString(int startindex)
        {

        }
    }    
}
