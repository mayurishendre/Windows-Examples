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

namespace Windows_PictureBoxImageExample
{
    public partial class frmPictureBox : Form
    {
        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
          openFileDialog1.InitialDirectory = "C:\\";
          openFileDialog1.Filter = "JPEG File|*.jpeg|JPG File|*.jpg|Bitmap File|*.bmp|GIF File|*.gif|PNG File|*.png|All File|*.*";
           openFileDialog1.FilterIndex= 6;
            openFileDialog1.FileName = "";
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                pBoxUserImg.Image = Image.FromFile(openFileDialog1.FileName);
                pBoxUserImg.SizeMode = PictureBoxSizeMode.StretchImage;
            }     
        }

        private void frmPictureBox_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"E:\HD Pics");
            foreach(FileInfo fi in di.GetFiles())
            {
                
                lstFileList.Items.Add(fi.FullName);
            }

            timer1.Enabled = true;
        }

        private void lstFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            pBox2.Image = Image.FromFile(lstFileList.SelectedItem.ToString());
            pBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //string fname = lstFileList.Items[i].ToString();
            //pBox2.Image = Image.FromFile(fname);
            //pBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            //if (i == lstFileList.Items.Count-1)
            //{
            //    i = 0;
            //}
            //else
            //{
            //    i++;
            //}
        }
}
}
