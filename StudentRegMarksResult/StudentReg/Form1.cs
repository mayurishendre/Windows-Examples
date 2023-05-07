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

namespace StudentReg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=StudentRegDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();

           
        

        private void btnSave_Click(object sender, EventArgs e)
        {
          

            cmd.Connection = con;
            cmd.CommandText = "insert into tblStudentMarks values('" + textBoxStudentName.Text.ToUpper() + "'," +
                                                                "'" + textBoxEng.Text + "'," +
                                                                "'" + textBoxMarathi.Text + "'," +
                                                                "'" + textBoxMaths.Text + "'," +
                                                                "'" + textBoxPhy.Text + "'," +
                                                                "'" + textBoxHindi.Text + "','" + textBoxTotal.Text + "','" + textBoxPercentage.Text + "'," +
                                                                "'" + textBoxStatus.Text.ToUpper() + "')";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("...Record Save...");

            textBoxStudentName.Clear();
            textBoxEng.Clear();
            textBoxHindi.Clear();
            textBoxMarathi.Clear();
            textBoxMaths.Clear();
            textBoxPhy.Clear();
            textBoxTotal.Clear();
            textBoxPercentage.Clear();
            textBoxStatus.Clear();
        }

        int RNO;
        private void dgvStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;


            RNO = Convert.ToInt32(dgvStudentList.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxStudentName.Text = dgvStudentList.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxEng.Text = dgvStudentList.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxHindi.Text = dgvStudentList.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxMarathi.Text = dgvStudentList.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxMaths.Text = dgvStudentList.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxPhy.Text = dgvStudentList.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBoxTotal.Text = dgvStudentList.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBoxPercentage.Text = dgvStudentList.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBoxStatus.Text = dgvStudentList.Rows[e.RowIndex].Cells[9].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmd.Connection = con;
            
            cmd.CommandText = "Update tblStudentMarks set StudentName='" + textBoxStudentName.Text.ToUpper() 
                + "',English='" + textBoxEng.Text
                 + "',Marathi='" + textBoxMarathi.Text
                  + "',Maths='" + textBoxMaths.Text
                   + "',Physics='" + textBoxPhy.Text
                    + "',Hindi='" + textBoxHindi.Text
                     + "',TotalMarks='" + textBoxTotal.Text
                      + "',Percentage='" + textBoxPercentage.Text
                       + "',Status='" + textBoxStatus.Text.ToUpper()
                + "'where Rno= " + RNO;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("...Record Updated Successfully...");
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Delete this Record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            cmd.CommandText = "delete from tblStudentMarks where Rno=" + RNO;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("...Record Deleted Successfully...");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblStudentMarks", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "tblStudentMarks");
            dgvStudentList.DataSource = ds.Tables[0];

            foreach (DataGridViewRow Rw in dgvStudentList.Rows)
            {

                if (Convert.ToInt32(Rw.Cells[8].Value) <=45 )
                {
                    Rw.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            string Query = "select * from tblStudentMarks where StudentName like'" + txtboxSearch.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "tblStudentMarks");
            dgvStudentList.DataSource = ds.Tables[0];
        }

        private void textBoxTotal_Click(object sender, EventArgs e)
        {

            int Total = Convert.ToInt32(textBoxMarathi.Text) +Convert.ToInt32( textBoxEng.Text) +
                Convert.ToInt32( textBoxHindi.Text) +Convert.ToInt32( textBoxMaths.Text )+Convert.ToInt32 (textBoxPhy.Text);

            textBoxTotal.Text = (Total).ToString();
            int Per = (Total / 5);
            textBoxPercentage.Text = (Per).ToString();


            if (Per >= 55)
            {
                textBoxStatus.Text = "Pass";
            }
            else
            {
                textBoxStatus.Text = "Fail";

                //foreach (DataGridViewRow Rw in dgvStudentList.Rows)
                //{

                //    if (Convert.ToInt32(Rw.Cells[8].Value)<=45)
                //    {
                //        Rw.DefaultCellStyle.BackColor = Color.Red;
                //    }
                //}
            }
            
        }
    }
}
