
namespace Windows_Notepad
{
    partial class frmFind
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
            this.lblFind = new System.Windows.Forms.Label();
            this.textBoxSerchBox = new System.Windows.Forms.TextBox();
            this.checkBoxMatch = new System.Windows.Forms.CheckBox();
            this.checkBoxWrap = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.Location = new System.Drawing.Point(59, 63);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(91, 21);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "Find What";
            // 
            // textBoxSerchBox
            // 
            this.textBoxSerchBox.Location = new System.Drawing.Point(156, 64);
            this.textBoxSerchBox.Multiline = true;
            this.textBoxSerchBox.Name = "textBoxSerchBox";
            this.textBoxSerchBox.Size = new System.Drawing.Size(224, 38);
            this.textBoxSerchBox.TabIndex = 1;
            // 
            // checkBoxMatch
            // 
            this.checkBoxMatch.AutoSize = true;
            this.checkBoxMatch.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMatch.Location = new System.Drawing.Point(63, 144);
            this.checkBoxMatch.Name = "checkBoxMatch";
            this.checkBoxMatch.Size = new System.Drawing.Size(108, 24);
            this.checkBoxMatch.TabIndex = 2;
            this.checkBoxMatch.Text = "Match case";
            this.checkBoxMatch.UseVisualStyleBackColor = true;
            // 
            // checkBoxWrap
            // 
            this.checkBoxWrap.AutoSize = true;
            this.checkBoxWrap.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWrap.Location = new System.Drawing.Point(63, 184);
            this.checkBoxWrap.Name = "checkBoxWrap";
            this.checkBoxWrap.Size = new System.Drawing.Size(98, 24);
            this.checkBoxWrap.TabIndex = 3;
            this.checkBoxWrap.Text = "wrap case";
            this.checkBoxWrap.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(252, 143);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(391, 143);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 21);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnFindNext
            // 
            this.btnFindNext.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindNext.Location = new System.Drawing.Point(415, 63);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(128, 39);
            this.btnFindNext.TabIndex = 6;
            this.btnFindNext.Text = "Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // frmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(591, 264);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBoxWrap);
            this.Controls.Add(this.checkBoxMatch);
            this.Controls.Add(this.textBoxSerchBox);
            this.Controls.Add(this.lblFind);
            this.Name = "frmFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox textBoxSerchBox;
        private System.Windows.Forms.CheckBox checkBoxMatch;
        private System.Windows.Forms.CheckBox checkBoxWrap;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnFindNext;
    }
}