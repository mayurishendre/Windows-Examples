using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_ProjectShubu
{
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
        }

        public void StudentPage_Load(object sender, EventArgs e)
        {
            //btnAdd_Click();
          //  lstStud.Items.Add(lst.Text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Course Selected Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
