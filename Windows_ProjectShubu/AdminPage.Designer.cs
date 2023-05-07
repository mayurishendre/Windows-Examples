
namespace Windows_ProjectShubu
{
    partial class AdminPage
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
            this.txtboxCourseNames = new System.Windows.Forms.TextBox();
            this.lstAdmin = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelStudentEntry = new System.Windows.Forms.Label();
            this.dgvStudentData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Course Names";
            // 
            // txtboxCourseNames
            // 
            this.txtboxCourseNames.Font = new System.Drawing.Font("Marlett", 8.25F);
            this.txtboxCourseNames.Location = new System.Drawing.Point(23, 78);
            this.txtboxCourseNames.Multiline = true;
            this.txtboxCourseNames.Name = "txtboxCourseNames";
            this.txtboxCourseNames.Size = new System.Drawing.Size(286, 36);
            this.txtboxCourseNames.TabIndex = 1;
            // 
            // lstAdmin
            // 
            this.lstAdmin.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAdmin.FormattingEnabled = true;
            this.lstAdmin.ItemHeight = 24;
            this.lstAdmin.Location = new System.Drawing.Point(23, 133);
            this.lstAdmin.Name = "lstAdmin";
            this.lstAdmin.Size = new System.Drawing.Size(286, 196);
            this.lstAdmin.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(315, 78);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Courses";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(18, 367);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(154, 25);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "Courses Count";
            this.labelCount.Click += new System.EventHandler(this.labelCount_Click);
            // 
            // labelStudentEntry
            // 
            this.labelStudentEntry.AutoSize = true;
            this.labelStudentEntry.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentEntry.Location = new System.Drawing.Point(486, 36);
            this.labelStudentEntry.Name = "labelStudentEntry";
            this.labelStudentEntry.Size = new System.Drawing.Size(160, 25);
            this.labelStudentEntry.TabIndex = 5;
            this.labelStudentEntry.Text = "Student Entries";
            // 
            // dgvStudentData
            // 
            this.dgvStudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentData.Location = new System.Drawing.Point(491, 78);
            this.dgvStudentData.Name = "dgvStudentData";
            this.dgvStudentData.RowHeadersWidth = 51;
            this.dgvStudentData.RowTemplate.Height = 24;
            this.dgvStudentData.Size = new System.Drawing.Size(305, 267);
            this.dgvStudentData.TabIndex = 6;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStudentData);
            this.Controls.Add(this.labelStudentEntry);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstAdmin);
            this.Controls.Add(this.txtboxCourseNames);
            this.Controls.Add(this.label1);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxCourseNames;
        private System.Windows.Forms.ListBox lstAdmin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelStudentEntry;
        private System.Windows.Forms.DataGridView dgvStudentData;
    }
}