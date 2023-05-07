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
    public partial class frmMainMDI : Form
    {
        public frmMainMDI()
        {
            InitializeComponent();
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Country = cmbCountry.SelectedItem.ToString();
            switch(Country)
            {
                case "India":
                    cmbState.Items.Clear();
                    cmbState.Text = "-----Select-----";
                    cmbState.Items.Add("Maharashtra");
                    cmbState.Items.Add("Gujrat");
                    cmbState.Items.Add("Rajasthan");
                   // cmbState.Items.Add("MP");
                   // cmbState.Items.Add("Uttarakhand")

                    break;
                case "America":
                    cmbState.Items.Clear();
                    cmbState.Text = "-----Select------";
                    cmbState.Items.Add("Washington Dc");
                    cmbState.Items.Add("Florida");
                  //  cmbState.Items.Add("New Jersey");
                   // cmbState.Items.Add("Buffalo city");
                   cmbState.Items.Add("California");
                    break;

                case "Australia":
                    cmbState.Items.Clear();
                    cmbState.Text = "------Select------";
                    cmbState.Items.Add("Sydney");
                    cmbState.Items.Add("melbourne");
                    cmbState.Items.Add("canaberra");
                 //   cmbState.Items.Add("brisbane");
                  //  cmbState.Items.Add("Hobart");
                    break;
               
            }
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            string State = cmbState.SelectedItem.ToString();
            switch (State)
            {
                case "Maharashtra":
                    cmbCity.Items.Clear();
                    cmbCity.Text = "---Select---";
                    cmbCity.Items.Add("Nagpur");
                    cmbCity.Items.Add("Pune");
                    cmbCity.Items.Add("Nashik");
                    break;

                case " Gujrat":
                    cmbCity.Items.Clear();
                    cmbCity.Text = "---Select---";
                    cmbCity.Items.Add("Surat");
                    cmbCity.Items.Add("Vadodara");
                    cmbCity.Items.Add("Mehsana");
                    break;

                case "Rajasthan":
                    cmbCity.Items.Clear();
                    cmbCity.Text = "---Select---";
                    cmbCity.Items.Add("Jaipur");
                    cmbCity.Items.Add("Jodhpur");
                    cmbCity.Items.Add("Raipur");
                    break;

                case "Washington Dc":
                    cmbCity.Items.Clear();
                    cmbCity.Text = "---Select---";
                    cmbCity.Items.Add("AAAA");
                    cmbCity.Items.Add("AAA");
                    cmbCity.Items.Add("AA");
                    break;

                case "California":
                    cmbCity.Items.Clear();
                    cmbCity.Text = "---Select---";
                    cmbCity.Items.Add("BBBB");
                    cmbCity.Items.Add("BBB");
                    cmbCity.Items.Add("BB");
                    break;

                case "Florida":
                    cmbCity.Items.Clear();
                    cmbCity.Text = "---Select---";
                    cmbCity.Items.Add("CCCC");
                    cmbCity.Items.Add("CCC");
                    cmbCity.Items.Add("CC");
                    break;

                case "Sydney":
                    cmbCity.Items.Clear();
                    cmbCity.Text = "---Select---";
                    cmbCity.Items.Add("DDDD");
                    cmbCity.Items.Add("DDD");
                    cmbCity.Items.Add("DD");
                    break;

                case "Melbourne":
                    cmbCity.Items.Clear();
                    cmbCity.Text = "---Select---";
                    cmbCity.Items.Add("EEEE");
                    cmbCity.Items.Add("EEE");
                    cmbCity.Items.Add("EE");
                    break;

                case "Canaberra":
                    cmbCity.Items.Clear();
                    cmbCity.Text = "---Select---";
                    cmbCity.Items.Add("FFFF");
                    cmbCity.Items.Add("FFF");
                    cmbCity.Items.Add("FF");
                    break;
            }

        }
    }
}
