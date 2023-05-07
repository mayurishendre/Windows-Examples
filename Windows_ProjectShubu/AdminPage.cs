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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
           
                lstAdmin.Items.Add(txtboxCourseNames.Text);
                txtboxCourseNames.Clear();
                txtboxCourseNames.Focus();

                labelCount.Text = lstAdmin.Items.Count.ToString();
            
        }

        private void labelCount_Click(object sender, EventArgs e)
        {

        }
    }
}
