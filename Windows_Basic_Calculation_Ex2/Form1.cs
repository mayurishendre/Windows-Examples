using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Basic_Calculation_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            txtboxArea.Text = ((0.5f) * Convert.ToInt32(txtboxBase.Text) *
                Convert.ToInt32(txtboxHeight.Text)).ToString();
                
        }

        private void btnEqualTo_Click(object sender, EventArgs e)
        {
            int side1 = Convert.ToInt32(txtboxSide1.Text);
            int side2 = Convert.ToInt32(txtboxSide2.Text);
            int side3 = Convert.ToInt32(txtboxSide3.Text);


            txtboxPerimeter.Text = (side1 + side2 + side3).ToString();
        }
    }
}
