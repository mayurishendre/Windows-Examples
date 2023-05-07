using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_SolutionName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtboxProjectName_TextChanged(object sender, EventArgs e)
        {
            txtboxSolutionName.Text = txtboxProjectName.Text;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("your project name is" + txtboxProjectName.Text,"Hello",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
        }
    }
}
