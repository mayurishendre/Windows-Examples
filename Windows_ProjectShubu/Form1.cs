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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pwd = txtboxPassword.Text;
            if (txtboxUserID.Text == "admin" && txtboxPassword.Text == "admin")
            {
                MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AdminPage mdi = new AdminPage();
                mdi.Show();
                this.Hide();
            }
            if(txtboxPassword.Text == "student" && txtboxPassword.Text == "student")
            {
                MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                StudentPage mdi = new StudentPage();
                mdi.Show();
                this.Hide();
            }
            else
            {
                DialogResult dr = MessageBox.Show("invalid Username or Password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.Retry)
                {
                    txtboxUserID.Clear();
                    txtboxPassword.Clear();
                    txtboxUserID.Focus();
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
