using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  //step1
using System.IO;

namespace Windows_RegistrationForm
{
    public partial class frmRegistrationWithoutParameter : Form
    {
        public frmRegistrationWithoutParameter()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = StudentinformationDB; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();

        string Gender=null;
        string studentImg=null;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(rdoMale.Checked==true)
            {
                Gender = rdoMale.Text;
            }
            if(rdoFemale.Checked==true)
            {
                Gender = rdoFemale.Text;
            }

            cmd.Connection = con;
            cmd.CommandText = "insert into StudentDetail values('" + txtboxStudentName.Text.ToUpper() + "'," +
                                                                "'" + txtboxAddress.Text.ToUpper() + "'," +
                                                                "'" + txtboxCity.Text.ToUpper() + "'," +
                                                                "'" + txtboxPhoneNo.Text + "'," +
                                                                "'" + dtpDOB.Value.ToShortDateString() + "'," +
                                                                "'" + Gender + "','" + cmbQualification.SelectedItem + "'," +
                                                                "'" + studentImg + "')";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("...Record Save...");

            txtboxStudentName.Clear();
            txtboxAddress.Clear();
            txtboxCity.Clear();
            txtboxPhoneNo.Clear();
            cmbQualification.SelectedItem = "...select...";
            studentImg = null;
            pboxImage = null;
            dtpDOB.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "E:\\HD Pics";
            
            openFileDialog1.Filter = "JPEG file|.*jpeg|JPG File|.*jpg|GIF File|.*gif |PNG File|.*png |Bitmap File|.*bmp|All Files|*.*";
            openFileDialog1.FilterIndex = 6;
            openFileDialog1.FileName = "";

            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                studentImg = openFileDialog1.FileName;
                pboxImage.Image = Image.FromFile(openFileDialog1.FileName);
                pboxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        int SID;
        string browsImg = null;

        private void dgvRegWithoutParameter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;
          
            SID = Convert.ToInt32(dgvRegList.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtboxStudentName.Text = dgvRegList.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtboxAddress.Text = dgvRegList.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtboxCity.Text = dgvRegList.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtboxPhoneNo.Text = dgvRegList.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpDOB.Value = Convert.ToDateTime(dgvRegList.Rows[e.RowIndex].Cells[5].Value.ToString());

            if (dgvRegList.Rows[e.RowIndex].Cells[6].Value.ToString() == "Male")
            {
                rdoMale.Checked = true;

            }
            if (dgvRegList.Rows[e.RowIndex].Cells[6].Value.ToString() == "Female")
            {
                rdoFemale.Checked = true;

            }
            cmbQualification.Text =dgvRegList.Rows[e.RowIndex].Cells[7].Value.ToString();

            if (dgvRegList.Rows[e.RowIndex].Cells[8].Value == "")
            {
                dgvRegList.Rows[e.RowIndex].Cells[8].Value = @"C:\Users\ASUS\Desktop\xceller\WindowsFormExample\Windows_RegistrationForm\Resources\839458.jpg";
                studentImg= @"C:\Users\ASUS\Desktop\xceller\WindowsFormExample\Windows_RegistrationForm\Resources\839458.jpg";
            }
            else
            {
                pboxImage.Image = Image.FromFile(dgvRegList.Rows[e.RowIndex].Cells[8].Value.ToString());
            }
            
            pboxImage.SizeMode = PictureBoxSizeMode.StretchImage;

            browsImg = dgvRegList.Rows[e.RowIndex].Cells[8].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rdoMale.Checked == true)
            {
                Gender = rdoMale.Text;
            }
            if (rdoFemale.Checked == true)
            {
                Gender = rdoFemale.Text;
            }
            cmd.Connection = con;
            cmd.CommandText ="Update StudentDetail set StudentName='"+txtboxStudentName.Text.ToUpper()+"',StudentAddress='"+txtboxAddress.Text.ToUpper()
                +"',City='"+txtboxCity.Text.ToUpper()
                +"',Phone='"+txtboxPhoneNo.Text
                +"',DateOfBirth='"+dtpDOB.Value.ToShortDateString()
                +"',Gender='"+Gender
                +"',Qualification='"+cmbQualification.SelectedItem
                +"',StudentImage='"+studentImg+"'where StudentID="+SID;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("...Record Updated Successfully...");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Delete this Record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            cmd.CommandText = "delete from StudentDetail where studentID=" + SID;
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("...Record Deleted Successfully...");
        }

        private void frmRegistrationWithoutParameter_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from StudentDetail", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "StudentDetail");
            dgvRegList.DataSource = ds.Tables[0];
        }

        private void txtboxPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            int k = e.KeyChar;
            if(k>=48 && k<=57||k==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtboxStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            int k = e.KeyChar;
            if((k>=65 && k<=90)||(k>=97 && k<=122)||(k==8)||(k==32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void lblRegistrationWithoutparameter_Click(object sender, EventArgs e)
        {

        }
    }
}
