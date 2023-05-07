
namespace Windows_EmployeeInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxEmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtboxAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMobNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.lblBS = new System.Windows.Forms.Label();
            this.txtboxBS = new System.Windows.Forms.TextBox();
            this.txtboxGS = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvEmpInfo = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.btnGS = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 113);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // txtboxEmpName
            // 
            this.txtboxEmpName.Location = new System.Drawing.Point(217, 135);
            this.txtboxEmpName.Name = "txtboxEmpName";
            this.txtboxEmpName.Size = new System.Drawing.Size(354, 34);
            this.txtboxEmpName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // TxtboxAddress
            // 
            this.TxtboxAddress.Location = new System.Drawing.Point(217, 199);
            this.TxtboxAddress.Name = "TxtboxAddress";
            this.TxtboxAddress.Size = new System.Drawing.Size(354, 34);
            this.TxtboxAddress.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mobile No.";
            // 
            // txtMobNo
            // 
            this.txtMobNo.Location = new System.Drawing.Point(217, 260);
            this.txtMobNo.Name = "txtMobNo";
            this.txtMobNo.Size = new System.Drawing.Size(354, 34);
            this.txtMobNo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(217, 320);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(354, 34);
            this.txtboxEmail.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Designation";
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "Manager",
            "Software Engineer",
            "Java Developer",
            "Testing Engineer",
            ".net Engineer",
            ""});
            this.cmbDesignation.Location = new System.Drawing.Point(217, 369);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(354, 32);
            this.cmbDesignation.TabIndex = 10;
            // 
            // lblBS
            // 
            this.lblBS.AutoSize = true;
            this.lblBS.Location = new System.Drawing.Point(33, 435);
            this.lblBS.Name = "lblBS";
            this.lblBS.Size = new System.Drawing.Size(131, 25);
            this.lblBS.TabIndex = 11;
            this.lblBS.Text = "Basic Salary";
            // 
            // txtboxBS
            // 
            this.txtboxBS.Location = new System.Drawing.Point(217, 432);
            this.txtboxBS.Name = "txtboxBS";
            this.txtboxBS.Size = new System.Drawing.Size(354, 34);
            this.txtboxBS.TabIndex = 12;
            // 
            // txtboxGS
            // 
            this.txtboxGS.Location = new System.Drawing.Point(217, 487);
            this.txtboxGS.Name = "txtboxGS";
            this.txtboxGS.Size = new System.Drawing.Size(354, 34);
            this.txtboxGS.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(28, 557);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 37);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvEmpInfo
            // 
            this.dgvEmpInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpInfo.Location = new System.Drawing.Point(739, 138);
            this.dgvEmpInfo.Name = "dgvEmpInfo";
            this.dgvEmpInfo.RowHeadersWidth = 51;
            this.dgvEmpInfo.RowTemplate.Height = 24;
            this.dgvEmpInfo.Size = new System.Drawing.Size(549, 432);
            this.dgvEmpInfo.TabIndex = 16;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(747, 97);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(141, 25);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "Search Name";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(894, 94);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(233, 34);
            this.txtboxSearch.TabIndex = 18;
            // 
            // btnGS
            // 
            this.btnGS.Location = new System.Drawing.Point(19, 487);
            this.btnGS.Name = "btnGS";
            this.btnGS.Size = new System.Drawing.Size(167, 39);
            this.btnGS.TabIndex = 19;
            this.btnGS.Text = "Gross Salary";
            this.btnGS.UseVisualStyleBackColor = true;
            this.btnGS.Click += new System.EventHandler(this.btnGS_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(194, 557);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 37);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(354, 557);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 37);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1300, 675);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGS);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvEmpInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtboxGS);
            this.Controls.Add(this.txtboxBS);
            this.Controls.Add(this.lblBS);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMobNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtboxAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxEmpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Employee Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxEmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtboxAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMobNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Label lblBS;
        private System.Windows.Forms.TextBox txtboxBS;
        private System.Windows.Forms.TextBox txtboxGS;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvEmpInfo;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Button btnGS;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

