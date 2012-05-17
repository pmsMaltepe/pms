namespace PersonalManagementSystem
{
    partial class userSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newConfirmPass = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.radioPersonnel = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Old Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Level:";
            // 
            // oldPass
            // 
            this.oldPass.Location = new System.Drawing.Point(174, 64);
            this.oldPass.Name = "oldPass";
            this.oldPass.PasswordChar = '*';
            this.oldPass.Size = new System.Drawing.Size(137, 22);
            this.oldPass.TabIndex = 3;
            // 
            // newPass
            // 
            this.newPass.Location = new System.Drawing.Point(174, 92);
            this.newPass.Name = "newPass";
            this.newPass.PasswordChar = '*';
            this.newPass.Size = new System.Drawing.Size(137, 22);
            this.newPass.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "New Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirm New Password:";
            // 
            // newConfirmPass
            // 
            this.newConfirmPass.Location = new System.Drawing.Point(174, 120);
            this.newConfirmPass.Name = "newConfirmPass";
            this.newConfirmPass.PasswordChar = '*';
            this.newConfirmPass.Size = new System.Drawing.Size(137, 22);
            this.newConfirmPass.TabIndex = 7;
            this.newConfirmPass.TextChanged += new System.EventHandler(this.newConfirmPass_TextChanged);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(174, 36);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(137, 22);
            this.userName.TabIndex = 20;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Location = new System.Drawing.Point(99, 167);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(112, 21);
            this.radioAdmin.TabIndex = 9;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Administrator";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // radioPersonnel
            // 
            this.radioPersonnel.AutoSize = true;
            this.radioPersonnel.Location = new System.Drawing.Point(217, 167);
            this.radioPersonnel.Name = "radioPersonnel";
            this.radioPersonnel.Size = new System.Drawing.Size(93, 21);
            this.radioPersonnel.TabIndex = 10;
            this.radioPersonnel.TabStop = true;
            this.radioPersonnel.Text = "Personnel";
            this.radioPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(174, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 63);
            this.btnSave.TabIndex = 11;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(256, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 63);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // userSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 292);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radioPersonnel);
            this.Controls.Add(this.radioAdmin);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.newConfirmPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.oldPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "userSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.userSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newConfirmPass;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.RadioButton radioPersonnel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}