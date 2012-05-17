namespace PersonalManagementSystem
{
    partial class addPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addPersonel));
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BloodComboBox = new System.Windows.Forms.ComboBox();
            this.TcNoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TitleComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.DeptComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.address = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioPersonel = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mobilePhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.homePhone = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.InsRegisterNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(164, 43);
            this.NameTextBox.MaxLength = 40;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(140, 22);
            this.NameTextBox.TabIndex = 0;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(164, 80);
            this.SurnameTextBox.MaxLength = 40;
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(140, 22);
            this.SurnameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "BloodType :";
            // 
            // BloodComboBox
            // 
            this.BloodComboBox.FormattingEnabled = true;
            this.BloodComboBox.Items.AddRange(new object[] {
            "0rh+",
            "0rh-",
            "ABrh+",
            "ABrh-",
            "Arh+",
            "Arh-",
            "Brh+",
            "Brh-"});
            this.BloodComboBox.Location = new System.Drawing.Point(164, 141);
            this.BloodComboBox.Name = "BloodComboBox";
            this.BloodComboBox.Size = new System.Drawing.Size(100, 24);
            this.BloodComboBox.TabIndex = 3;
            this.BloodComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BloodComboBox_KeyPress);
            // 
            // TcNoTextBox
            // 
            this.TcNoTextBox.Location = new System.Drawing.Point(164, 113);
            this.TcNoTextBox.MaxLength = 11;
            this.TcNoTextBox.Name = "TcNoTextBox";
            this.TcNoTextBox.Size = new System.Drawing.Size(140, 22);
            this.TcNoTextBox.TabIndex = 2;
            this.TcNoTextBox.TextChanged += new System.EventHandler(this.TcNoTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "T.C. NO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Title :";
            // 
            // TitleComboBox
            // 
            this.TitleComboBox.FormattingEnabled = true;
            this.TitleComboBox.Items.AddRange(new object[] {
            "Prof.Dr.",
            "Prof",
            "Doç.Dr.         ",
            "Yar.Doç.Dr",
            "Doç",
            "Yrd.Doç",
            "Öğr.Gör.Dr.",
            "Uzman",
            "Öğr.Gör",
            "Arş.Gör."});
            this.TitleComboBox.Location = new System.Drawing.Point(163, 103);
            this.TitleComboBox.Name = "TitleComboBox";
            this.TitleComboBox.Size = new System.Drawing.Size(127, 24);
            this.TitleComboBox.TabIndex = 15;
            this.TitleComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TitleComboBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Type :";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Academic",
            "Administrative",
            "Attendant"});
            this.TypeComboBox.Location = new System.Drawing.Point(163, 73);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(127, 24);
            this.TypeComboBox.TabIndex = 14;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            this.TypeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeComboBox_KeyPress);
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(164, 172);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(75, 21);
            this.femaleRadio.TabIndex = 4;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Checked = true;
            this.maleRadio.Location = new System.Drawing.Point(245, 172);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(59, 21);
            this.maleRadio.TabIndex = 5;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Faculty :";
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Items.AddRange(new object[] {
            "Please Choose",
            "Faculty of Architecture",
            "Faculty of Communication",
            "Faculty of Economics and Administrative Sciences",
            "Faculty of Education",
            "Faculty of Engineering",
            "Faculty of Law",
            "Faculty of Medicine",
            "Faculty of Science and Letters",
            "School of Foreign Languages"});
            this.FacultyComboBox.Location = new System.Drawing.Point(163, 133);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(282, 24);
            this.FacultyComboBox.TabIndex = 16;
            this.FacultyComboBox.SelectedIndexChanged += new System.EventHandler(this.FacultyComboBox_SelectedIndexChanged);
            this.FacultyComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FacultyComboBox_KeyPress);
            // 
            // DeptComboBox
            // 
            this.DeptComboBox.FormattingEnabled = true;
            this.DeptComboBox.Items.AddRange(new object[] {
            "Please Choose"});
            this.DeptComboBox.Location = new System.Drawing.Point(163, 163);
            this.DeptComboBox.Name = "DeptComboBox";
            this.DeptComboBox.Size = new System.Drawing.Size(282, 24);
            this.DeptComboBox.TabIndex = 17;
            this.DeptComboBox.SelectedIndexChanged += new System.EventHandler(this.DeptComboBox_SelectedIndexChanged);
            this.DeptComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeptComboBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Departmant :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Courses :";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Items.AddRange(new object[] {
            "Please Choose"});
            this.CourseComboBox.Location = new System.Drawing.Point(163, 193);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(282, 24);
            this.CourseComboBox.TabIndex = 18;
            this.CourseComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CourseComboBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.maleRadio);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.femaleRadio);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.mobilePhone);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.homePhone);
            this.groupBox1.Controls.Add(this.TcNoTextBox);
            this.groupBox1.Controls.Add(this.BloodComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SurnameTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 469);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnel Information";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(164, 255);
            this.address.MaxLength = 600;
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(140, 82);
            this.address.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioPersonel);
            this.groupBox4.Controls.Add(this.radioAdmin);
            this.groupBox4.Location = new System.Drawing.Point(10, 367);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 96);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "User Level";
            // 
            // radioPersonel
            // 
            this.radioPersonel.AutoSize = true;
            this.radioPersonel.Location = new System.Drawing.Point(6, 62);
            this.radioPersonel.Name = "radioPersonel";
            this.radioPersonel.Size = new System.Drawing.Size(93, 21);
            this.radioPersonel.TabIndex = 11;
            this.radioPersonel.TabStop = true;
            this.radioPersonel.Text = "Personnel";
            this.radioPersonel.UseVisualStyleBackColor = true;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Checked = true;
            this.radioAdmin.Location = new System.Drawing.Point(6, 26);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(112, 21);
            this.radioAdmin.TabIndex = 10;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Administrator";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Address :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Mobile Phone :";
            // 
            // mobilePhone
            // 
            this.mobilePhone.Location = new System.Drawing.Point(164, 227);
            this.mobilePhone.MaxLength = 20;
            this.mobilePhone.Name = "mobilePhone";
            this.mobilePhone.Size = new System.Drawing.Size(124, 22);
            this.mobilePhone.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Home Phone :";
            // 
            // homePhone
            // 
            this.homePhone.Location = new System.Drawing.Point(164, 199);
            this.homePhone.MaxLength = 20;
            this.homePhone.Name = "homePhone";
            this.homePhone.Size = new System.Drawing.Size(124, 22);
            this.homePhone.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.InsRegisterNo);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.CourseComboBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.DeptComboBox);
            this.groupBox2.Controls.Add(this.FacultyComboBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TypeComboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TitleComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(341, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 469);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Job Information";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(358, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 102);
            this.button1.TabIndex = 21;
            this.button1.Text = "CLOSE";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 223);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "Date of Start :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(256, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 102);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 22);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker1_KeyPress);
            // 
            // InsRegisterNo
            // 
            this.InsRegisterNo.Location = new System.Drawing.Point(163, 43);
            this.InsRegisterNo.MaxLength = 20;
            this.InsRegisterNo.Name = "InsRegisterNo";
            this.InsRegisterNo.Size = new System.Drawing.Size(100, 22);
            this.InsRegisterNo.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Instution Register No:";
            // 
            // addPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 505);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Personnel";
            this.Load += new System.EventHandler(this.addPersonel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BloodComboBox;
        private System.Windows.Forms.TextBox TcNoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TitleComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox FacultyComboBox;
        private System.Windows.Forms.ComboBox DeptComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox homePhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox mobilePhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.RadioButton radioPersonel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox InsRegisterNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}