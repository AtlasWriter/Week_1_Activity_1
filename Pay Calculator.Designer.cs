namespace CST_150_WEEK_1_ACTIVITY_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hourlyRateInput = new System.Windows.Forms.TextBox();
            this.calculatePay = new System.Windows.Forms.Button();
            this.blackBox = new System.Windows.Forms.PictureBox();
            this.dontClickImage = new System.Windows.Forms.Label();
            this.cancelRequest = new System.Windows.Forms.Button();
            this.employeeFirstName = new System.Windows.Forms.TextBox();
            this.displayRequestedInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeLastName = new System.Windows.Forms.TextBox();
            this.employeeNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hoursWorkedInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Straight Time Hours Worked:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hourly Rate:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // hourlyRateInput
            // 
            this.hourlyRateInput.Location = new System.Drawing.Point(394, 142);
            this.hourlyRateInput.Margin = new System.Windows.Forms.Padding(2);
            this.hourlyRateInput.Name = "hourlyRateInput";
            this.hourlyRateInput.Size = new System.Drawing.Size(67, 23);
            this.hourlyRateInput.TabIndex = 5;
            // 
            // calculatePay
            // 
            this.calculatePay.Location = new System.Drawing.Point(280, 236);
            this.calculatePay.Margin = new System.Windows.Forms.Padding(2);
            this.calculatePay.Name = "calculatePay";
            this.calculatePay.Size = new System.Drawing.Size(110, 44);
            this.calculatePay.TabIndex = 6;
            this.calculatePay.Text = "Gross Pay";
            this.calculatePay.UseVisualStyleBackColor = true;
            this.calculatePay.Click += new System.EventHandler(this.calculatePay_Click);
            // 
            // blackBox
            // 
            this.blackBox.Image = ((System.Drawing.Image)(resources.GetObject("blackBox.Image")));
            this.blackBox.Location = new System.Drawing.Point(737, 214);
            this.blackBox.Margin = new System.Windows.Forms.Padding(2);
            this.blackBox.Name = "blackBox";
            this.blackBox.Size = new System.Drawing.Size(102, 66);
            this.blackBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blackBox.TabIndex = 7;
            this.blackBox.TabStop = false;
            this.blackBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // dontClickImage
            // 
            this.dontClickImage.AutoSize = true;
            this.dontClickImage.Location = new System.Drawing.Point(643, 305);
            this.dontClickImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dontClickImage.Name = "dontClickImage";
            this.dontClickImage.Size = new System.Drawing.Size(0, 15);
            this.dontClickImage.TabIndex = 8;
            // 
            // cancelRequest
            // 
            this.cancelRequest.Location = new System.Drawing.Point(491, 236);
            this.cancelRequest.Margin = new System.Windows.Forms.Padding(2);
            this.cancelRequest.Name = "cancelRequest";
            this.cancelRequest.Size = new System.Drawing.Size(98, 44);
            this.cancelRequest.TabIndex = 9;
            this.cancelRequest.Text = "Cancel";
            this.cancelRequest.UseVisualStyleBackColor = true;
            this.cancelRequest.Click += new System.EventHandler(this.cancelRequest_Click);
            // 
            // employeeFirstName
            // 
            this.employeeFirstName.Location = new System.Drawing.Point(162, 99);
            this.employeeFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.employeeFirstName.Name = "employeeFirstName";
            this.employeeFirstName.Size = new System.Drawing.Size(100, 23);
            this.employeeFirstName.TabIndex = 10;
            // 
            // displayRequestedInfo
            // 
            this.displayRequestedInfo.AutoSize = true;
            this.displayRequestedInfo.Location = new System.Drawing.Point(13, 392);
            this.displayRequestedInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.displayRequestedInfo.Name = "displayRequestedInfo";
            this.displayRequestedInfo.Size = new System.Drawing.Size(0, 15);
            this.displayRequestedInfo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Employee Last Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // employeeLastName
            // 
            this.employeeLastName.Location = new System.Drawing.Point(424, 100);
            this.employeeLastName.Margin = new System.Windows.Forms.Padding(2);
            this.employeeLastName.Name = "employeeLastName";
            this.employeeLastName.Size = new System.Drawing.Size(100, 23);
            this.employeeLastName.TabIndex = 13;
            // 
            // employeeNumber
            // 
            this.employeeNumber.Location = new System.Drawing.Point(766, 101);
            this.employeeNumber.Margin = new System.Windows.Forms.Padding(2);
            this.employeeNumber.Name = "employeeNumber";
            this.employeeNumber.Size = new System.Drawing.Size(100, 23);
            this.employeeNumber.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Employee Identification Number:";
            // 
            // hoursWorkedInput
            // 
            this.hoursWorkedInput.Location = new System.Drawing.Point(211, 141);
            this.hoursWorkedInput.Margin = new System.Windows.Forms.Padding(2);
            this.hoursWorkedInput.Name = "hoursWorkedInput";
            this.hoursWorkedInput.Size = new System.Drawing.Size(38, 23);
            this.hoursWorkedInput.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(887, 422);
            this.Controls.Add(this.hoursWorkedInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employeeNumber);
            this.Controls.Add(this.employeeLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.displayRequestedInfo);
            this.Controls.Add(this.employeeFirstName);
            this.Controls.Add(this.cancelRequest);
            this.Controls.Add(this.dontClickImage);
            this.Controls.Add(this.blackBox);
            this.Controls.Add(this.calculatePay);
            this.Controls.Add(this.hourlyRateInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Wxdaniel Employment Pay Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hourlyRateInput;
        private System.Windows.Forms.Button calculatePay;
        private System.Windows.Forms.PictureBox blackBox;
        private System.Windows.Forms.Label dontClickImage;
        private System.Windows.Forms.Button cancelRequest;
        private System.Windows.Forms.TextBox employeeFirstName;
        private System.Windows.Forms.Label displayRequestedInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox employeeLastName;
        private System.Windows.Forms.TextBox employeeNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hoursWorkedInput;
    }
}

