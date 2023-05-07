using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_AddList
{
    public partial class frmAddListbox : Form
    {
        public frmAddListbox()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstItemList.Items.Add(txtboxItemName.Text);
            txtboxItemName.Clear();
            txtboxItemName.Focus();

            lblCount.Text = lstItemList.Items.Count.ToString();
        }

        private void lstItemList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }
    }
}
