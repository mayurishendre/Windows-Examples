
namespace Windows_RegistrationForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.pBoxStudentImage = new System.Windows.Forms.PictureBox();
            this.txtboxQualification = new System.Windows.Forms.TextBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtboxPhone = new System.Windows.Forms.TextBox();
            this.txtboxCity = new System.Windows.Forms.TextBox();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.txtboxStudentName = new System.Windows.Forms.TextBox();
            this.lblQualification = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.lstRollNo = new System.Windows.Forms.ListBox();
            this.listViewSD = new System.Windows.Forms.ListView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportDocument1 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnImage);
            this.groupBox1.Controls.Add(this.pBoxStudentImage);
            this.groupBox1.Controls.Add(this.txtboxQualification);
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.txtboxPhone);
            this.groupBox1.Controls.Add(this.txtboxCity);
            this.groupBox1.Controls.Add(this.txtboxAddress);
            this.groupBox1.Controls.Add(this.txtboxStudentName);
            this.groupBox1.Controls.Add(this.lblQualification);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblDob);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblcity);
            this.groupBox1.Controls.Add(this.lbladd);
            this.groupBox1.Controls.Add(this.lblStudentName);
            this.groupBox1.Location = new System.Drawing.Point(5, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 468);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "StudentDetails";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(398, 409);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 40);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(205, 408);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 42);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(7, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(549, 211);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(137, 46);
            this.btnImage.TabIndex = 8;
            this.btnImage.Text = "Browse Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // pBoxStudentImage
            // 
            this.pBoxStudentImage.Location = new System.Drawing.Point(530, 11);
            this.pBoxStudentImage.Name = "pBoxStudentImage";
            this.pBoxStudentImage.Size = new System.Drawing.Size(182, 180);
            this.pBoxStudentImage.TabIndex = 17;
            this.pBoxStudentImage.TabStop = false;
            // 
            // txtboxQualification
            // 
            this.txtboxQualification.Location = new System.Drawing.Point(173, 341);
            this.txtboxQualification.Multiline = true;
            this.txtboxQualification.Name = "txtboxQualification";
            this.txtboxQualification.Size = new System.Drawing.Size(327, 35);
            this.txtboxQualification.TabIndex = 7;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(361, 299);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(75, 21);
            this.rdoFemale.TabIndex = 6;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(223, 299);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(59, 21);
            this.rdoMale.TabIndex = 5;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(173, 251);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(327, 22);
            this.dtpDOB.TabIndex = 4;
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.Location = new System.Drawing.Point(173, 195);
            this.txtboxPhone.Multiline = true;
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.Size = new System.Drawing.Size(327, 36);
            this.txtboxPhone.TabIndex = 3;
            // 
            // txtboxCity
            // 
            this.txtboxCity.Location = new System.Drawing.Point(173, 142);
            this.txtboxCity.Multiline = true;
            this.txtboxCity.Name = "txtboxCity";
            this.txtboxCity.Size = new System.Drawing.Size(327, 33);
            this.txtboxCity.TabIndex = 2;
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(173, 76);
            this.txtboxAddress.Multiline = true;
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(327, 52);
            this.txtboxAddress.TabIndex = 1;
            // 
            // txtboxStudentName
            // 
            this.txtboxStudentName.Location = new System.Drawing.Point(173, 28);
            this.txtboxStudentName.Multiline = true;
            this.txtboxStudentName.Name = "txtboxStudentName";
            this.txtboxStudentName.Size = new System.Drawing.Size(327, 32);
            this.txtboxStudentName.TabIndex = 0;
            // 
            // lblQualification
            // 
            this.lblQualification.AutoSize = true;
            this.lblQualification.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualification.Location = new System.Drawing.Point(17, 351);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(137, 25);
            this.lblQualification.TabIndex = 8;
            this.lblQualification.Text = "Qualification";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(19, 299);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(83, 25);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(30, 251);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(61, 25);
            this.lblDob.TabIndex = 6;
            this.lblDob.Text = "DOB";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(19, 195);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(72, 25);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcity.Location = new System.Drawing.Point(30, 139);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(53, 25);
            this.lblcity.TabIndex = 4;
            this.lblcity.Text = "City";
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladd.Location = new System.Drawing.Point(19, 85);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(90, 25);
            this.lbladd.TabIndex = 1;
            this.lbladd.Text = "Address";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(10, 28);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(144, 25);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student name";
            // 
            // lblRegistration
            // 
            this.lblRegistration.Font = new System.Drawing.Font("Mistral", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRegistration.Location = new System.Drawing.Point(12, 9);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(733, 94);
            this.lblRegistration.TabIndex = 1;
            this.lblRegistration.Text = "Registration";
            this.lblRegistration.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRegistration.Click += new System.EventHandler(this.lblRegistration_Click);
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Location = new System.Drawing.Point(764, 60);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.RowHeadersWidth = 51;
            this.dgvStudentList.RowTemplate.Height = 24;
            this.dgvStudentList.Size = new System.Drawing.Size(530, 262);
            this.dgvStudentList.TabIndex = 2;
            this.dgvStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentList_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(933, 12);
            this.txtboxSearch.Multiline = true;
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(236, 42);
            this.txtboxSearch.TabIndex = 18;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(770, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search Name";
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(1320, 394);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(114, 42);
            this.btnGetReport.TabIndex = 20;
            this.btnGetReport.Text = "Get Report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // lstRollNo
            // 
            this.lstRollNo.FormattingEnabled = true;
            this.lstRollNo.ItemHeight = 16;
            this.lstRollNo.Location = new System.Drawing.Point(764, 334);
            this.lstRollNo.Name = "lstRollNo";
            this.lstRollNo.Size = new System.Drawing.Size(131, 228);
            this.lstRollNo.TabIndex = 21;
            this.lstRollNo.SelectedIndexChanged += new System.EventHandler(this.lstRollNo_SelectedIndexChanged);
            // 
            // listViewSD
            // 
            this.listViewSD.HideSelection = false;
            this.listViewSD.Location = new System.Drawing.Point(913, 334);
            this.listViewSD.Name = "listViewSD";
            this.listViewSD.Size = new System.Drawing.Size(284, 243);
            this.listViewSD.TabIndex = 22;
            this.listViewSD.UseCompatibleStateImageBehavior = false;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(1203, 340);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(91, 49);
            this.btnDisplay.TabIndex = 23;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(1320, 336);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(114, 37);
            this.btnGetData.TabIndex = 24;
            this.btnGetData.Text = "GetData";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(562, 588);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(150, 150);
            this.crystalReportViewer1.TabIndex = 25;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(1320, 60);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(400, 262);
            this.crystalReportViewer2.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1771, 589);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.listViewSD);
            this.Controls.Add(this.lstRollNo);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.dgvStudentList);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStudentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtboxStudentName;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.PictureBox pBoxStudentImage;
        private System.Windows.Forms.TextBox txtboxQualification;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtboxPhone;
        private System.Windows.Forms.TextBox txtboxCity;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.ListBox lstRollNo;
        private System.Windows.Forms.ListView listViewSD;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnGetData;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
    }
}

