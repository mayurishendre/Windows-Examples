
namespace Windows_SolutionName
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
            this.txtboxProjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxSolutionName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProjectName";
            // 
            // txtboxProjectName
            // 
            this.txtboxProjectName.Location = new System.Drawing.Point(373, 61);
            this.txtboxProjectName.Multiline = true;
            this.txtboxProjectName.Name = "txtboxProjectName";
            this.txtboxProjectName.Size = new System.Drawing.Size(304, 67);
            this.txtboxProjectName.TabIndex = 1;
            this.txtboxProjectName.TextChanged += new System.EventHandler(this.txtboxProjectName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "SolutionName";
            // 
            // txtboxSolutionName
            // 
            this.txtboxSolutionName.Location = new System.Drawing.Point(373, 251);
            this.txtboxSolutionName.Multiline = true;
            this.txtboxSolutionName.Name = "txtboxSolutionName";
            this.txtboxSolutionName.Size = new System.Drawing.Size(304, 76);
            this.txtboxSolutionName.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(114, 174);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 41);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtboxSolutionName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxProjectName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SolutionName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxProjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxSolutionName;
        private System.Windows.Forms.Button btnOk;
    }
}

