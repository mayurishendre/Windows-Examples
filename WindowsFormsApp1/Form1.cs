using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pwd = txtboxPassword.Text;
            if(txtboxUsername.Text=="admin"&& txtboxPassword.Text=="admin")
            {
                MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                frmMainMDI mdi = new frmMainMDI();
                mdi.Show();
                this.Hide();
            }
            else
            {
                DialogResult dr = MessageBox.Show("invalid Username or Password", "Error", MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                if(dr==DialogResult.Retry)
                {
                    txtboxUsername.Clear();
                    txtboxPassword.Clear();
                    txtboxUsername.Focus();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
