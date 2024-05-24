namespace EmployeeApplication
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RPH = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.firstname = new System.Windows.Forms.TextBox();
            this.rateperhour = new System.Windows.Forms.TextBox();
            this.jobtitle = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.totalhours = new System.Windows.Forms.TextBox();
            this.firstnameoutput = new System.Windows.Forms.Label();
            this.lastnameoutput = new System.Windows.Forms.Label();
            this.salaryoutput = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Job title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total hours worked";
            // 
            // RPH
            // 
            this.RPH.AutoSize = true;
            this.RPH.Location = new System.Drawing.Point(60, 165);
            this.RPH.Name = "RPH";
            this.RPH.Size = new System.Drawing.Size(66, 13);
            this.RPH.TabIndex = 5;
            this.RPH.Text = "Rateperhour";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "ComputerSalary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(62, 62);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(158, 20);
            this.firstname.TabIndex = 7;
            // 
            // rateperhour
            // 
            this.rateperhour.Location = new System.Drawing.Point(62, 178);
            this.rateperhour.Name = "rateperhour";
            this.rateperhour.Size = new System.Drawing.Size(158, 20);
            this.rateperhour.TabIndex = 8;
            // 
            // jobtitle
            // 
            this.jobtitle.Location = new System.Drawing.Point(226, 126);
            this.jobtitle.Name = "jobtitle";
            this.jobtitle.Size = new System.Drawing.Size(158, 20);
            this.jobtitle.TabIndex = 9;
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(62, 126);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(158, 20);
            this.department.TabIndex = 10;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(226, 62);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(158, 20);
            this.lastname.TabIndex = 11;
            // 
            // totalhours
            // 
            this.totalhours.Location = new System.Drawing.Point(226, 178);
            this.totalhours.Name = "totalhours";
            this.totalhours.Size = new System.Drawing.Size(158, 20);
            this.totalhours.TabIndex = 12;
            // 
            // firstnameoutput
            // 
            this.firstnameoutput.AutoSize = true;
            this.firstnameoutput.Location = new System.Drawing.Point(60, 275);
            this.firstnameoutput.Name = "firstnameoutput";
            this.firstnameoutput.Size = new System.Drawing.Size(57, 13);
            this.firstnameoutput.TabIndex = 13;
            this.firstnameoutput.Text = "FirstName:";
            // 
            // lastnameoutput
            // 
            this.lastnameoutput.AutoSize = true;
            this.lastnameoutput.Location = new System.Drawing.Point(59, 311);
            this.lastnameoutput.Name = "lastnameoutput";
            this.lastnameoutput.Size = new System.Drawing.Size(56, 13);
            this.lastnameoutput.TabIndex = 14;
            this.lastnameoutput.Text = "Lastname:";
            // 
            // salaryoutput
            // 
            this.salaryoutput.AutoSize = true;
            this.salaryoutput.Location = new System.Drawing.Point(59, 355);
            this.salaryoutput.Name = "salaryoutput";
            this.salaryoutput.Size = new System.Drawing.Size(65, 13);
            this.salaryoutput.TabIndex = 15;
            this.salaryoutput.Text = "BasicSalary:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(123, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.salaryoutput);
            this.Controls.Add(this.lastnameoutput);
            this.Controls.Add(this.firstnameoutput);
            this.Controls.Add(this.totalhours);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.department);
            this.Controls.Add(this.jobtitle);
            this.Controls.Add(this.rateperhour);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RPH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RPH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox rateperhour;
        private System.Windows.Forms.TextBox jobtitle;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox totalhours;
        private System.Windows.Forms.Label firstnameoutput;
        private System.Windows.Forms.Label lastnameoutput;
        private System.Windows.Forms.Label salaryoutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

