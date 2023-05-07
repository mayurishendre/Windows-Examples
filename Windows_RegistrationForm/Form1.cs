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
using System.IO;

namespace Windows_RegistrationForm
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
            try
            {
                MemoryStream ms = new MemoryStream();
                
                pBoxStudentImage.Image.Save(ms, pBoxStudentImage.Image.RawFormat);
                Byte[] image1 = ms.GetBuffer();
                ms.Close();

                //step3
                SqlParameter p1 = new SqlParameter("@StudentName", SqlDbType.VarChar);
                p1.Value = txtboxStudentName.Text.ToUpper();                                    //step4

                SqlParameter p2 = new SqlParameter("@StudentAddress", SqlDbType.VarChar);
                p2.Value = txtboxAddress.Text.ToUpper();

                SqlParameter p3 = new SqlParameter("@City", SqlDbType.VarChar);
                p3.Value = txtboxCity.Text.ToUpper();

                SqlParameter p4 = new SqlParameter("@Phone", SqlDbType.VarChar);
                p4.Value = txtboxPhone.Text;

                SqlParameter p5 = new SqlParameter("@DateOfBirth", SqlDbType.Date);
                p5.Value = dtpDOB.Value;

                SqlParameter p6 = new SqlParameter("@Gender", SqlDbType.VarChar);
                if (rdoMale.Checked == true)
                {
                    p6.Value = rdoMale.Text;
                }
                if (rdoFemale.Checked == true)
                {
                    p6.Value = rdoFemale.Text;
                }

                SqlParameter p7 = new SqlParameter("@Qualification", SqlDbType.VarChar);
                p7.Value = txtboxQualification.Text;

                SqlParameter p8 = new SqlParameter("@StudentImage", SqlDbType.Image);
                p8.Value = image1;

                //step5
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);

                //step6
                cmd.Connection = con;

                cmd.CommandText = "insert into StudentDetail(StudentName,StudentAddress,City,Phone,DateOfBirth,Gender,Qualification,StudentImage)" +
                    " values(@StudentName,@StudentAddress,@City,@Phone,@DateOfBirth,@Gender,@Qualification,@StudentImage)";

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Save...");
                // LoadRecord();

                //step7
                txtboxAddress.Clear();
                txtboxCity.Clear();
                txtboxStudentName.Clear();
                txtboxPhone.Clear();
                // txtboxQualification.Text = "....Select....";
               // xtboxQualification.

                if (rdoMale.Checked == true)
                {
                    rdoMale.Checked = false;
                }
                if (rdoFemale.Checked == true)
                {
                    rdoFemale.Checked = false;
                }
                StudentImage = null;
                pBoxStudentImage.Image = null;
                dtpDOB.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        string StudentImage = null;
        int SID;
        private void btnImage_Click(object sender, EventArgs e)   //browse img
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "JPEG File|.*jpeg|JPG File|.*jpg|GIF File|.*gif|PNG File|.*png|Bitmap File|.*bmp|All Files|*.*";
                openFileDialog1.FilterIndex = 6;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StudentImage = openFileDialog1.FileName;
               pBoxStudentImage.Image = Image.FromFile(openFileDialog1.FileName);
                pBoxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
   
        private void txtboxSearch_TextChanged(object sender, EventArgs e)   //code for search student name
        {
            string Query = "select * from StudentDetail where StudentName like'" + txtboxSearch.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "StudentDetail");
            dgvStudentList.DataSource = ds.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)      //gridview code for storing record
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from StudentDetail", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "StudentDetail");
            dgvStudentList.DataSource = ds.Tables[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //code for updating img
            MemoryStream ms = new MemoryStream();

            pBoxStudentImage.Image.Save(ms, pBoxStudentImage.Image.RawFormat);
            Byte[] image1 = ms.GetBuffer();
            ms.Close();


            SqlParameter p1 = new SqlParameter("@StudentName", SqlDbType.VarChar);
            p1.Value = txtboxStudentName.Text.ToUpper();
            SqlParameter p2 = new SqlParameter("@StudentAddress", SqlDbType.VarChar);
            p2.Value = txtboxAddress.Text.ToUpper();
            SqlParameter p3 = new SqlParameter("@City", SqlDbType.VarChar);
            p3.Value = txtboxCity.Text.ToUpper();
            SqlParameter p4 = new SqlParameter("@Phone", SqlDbType.VarChar);
            p4.Value = txtboxPhone.Text;
            SqlParameter p5 = new SqlParameter("@DateOfBirth", SqlDbType.Date);
                p5.Value = dtpDOB.Value;
            SqlParameter p6 = new SqlParameter("@Gender", SqlDbType.VarChar);
            if(rdoMale.Checked==true)
            {
                p6.Value = rdoMale.Text;
            }
            if(rdoFemale.Checked==true)
            {
                p6.Value = rdoFemale.Text;
            }
            SqlParameter p7 = new SqlParameter("@Qualification", SqlDbType.VarChar);
            p7.Value = txtboxQualification.Text;

            SqlParameter p8 = new SqlParameter("@StudentImage", SqlDbType.Image);
            p8.Value =image1;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);

            cmd.Connection = con;

           

           // str = "Update StudentDetail set StudentImage=@StudentImage where StudentID=" + SID;


            cmd.CommandText = "Update StudentDetail set StudentName=@StudentName,StudentAddress=@StudentAddress," +
                                                           "City=@City,Phone=@Phone,DateOfBirth=@DateOfBirth,Gender=@Gender,Qualification=@Qualification," +
                                                            "StudentImage=@StudentImage where StudentID ="+ SID;

           
           

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show ( "...Updated Record...");
            
            
        }

        private void dgvStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MemoryStream ms = new MemoryStream();

            //pBoxStudentImage.Image.Save(ms, pBoxStudentImage.Image.RawFormat);
            //Byte[] image1 = ms.GetBuffer();
            //ms.Close();


            btnSave.Enabled = false;
            SID = Convert.ToInt32(dgvStudentList.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtboxStudentName.Text = dgvStudentList.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtboxAddress.Text=dgvStudentList.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtboxCity.Text=dgvStudentList.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtboxPhone.Text = dgvStudentList.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpDOB.Value = Convert.ToDateTime(dgvStudentList.Rows[e.RowIndex].Cells[5].Value.ToString());

            if(dgvStudentList.Rows[e.RowIndex].Cells[6].Value.ToString()=="Male")
            {
                rdoMale.Checked = true;

            }
            if(dgvStudentList.Rows[e.RowIndex].Cells[6].Value.ToString()=="Female")
            {
                rdoFemale.Checked = true;

            }
            txtboxQualification.Text=dgvStudentList.Rows[e.RowIndex].Cells[7].Value.ToString();
            
           // pBoxStudentImage.Image.Save(ms, pBoxStudentImage.Image.RawFormat);
           // image1


             pBoxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;

            StudentImage = dgvStudentList.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Delete this Record?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            cmd.CommandText = "delete from StudentDetail where studentID=" + SID;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void lstRollNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string Query = "select * from StudentDetail where StudentID=" + lstRollNo.SelectedItem;
            //SqlDataReader sdr;
            //cmd.Connection = con;
            //cmd.CommandText = Query;
            //con.Open();
            //sdr = cmd.ExecuteReader();
            //while(sdr.Read())
            //{
            //    SID = Convert.ToInt32(sdr[0].ToString());
            //    txtboxStudentName.Text = sdr[1].ToString();
            //    txtboxAddress.Text = sdr[2].ToString();
            //    txtboxCity.Text = sdr[3].ToString();
            //    txtboxPhone.Text = sdr[4].ToString();
            //    dtpDOB.Text = sdr[5].ToString();
            //    if (rdoMale.Checked == true)
            //    {
            //        rdoMale.Text = sdr[6].ToString();
            //    }
            //    if(rdoFemale.Checked==true)
            //    {
            //        rdoFemale.Text = sdr[6].ToString();
            //    }
            //    txtboxQualification.Text = sdr[7].ToString();
            //    StudentImage = sdr[8].ToString();
            //}
            //con.Close();
           // lstRollNo.Items.Add(txtboxStudentName.Text);
           // txtboxStudentName.Clear();
           // txtboxStudentName.Focus();
              

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            
                 //columnHeader ch1=new ColumnHeader();
            listViewSD.Columns.Add(new ColumnHeader());
            listViewSD.Columns[0].Text = "StudentId";
            listViewSD.Columns[0].Width = 100;
            listViewSD.Columns[0].TextAlign = HorizontalAlignment.Left;

            listViewSD.Columns.Add(new ColumnHeader());
            listViewSD.Columns[1].Text = "StudentName";
            listViewSD.Columns[1].Width = 100;
            listViewSD.Columns[1].TextAlign = HorizontalAlignment.Left;

            listViewSD.Columns.Add(new ColumnHeader());
            listViewSD.Columns[2].Text = "StudentAddress";
            listViewSD.Columns[2].Width = 200;
            listViewSD.Columns[2].TextAlign = HorizontalAlignment.Left;

            listViewSD.Columns.Add(new ColumnHeader());
            listViewSD.Columns[3].Text= "City";
            listViewSD.Columns[3].Width = 200;
            listViewSD.Columns[3].TextAlign = HorizontalAlignment.Left;

            listViewSD.Columns.Add(new ColumnHeader());
            listViewSD.Columns[4].Text = "Phone";
            listViewSD.Columns[4].Width = 200;
            listViewSD.Columns[4].TextAlign = HorizontalAlignment.Left;

            listViewSD.Columns.Add(new ColumnHeader());
            listViewSD.Columns[5].Text = "DateOfBirth";
            listViewSD.Columns[5].Width = 200;
            listViewSD.Columns[5].TextAlign = HorizontalAlignment.Left;

            listViewSD.Columns.Add(new ColumnHeader());
            listViewSD.Columns[6].Text = "Gender";
            listViewSD.Columns[6].Width = 200;
            listViewSD.Columns[6].TextAlign = HorizontalAlignment.Left;

            listViewSD.Columns.Add(new ColumnHeader());
            listViewSD.Columns[7].Text = "Qualification";
            listViewSD.Columns[7].Width = 300;
            listViewSD.Columns[7].TextAlign = HorizontalAlignment.Left;

            listViewSD.View = View.Details;
            ListViewItem l1 = new ListViewItem();

            int i=0;
           

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select StudentID,StudentName,StudentAddress,City,phone,DateOfBirth,Gender,Qualification from StudentDetail";
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                l1 = listViewSD.Items.Add(dr.GetValue(0).ToString(),i); //to add main item
                l1.SubItems.Add(dr.GetValue(1).ToString());           //to add subitem
                l1.SubItems.Add(dr.GetValue(2).ToString());
                l1.SubItems.Add(dr.GetValue(3).ToString());
                l1.SubItems.Add(dr.GetValue(4).ToString());
                l1.SubItems.Add(dr.GetValue(5).ToString());
                l1.SubItems.Add(dr.GetValue(6).ToString());
                l1.SubItems.Add(dr.GetValue(7).ToString());
                i++;
               
            }
            con.Close();

           // listViewSD.LargeImageList = ImageList;
           // listViewSD.SmallImageList = ImageList;
            

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {

        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
        }

        private void lblRegistration_Click(object sender, EventArgs e)
        {

        }
    }
}
