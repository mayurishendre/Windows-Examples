using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;     //step1

namespace Windows_EmployeeInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

       
        //step2
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=StudentinformationDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            //step3
            SqlParameter p1 = new SqlParameter("@EmployeeName", SqlDbType.VarChar);
            p1.Value = txtboxEmpName.Text.ToUpper();                            //step4

            SqlParameter p2 = new SqlParameter("@Address", SqlDbType.VarChar);
            p2.Value = TxtboxAddress.Text.ToUpper();

            SqlParameter p3 = new SqlParameter("@MobileNo", SqlDbType.VarChar);
            p3.Value = txtMobNo.Text;

            SqlParameter p4 = new SqlParameter("@Email", SqlDbType.VarChar);
            p4.Value = txtboxEmail.Text;                   

            SqlParameter p5 = new SqlParameter("@Designation", SqlDbType.VarChar);
            p5.Value = cmbDesignation.SelectedItem.ToString();

            SqlParameter p6 = new SqlParameter("@BasicSalary", SqlDbType.VarChar);
            p6.Value = txtboxBS.Text;

            SqlParameter p7 = new SqlParameter("@GrossSalary", SqlDbType.VarChar);
            p7.Value = txtboxGS.Text;

            //step5
            cmd.Parameters.Clear();
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);

            //step6
            cmd.Connection = con;

            cmd.CommandText = "insert into EmplyoeeInfo(EmployeeName,Address,MobileNo,Email,Designation,BasicSalary,GrossSalary) values(@EmployeeName,@Address,@MobileNo,@Email,@Designation,@BasicSalary,@GrossSalary)";

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Save...");

            txtboxEmpName.Clear();
            TxtboxAddress.Clear();
            txtboxEmail.Clear();
            txtMobNo.Clear();
            txtboxBS.Clear();
            txtboxGS.Clear();
            cmbDesignation.Text = "...Select...";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from EmplyoeeInfo", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "EmplyoeeInfo");
            dgvEmpInfo.DataSource = ds.Tables[0];
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            string Query = "select * from EmplyoeeInfo where EmployeeName like'" + txtboxSearch.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "EmplyoeeInfo");
            dgvEmpInfo.DataSource = ds.Tables[0];
        }

        private void btnGS_Click(object sender, EventArgs e)
        {
            string GS;
            double TA, DA, HRA;

            TA = (Convert.ToDouble(txtboxBS.Text) * Convert.ToDouble(12.5) / (Convert.ToDouble(100)));
            DA = (Convert.ToDouble(txtboxBS.Text) * Convert.ToDouble(27.1) / (Convert.ToDouble(100)));
            HRA = (Convert.ToDouble(txtboxBS.Text) * Convert.ToDouble(33.5) / (Convert.ToInt32(100)));
            GS = (Convert.ToDouble (txtboxBS.Text) + TA + DA + HRA).ToString();
            txtboxGS.Text = GS;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
