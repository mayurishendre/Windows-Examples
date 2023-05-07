
namespace Windows_PictureBoxImageExample
{
    partial class frmPictureBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPictureBox));
            this.pBoxBat = new System.Windows.Forms.PictureBox();
            this.pBoxUserImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseImg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstFileList = new System.Windows.Forms.ListBox();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUserImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxBat
            // 
            this.pBoxBat.Image = ((System.Drawing.Image)(resources.GetObject("pBoxBat.Image")));
            this.pBoxBat.Location = new System.Drawing.Point(33, 30);
            this.pBoxBat.Name = "pBoxBat";
            this.pBoxBat.Size = new System.Drawing.Size(249, 227);
            this.pBoxBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxBat.TabIndex = 0;
            this.pBoxBat.TabStop = false;
            // 
            // pBoxUserImg
            // 
            this.pBoxUserImg.Location = new System.Drawing.Point(308, 30);
            this.pBoxUserImg.Name = "pBoxUserImg";
            this.pBoxUserImg.Size = new System.Drawing.Size(245, 227);
            this.pBoxUserImg.TabIndex = 1;
            this.pBoxUserImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Simple";
            // 
            // btnBrowseImg
            // 
            this.btnBrowseImg.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImg.Location = new System.Drawing.Point(365, 298);
            this.btnBrowseImg.Name = "btnBrowseImg";
            this.btnBrowseImg.Size = new System.Drawing.Size(141, 44);
            this.btnBrowseImg.TabIndex = 3;
            this.btnBrowseImg.Text = "Browse";
            this.btnBrowseImg.UseVisualStyleBackColor = true;
            this.btnBrowseImg.Click += new System.EventHandler(this.btnBrowseImg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstFileList
            // 
            this.lstFileList.FormattingEnabled = true;
            this.lstFileList.HorizontalScrollbar = true;
            this.lstFileList.ItemHeight = 16;
            this.lstFileList.Location = new System.Drawing.Point(308, 405);
            this.lstFileList.Name = "lstFileList";
            this.lstFileList.Size = new System.Drawing.Size(528, 212);
            this.lstFileList.TabIndex = 4;
            this.lstFileList.SelectedIndexChanged += new System.EventHandler(this.lstFileList_SelectedIndexChanged);
            // 
            // pBox2
            // 
            this.pBox2.Location = new System.Drawing.Point(33, 403);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(249, 215);
            this.pBox2.TabIndex = 5;
            this.pBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 673);
            this.Controls.Add(this.pBox2);
            this.Controls.Add(this.lstFileList);
            this.Controls.Add(this.btnBrowseImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBoxUserImg);
            this.Controls.Add(this.pBoxBat);
            this.Name = "frmPictureBox";
            this.Text = "frmPictureBoxExample";
            this.Load += new System.EventHandler(this.frmPictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUserImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxBat;
        private System.Windows.Forms.PictureBox pBoxUserImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lstFileList;
        private System.Windows.Forms.PictureBox pBox2;
        private System.Windows.Forms.Timer timer1;
    }
}

