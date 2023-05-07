using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalculater
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtboxResult.Text = (Convert.ToInt32(txtboxNum1.Text) + Convert.ToInt32(txtboxNum2.Text)).ToString();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            txtboxResult.Text = (Convert.ToInt32(txtboxNum1.Text) - Convert.ToInt32(txtboxNum2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtboxResult.Text = (Convert.ToInt32(txtboxNum1.Text) * Convert.ToInt32(txtboxNum2.Text)).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtboxResult.Text = (Convert.ToInt32(txtboxNum1.Text) / Convert.ToInt32(txtboxNum2.Text)).ToString();
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            int Number = Convert.ToInt32(txtboxNum1.Text);
            int fact = Convert.ToInt32(txtboxResult.Text);
            for(fact=1;Number>=1;Number--)
            {

                fact = fact * Number;
                    
            }

        }

        private void BtnPercentage_Click(object sender, EventArgs e)
        {
            float num1 = Convert.ToSingle(txtboxNum1.Text).ToString();
            int const= Convert.ToSingle(label100).ToString();
            txtboxResult.Text = (num1 / Const);

        }

        private void btnXSq_Click(object sender, EventArgs e)
        {
            txtboxResult.Text = (Convert.ToInt32(txtboxNum1.Text) * Convert.ToInt32(txtboxNum1.Text)).ToString();
        }

        private void btnPie_Click(object sender, EventArgs e)
        {
            float Pi = Convert.ToSingle(btnPie.Text);
        }
    }
}
