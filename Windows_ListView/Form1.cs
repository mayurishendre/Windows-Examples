using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_ListView
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

       

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //columnHeader ch1=new ColumnHeader();
            listView1.Columns.Add(new ColumnHeader());
            listView1.Columns[0].Text = "Roll No";
            listView1.Columns[1].Width = 100;
            listView1.Columns[2].TextAlign = HorizontalAlignment.Left;
        }
    }
}
