namespace A2VladyslavBanasko
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
            this.rbHourlyRate = new System.Windows.Forms.RadioButton();
            this.rbCommisionBased = new System.Windows.Forms.RadioButton();
            this.rbWeeklySalary = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtboxHourlyWage = new System.Windows.Forms.TextBox();
            this.txtboxHoursWorked = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblHourlyWage = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtboxNet = new System.Windows.Forms.TextBox();
            this.txtboxTax = new System.Windows.Forms.TextBox();
            this.txtboxGross = new System.Windows.Forms.TextBox();
            this.lblNetEarnings = new System.Windows.Forms.Label();
            this.lblLessTax = new System.Windows.Forms.Label();
            this.lblGrossEarnings = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbHourlyRate
            // 
            this.rbHourlyRate.AutoSize = true;
            this.rbHourlyRate.Checked = true;
            this.rbHourlyRate.Location = new System.Drawing.Point(26, 56);
            this.rbHourlyRate.Name = "rbHourlyRate";
            this.rbHourlyRate.Size = new System.Drawing.Size(104, 21);
            this.rbHourlyRate.TabIndex = 0;
            this.rbHourlyRate.TabStop = true;
            this.rbHourlyRate.Text = "Hourly Rate";
            this.rbHourlyRate.UseVisualStyleBackColor = true;
            this.rbHourlyRate.CheckedChanged += new System.EventHandler(this.rbHourlyRate_CheckedChanged);
            // 
            // rbCommisionBased
            // 
            this.rbCommisionBased.AutoSize = true;
            this.rbCommisionBased.Location = new System.Drawing.Point(177, 56);
            this.rbCommisionBased.Name = "rbCommisionBased";
            this.rbCommisionBased.Size = new System.Drawing.Size(141, 21);
            this.rbCommisionBased.TabIndex = 1;
            this.rbCommisionBased.Text = "Commision Based";
            this.rbCommisionBased.UseVisualStyleBackColor = true;
            this.rbCommisionBased.CheckedChanged += new System.EventHandler(this.rbCommisionBased_CheckedChanged);
            // 
            // rbWeeklySalary
            // 
            this.rbWeeklySalary.AutoSize = true;
            this.rbWeeklySalary.Location = new System.Drawing.Point(370, 56);
            this.rbWeeklySalary.Name = "rbWeeklySalary";
            this.rbWeeklySalary.Size = new System.Drawing.Size(119, 21);
            this.rbWeeklySalary.TabIndex = 2;
            this.rbWeeklySalary.Text = "Weekly Salary";
            this.rbWeeklySalary.UseVisualStyleBackColor = true;
            this.rbWeeklySalary.CheckedChanged += new System.EventHandler(this.rbWeeklySalary_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHourlyRate);
            this.groupBox1.Controls.Add(this.rbWeeklySalary);
            this.groupBox1.Controls.Add(this.rbCommisionBased);
            this.groupBox1.Location = new System.Drawing.Point(98, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 117);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select type of Employee";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtboxHourlyWage);
            this.groupBox2.Controls.Add(this.txtboxHoursWorked);
            this.groupBox2.Controls.Add(this.txtboxName);
            this.groupBox2.Controls.Add(this.lblHourlyWage);
            this.groupBox2.Controls.Add(this.lblHoursWorked);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(98, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 149);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input employee\'s information";
            // 
            // txtboxHourlyWage
            // 
            this.txtboxHourlyWage.Location = new System.Drawing.Point(135, 110);
            this.txtboxHourlyWage.Name = "txtboxHourlyWage";
            this.txtboxHourlyWage.Size = new System.Drawing.Size(354, 22);
            this.txtboxHourlyWage.TabIndex = 12;
            // 
            // txtboxHoursWorked
            // 
            this.txtboxHoursWorked.Location = new System.Drawing.Point(133, 72);
            this.txtboxHoursWorked.Name = "txtboxHoursWorked";
            this.txtboxHoursWorked.Size = new System.Drawing.Size(356, 22);
            this.txtboxHoursWorked.TabIndex = 11;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(135, 34);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(354, 22);
            this.txtboxName.TabIndex = 10;
            // 
            // lblHourlyWage
            // 
            this.lblHourlyWage.AutoSize = true;
            this.lblHourlyWage.Location = new System.Drawing.Point(23, 110);
            this.lblHourlyWage.Name = "lblHourlyWage";
            this.lblHourlyWage.Size = new System.Drawing.Size(86, 17);
            this.lblHourlyWage.TabIndex = 9;
            this.lblHourlyWage.Text = "Hourly wage";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(23, 72);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(95, 17);
            this.lblHoursWorked.TabIndex = 8;
            this.lblHoursWorked.Text = "Hours worked";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtboxNet);
            this.groupBox3.Controls.Add(this.txtboxTax);
            this.groupBox3.Controls.Add(this.txtboxGross);
            this.groupBox3.Controls.Add(this.lblNetEarnings);
            this.groupBox3.Controls.Add(this.lblLessTax);
            this.groupBox3.Controls.Add(this.lblGrossEarnings);
            this.groupBox3.Location = new System.Drawing.Point(98, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 145);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculated wage";
            // 
            // txtboxNet
            // 
            this.txtboxNet.Location = new System.Drawing.Point(133, 107);
            this.txtboxNet.Name = "txtboxNet";
            this.txtboxNet.ReadOnly = true;
            this.txtboxNet.Size = new System.Drawing.Size(356, 22);
            this.txtboxNet.TabIndex = 15;
            // 
            // txtboxTax
            // 
            this.txtboxTax.Location = new System.Drawing.Point(133, 67);
            this.txtboxTax.Name = "txtboxTax";
            this.txtboxTax.ReadOnly = true;
            this.txtboxTax.Size = new System.Drawing.Size(356, 22);
            this.txtboxTax.TabIndex = 14;
            // 
            // txtboxGross
            // 
            this.txtboxGross.Location = new System.Drawing.Point(135, 26);
            this.txtboxGross.Name = "txtboxGross";
            this.txtboxGross.ReadOnly = true;
            this.txtboxGross.Size = new System.Drawing.Size(354, 22);
            this.txtboxGross.TabIndex = 13;
            // 
            // lblNetEarnings
            // 
            this.lblNetEarnings.AutoSize = true;
            this.lblNetEarnings.Location = new System.Drawing.Point(23, 112);
            this.lblNetEarnings.Name = "lblNetEarnings";
            this.lblNetEarnings.Size = new System.Drawing.Size(90, 17);
            this.lblNetEarnings.TabIndex = 12;
            this.lblNetEarnings.Text = "Net Earnings";
            // 
            // lblLessTax
            // 
            this.lblLessTax.AutoSize = true;
            this.lblLessTax.Location = new System.Drawing.Point(23, 70);
            this.lblLessTax.Name = "lblLessTax";
            this.lblLessTax.Size = new System.Drawing.Size(65, 17);
            this.lblLessTax.TabIndex = 11;
            this.lblLessTax.Text = "Less Tax";
            // 
            // lblGrossEarnings
            // 
            this.lblGrossEarnings.AutoSize = true;
            this.lblGrossEarnings.Location = new System.Drawing.Point(23, 26);
            this.lblGrossEarnings.Name = "lblGrossEarnings";
            this.lblGrossEarnings.Size = new System.Drawing.Size(106, 17);
            this.lblGrossEarnings.TabIndex = 10;
            this.lblGrossEarnings.Text = "Gross Earnings";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(654, 152);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(121, 71);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(654, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 71);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(671, 423);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 64);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(117, 488);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(77, 17);
            this.lblEmployees.TabIndex = 16;
            this.lblEmployees.Text = "Employees";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(233, 488);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(354, 24);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbHourlyRate;
        private System.Windows.Forms.RadioButton rbCommisionBased;
        private System.Windows.Forms.RadioButton rbWeeklySalary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtboxHourlyWage;
        private System.Windows.Forms.TextBox txtboxHoursWorked;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label lblHourlyWage;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtboxNet;
        private System.Windows.Forms.TextBox txtboxTax;
        private System.Windows.Forms.TextBox txtboxGross;
        private System.Windows.Forms.Label lblNetEarnings;
        private System.Windows.Forms.Label lblLessTax;
        private System.Windows.Forms.Label lblGrossEarnings;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

