using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Petrol_Pump
{
    public partial class frmPetrolPump : Form
    {
        public frmPetrolPump()
        {
            InitializeComponent();
        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            int Amt = Convert.ToInt32(txtboxRs.Text);
            float TodayValue = Convert.ToSingle(textBox1.Text);

            txtboxLtr.Text = (Amt / TodayValue).ToString();
        }

        private void rdoRs_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoRs.Checked==true)
            {
                int Amt = Convert.ToInt32(txtboxRs.Text);
                float TodayValue = Convert.ToSingle(textBox1.Text);

                txtboxLtr.Text = (Amt / TodayValue).ToString();
            }
        }

        private void btnLtr_Click(object sender, EventArgs e)
        {
            float Ltr = Convert.ToSingle(txtboxLtr.Text);
           // int Amt = Convert.ToInt32(txtboxRs.Text);
            float TodayValue = Convert.ToSingle(textBox1.Text);
            txtboxRs.Text = (Ltr * TodayValue).ToString();
        }
    }
}
