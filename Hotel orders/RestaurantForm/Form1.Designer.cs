
namespace RestaurantForm
{
    partial class frmHotelOrders
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxTblNo = new System.Windows.Forms.TextBox();
            this.txtboxWaiter = new System.Windows.Forms.TextBox();
            this.txtboxCode = new System.Windows.Forms.TextBox();
            this.txtboxParticular = new System.Windows.Forms.TextBox();
            this.txtboxAmount = new System.Windows.Forms.TextBox();
            this.txtboxQuantity = new System.Windows.Forms.TextBox();
            this.txtboxTotalAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Waiter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Particular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Amount";
            // 
            // txtboxTblNo
            // 
            this.txtboxTblNo.Location = new System.Drawing.Point(159, 27);
            this.txtboxTblNo.Name = "txtboxTblNo";
            this.txtboxTblNo.Size = new System.Drawing.Size(100, 22);
            this.txtboxTblNo.TabIndex = 7;
            
            // 
            // txtboxWaiter
            // 
            this.txtboxWaiter.Location = new System.Drawing.Point(536, 30);
            this.txtboxWaiter.Name = "txtboxWaiter";
            this.txtboxWaiter.Size = new System.Drawing.Size(100, 22);
            this.txtboxWaiter.TabIndex = 8;
            // 
            // txtboxCode
            // 
            this.txtboxCode.Location = new System.Drawing.Point(19, 118);
            this.txtboxCode.Name = "txtboxCode";
            this.txtboxCode.Size = new System.Drawing.Size(100, 22);
            this.txtboxCode.TabIndex = 9;
            this.txtboxCode.TextChanged += new System.EventHandler(this.txtboxCode_TextChanged);
            // 
            // txtboxParticular
            // 
            this.txtboxParticular.Location = new System.Drawing.Point(159, 118);
            this.txtboxParticular.Multiline = true;
            this.txtboxParticular.Name = "txtboxParticular";
            this.txtboxParticular.Size = new System.Drawing.Size(223, 31);
            this.txtboxParticular.TabIndex = 10;
            this.txtboxParticular.TextChanged += new System.EventHandler(this.txtboxParticular_TextChanged);
            // 
            // txtboxAmount
            // 
            this.txtboxAmount.Location = new System.Drawing.Point(436, 118);
            this.txtboxAmount.Name = "txtboxAmount";
            this.txtboxAmount.Size = new System.Drawing.Size(100, 22);
            this.txtboxAmount.TabIndex = 11;
            // 
            // txtboxQuantity
            // 
            this.txtboxQuantity.Location = new System.Drawing.Point(158, 256);
            this.txtboxQuantity.Name = "txtboxQuantity";
            this.txtboxQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtboxQuantity.TabIndex = 12;
            this.txtboxQuantity.TextChanged += new System.EventHandler(this.txtboxQuantity_TextChanged);
            // 
            // txtboxTotalAmount
            // 
            this.txtboxTotalAmount.Location = new System.Drawing.Point(158, 301);
            this.txtboxTotalAmount.Name = "txtboxTotalAmount";
            this.txtboxTotalAmount.Size = new System.Drawing.Size(100, 22);
            this.txtboxTotalAmount.TabIndex = 13;
            
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Type";
            // 
            // txtboxType
            // 
            this.txtboxType.Location = new System.Drawing.Point(159, 212);
            this.txtboxType.Name = "txtboxType";
            this.txtboxType.Size = new System.Drawing.Size(100, 22);
            this.txtboxType.TabIndex = 15;
            
            // 
            // frmHotelOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtboxTotalAmount);
            this.Controls.Add(this.txtboxQuantity);
            this.Controls.Add(this.txtboxAmount);
            this.Controls.Add(this.txtboxParticular);
            this.Controls.Add(this.txtboxCode);
            this.Controls.Add(this.txtboxWaiter);
            this.Controls.Add(this.txtboxTblNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHotelOrders";
            this.Text = "Restaurant aform";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxTblNo;
        private System.Windows.Forms.TextBox txtboxWaiter;
        private System.Windows.Forms.TextBox txtboxCode;
        private System.Windows.Forms.TextBox txtboxParticular;
        private System.Windows.Forms.TextBox txtboxAmount;
        private System.Windows.Forms.TextBox txtboxQuantity;
        private System.Windows.Forms.TextBox txtboxTotalAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxType;
    }
}

