using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_ListBox
{
    public partial class frmCity : Form
    {
        public frmCity()
        {
            InitializeComponent();
        }

        private void lstState_SelectedIndexChanged(object sender, EventArgs e)
        {
            string State = lstState.SelectedItem.ToString();
            switch (State)
            {
                case "Maharashtra":
                    lstCity.Items.Clear();
                    lstCity.Text = "-----Select-----";
                    lstCity.Items.Add("AAA");
                    lstCity.Items.Add("AA");
                    lstCity.Items.Add("A");
                    break;


                case "Gujrat":
                    lstCity.Items.Clear();
                    lstCity.Text = "-----Select-----";
                    lstCity.Items.Add("BBB");
                    lstCity.Items.Add("BB");
                    lstCity.Items.Add("B");
                    break;


                case "Rajasthan":
                    lstCity.Items.Clear();
                    lstCity.Text = "-----Select-----";
                    lstCity.Items.Add("CCC");
                    lstCity.Items.Add("CC");
                    lstCity.Items.Add("C");
                    break;

                default :
                    lstCity.Text = "-----Select-----";
                    break;

            }
        }
    }
  
}
