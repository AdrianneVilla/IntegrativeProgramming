namespace WindowsApplication
{
    partial class StudentRegistration
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
            this.textBox3LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1FirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2MiddleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1Male = new System.Windows.Forms.RadioButton();
            this.radioButton2Female = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1Day = new System.Windows.Forms.ComboBox();
            this.comboBox2Month = new System.Windows.Forms.ComboBox();
            this.comboBox3Year = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3LastName
            // 
            this.textBox3LastName.AccessibleName = "LastName";
            this.textBox3LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3LastName.Location = new System.Drawing.Point(40, 134);
            this.textBox3LastName.Name = "textBox3LastName";
            this.textBox3LastName.Size = new System.Drawing.Size(225, 20);
            this.textBox3LastName.TabIndex = 2;
            this.textBox3LastName.TextChanged += new System.EventHandler(this.textBox3LastName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1FirstName
            // 
            this.textBox1FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1FirstName.Location = new System.Drawing.Point(40, 189);
            this.textBox1FirstName.Name = "textBox1FirstName";
            this.textBox1FirstName.Size = new System.Drawing.Size(225, 20);
            this.textBox1FirstName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Middle Name*";
            // 
            // textBox2MiddleName
            // 
            this.textBox2MiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2MiddleName.Location = new System.Drawing.Point(40, 247);
            this.textBox2MiddleName.Name = "textBox2MiddleName";
            this.textBox2MiddleName.Size = new System.Drawing.Size(225, 20);
            this.textBox2MiddleName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender*";
            // 
            // radioButton1Male
            // 
            this.radioButton1Male.AutoSize = true;
            this.radioButton1Male.Location = new System.Drawing.Point(118, 281);
            this.radioButton1Male.Name = "radioButton1Male";
            this.radioButton1Male.Size = new System.Drawing.Size(48, 17);
            this.radioButton1Male.TabIndex = 10;
            this.radioButton1Male.TabStop = true;
            this.radioButton1Male.Text = "Male";
            this.radioButton1Male.UseVisualStyleBackColor = true;
            this.radioButton1Male.CheckedChanged += new System.EventHandler(this.radioButton1Male_CheckedChanged);
            // 
            // radioButton2Female
            // 
            this.radioButton2Female.AutoSize = true;
            this.radioButton2Female.Location = new System.Drawing.Point(196, 280);
            this.radioButton2Female.Name = "radioButton2Female";
            this.radioButton2Female.Size = new System.Drawing.Size(59, 17);
            this.radioButton2Female.TabIndex = 11;
            this.radioButton2Female.TabStop = true;
            this.radioButton2Female.Text = "Female";
            this.radioButton2Female.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date of Birth*";
            // 
            // comboBox1Day
            // 
            this.comboBox1Day.FormattingEnabled = true;
            this.comboBox1Day.Location = new System.Drawing.Point(39, 346);
            this.comboBox1Day.Name = "comboBox1Day";
            this.comboBox1Day.Size = new System.Drawing.Size(59, 21);
            this.comboBox1Day.TabIndex = 13;
            this.comboBox1Day.Text = "Day";
            this.comboBox1Day.SelectedIndexChanged += new System.EventHandler(this.comboBox1Day_SelectedIndexChanged);
            // 
            // comboBox2Month
            // 
            this.comboBox2Month.FormattingEnabled = true;
            this.comboBox2Month.Location = new System.Drawing.Point(104, 346);
            this.comboBox2Month.Name = "comboBox2Month";
            this.comboBox2Month.Size = new System.Drawing.Size(75, 21);
            this.comboBox2Month.TabIndex = 14;
            this.comboBox2Month.Text = "Month";
            this.comboBox2Month.SelectedIndexChanged += new System.EventHandler(this.comboBox2Month_SelectedIndexChanged);
            // 
            // comboBox3Year
            // 
            this.comboBox3Year.FormattingEnabled = true;
            this.comboBox3Year.Location = new System.Drawing.Point(185, 346);
            this.comboBox3Year.Name = "comboBox3Year";
            this.comboBox3Year.Size = new System.Drawing.Size(70, 21);
            this.comboBox3Year.TabIndex = 15;
            this.comboBox3Year.Text = "Year";
            this.comboBox3Year.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(40, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 56);
            this.button1.TabIndex = 16;
            this.button1.Text = "Register Student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(340, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3Year);
            this.Controls.Add(this.comboBox2Month);
            this.Controls.Add(this.comboBox1Day);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton2Female);
            this.Controls.Add(this.radioButton1Male);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2MiddleName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1FirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3LastName);
            this.Name = "StudentRegistration";
            this.Text = "StudentRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1FirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2MiddleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1Male;
        private System.Windows.Forms.RadioButton radioButton2Female;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1Day;
        private System.Windows.Forms.ComboBox comboBox2Month;
        private System.Windows.Forms.ComboBox comboBox3Year;
        private System.Windows.Forms.Button button1;
    }
}

