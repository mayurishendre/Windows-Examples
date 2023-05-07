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

namespace Windows_RegistrationForm
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=StudentinformationDB;Integrated Security=True");
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            string Query;
            Query = "select StudentID,StudentName,StudentAddress,City,Phone,Gender,DateOfBirth,Qualification from StudentDetail";
            
            SqlDataAdapter sda = new SqlDataAdapter(Query,con);

            DataSet ds = new DataSet();
            sda.Fill(ds,"StudentDetail");
            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(ds.Tables["StudentDetail"]);
            crystalReportViewer1.ReportSource = cr;

           
        }
    }
}
