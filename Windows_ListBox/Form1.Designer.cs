
namespace Windows_ListBox
{
    partial class frmCity
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
            this.lstState = new System.Windows.Forms.ListBox();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "State";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "City";
            // 
            // lstState
            // 
            this.lstState.FormattingEnabled = true;
            this.lstState.ItemHeight = 16;
            this.lstState.Items.AddRange(new object[] {
            "Maharashtra",
            "Gujrat",
            "Rajasthan"});
            this.lstState.Location = new System.Drawing.Point(240, 112);
            this.lstState.Name = "lstState";
            this.lstState.Size = new System.Drawing.Size(306, 68);
            this.lstState.TabIndex = 2;
            this.lstState.SelectedIndexChanged += new System.EventHandler(this.lstState_SelectedIndexChanged);
            // 
            // lstCity
            // 
            this.lstCity.FormattingEnabled = true;
            this.lstCity.ItemHeight = 16;
            this.lstCity.Location = new System.Drawing.Point(249, 244);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(297, 68);
            this.lstCity.TabIndex = 3;
            
            // 
            // frmCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCity);
            this.Controls.Add(this.lstState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCity";
            this.Text = "CityList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstState;
        private System.Windows.Forms.ListBox lstCity;
    }
}

