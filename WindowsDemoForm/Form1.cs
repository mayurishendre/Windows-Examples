using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDemoForm
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtboxAns.Text = (Convert.ToInt32(txtboxNum1.Text) +
                Convert.ToInt32(txtboxNum2.Text)).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtboxAns.Text = (Convert.ToInt32(txtboxNum1.Text) -
                Convert.ToInt32(txtboxNum2.Text)).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtboxAns.Text = (Convert.ToInt32(txtboxNum1.Text) * 
                Convert.ToInt32(txtboxNum2.Text)).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtboxAns.Text = (Convert.ToInt32(txtboxNum1.Text) /
                Convert.ToInt32(txtboxNum2.Text)).ToString();
        }
    }
}
