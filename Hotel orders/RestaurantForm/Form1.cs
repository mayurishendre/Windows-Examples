using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace RestaurantForm
{
    public partial class frmHotelOrders : Form
    {
        public frmHotelOrders()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

       

        private void txtboxCode_TextChanged(object sender, EventArgs e)
        {
            string choice = txtboxCode.Text + "";
            switch (choice)
            {
                case "CD":
                    
                    txtboxParticular.Text = "ColdDrink";
                    txtboxType.Text = "G";
                    txtboxAmount.Text = "50";
                    break;

                case "B":
                    txtboxParticular.Text = "Biryani";
                    if (txtboxType.Text == "H")
                    {
                        txtboxAmount.Text = "30";
                    }
                    else
                    {
                        txtboxAmount.Text = " 60";
                    }
                    break;

                case "C":
                    txtboxParticular.Text = "curry";
                    if (txtboxType.Text == "H")
                    {
                        txtboxAmount.Text = "60";
                    }
                    else
                    {
                        txtboxAmount.Text = " 90";
                    }
                    break;

                case "R":
                    txtboxParticular.Text = "Rice";
                    if (txtboxType.Text == "H")
                    {
                        txtboxAmount.Text = "30";
                    }
                    else
                    {
                        txtboxAmount.Text = " 70";
                    }                
                    break;

                default:
                    txtboxParticular.Text = "NOT MATCH";
                    break;

            }
            //if (txtboxCode.Text=="CD" || txtboxCode.Text=="cd")
            //{
            //    txtboxParticular.Text = "ColdDrink";
               

            //}
            //else if(txtboxCode.Text=="B"||txtboxCode.Text=="b")
            //{
            //    txtboxParticular.Text = "Biryani";
            //}
            //else if(txtboxCode.Text == "C" || txtboxCode.Text == "c")
            //{
            //    txtboxParticular.Text = "Curry";
            //}
            //else if (txtboxCode.Text == "R" || txtboxCode.Text == "r")
            //{
            //    txtboxParticular.Text = "Rice";
            //}

        }

        private void txtboxParticular_TextChanged(object sender, EventArgs e)
        {
            //string choice = "";
            //switch (choice)
            //{
            //    case "CD":
            //        txtboxParticular.Text = "ColdDrink";
            //        if (txtboxQuantity.Text == "H")
            //        {
            //            txtboxAmount.Text = "30";
            //        }
            //        else
            //        {
            //            txtboxAmount.Text = "60";
            //        }

            //        break;
        }

        //private void txtboxType_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtboxType.Text == "H")
        //    {
        //        txtboxAmount.Text = "30";
        //    }
        //    else
        //    {
        //       txtboxAmount.Text = " 60";
        //    }
        //}

      

        private void txtboxQuantity_TextChanged(object sender, EventArgs e)
        {
            
            int Qty = Convert.ToInt32(txtboxQuantity.Text);
            int Amt = Convert.ToInt32(txtboxAmount.Text);
            if(txtboxType.Text=="H")
            {
                txtboxTotalAmount.Text = (Qty * Amt).ToString();
            }
            else
            {
                txtboxTotalAmount.Text = (Qty * Amt).ToString();
            }

        

        }
    }
}
