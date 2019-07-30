namespace Ex01_FaceBook
{
    partial class FaceBookMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceBookMainForm));
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.ProfileTab = new System.Windows.Forms.TabPage();
            this.textUserEmail = new System.Windows.Forms.TextBox();
            this.textUserBirthDay = new System.Windows.Forms.TextBox();
            this.textUserFullName = new System.Windows.Forms.TextBox();
            this.textEmailReadOnly = new System.Windows.Forms.TextBox();
            this.textBirthDayReadOnly = new System.Windows.Forms.TextBox();
            this.textNameReadOnly = new System.Windows.Forms.TextBox();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.buttonLoginLogout = new System.Windows.Forms.Button();
            this.FeedTab = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textUserGender = new System.Windows.Forms.TextBox();
            this.textGenderReadOnly = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabsControl.SuspendLayout();
            this.ProfileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.ProfileTab);
            this.tabsControl.Controls.Add(this.FeedTab);
            this.tabsControl.Controls.Add(this.tabPage3);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Location = new System.Drawing.Point(0, 0);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(800, 450);
            this.tabsControl.TabIndex = 0;
            // 
            // ProfileTab
            // 
            this.ProfileTab.Controls.Add(this.listView1);
            this.ProfileTab.Controls.Add(this.textUserGender);
            this.ProfileTab.Controls.Add(this.textGenderReadOnly);
            this.ProfileTab.Controls.Add(this.textUserEmail);
            this.ProfileTab.Controls.Add(this.textUserBirthDay);
            this.ProfileTab.Controls.Add(this.textUserFullName);
            this.ProfileTab.Controls.Add(this.textEmailReadOnly);
            this.ProfileTab.Controls.Add(this.textBirthDayReadOnly);
            this.ProfileTab.Controls.Add(this.textNameReadOnly);
            this.ProfileTab.Controls.Add(this.pictureProfile);
            this.ProfileTab.Controls.Add(this.buttonLoginLogout);
            this.ProfileTab.Location = new System.Drawing.Point(4, 29);
            this.ProfileTab.Name = "ProfileTab";
            this.ProfileTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProfileTab.Size = new System.Drawing.Size(792, 417);
            this.ProfileTab.TabIndex = 0;
            this.ProfileTab.Text = "Profile";
            this.ProfileTab.UseVisualStyleBackColor = true;
            // 
            // textUserEmail
            // 
            this.textUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserEmail.Location = new System.Drawing.Point(321, 146);
            this.textUserEmail.Name = "textUserEmail";
            this.textUserEmail.Size = new System.Drawing.Size(256, 19);
            this.textUserEmail.TabIndex = 7;
            this.textUserEmail.Visible = false;
            // 
            // textUserBirthDay
            // 
            this.textUserBirthDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserBirthDay.Location = new System.Drawing.Point(321, 106);
            this.textUserBirthDay.Name = "textUserBirthDay";
            this.textUserBirthDay.Size = new System.Drawing.Size(256, 19);
            this.textUserBirthDay.TabIndex = 6;
            this.textUserBirthDay.Visible = false;
            // 
            // textUserFullName
            // 
            this.textUserFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserFullName.Location = new System.Drawing.Point(321, 67);
            this.textUserFullName.Name = "textUserFullName";
            this.textUserFullName.Size = new System.Drawing.Size(256, 19);
            this.textUserFullName.TabIndex = 5;
            this.textUserFullName.Visible = false;
            // 
            // textEmailReadOnly
            // 
            this.textEmailReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.textEmailReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmailReadOnly.Location = new System.Drawing.Point(201, 146);
            this.textEmailReadOnly.Name = "textEmailReadOnly";
            this.textEmailReadOnly.ReadOnly = true;
            this.textEmailReadOnly.Size = new System.Drawing.Size(100, 19);
            this.textEmailReadOnly.TabIndex = 4;
            this.textEmailReadOnly.Text = "Email:";
            this.textEmailReadOnly.Visible = false;
            // 
            // textBirthDayReadOnly
            // 
            this.textBirthDayReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.textBirthDayReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBirthDayReadOnly.Location = new System.Drawing.Point(201, 106);
            this.textBirthDayReadOnly.Name = "textBirthDayReadOnly";
            this.textBirthDayReadOnly.ReadOnly = true;
            this.textBirthDayReadOnly.Size = new System.Drawing.Size(100, 19);
            this.textBirthDayReadOnly.TabIndex = 3;
            this.textBirthDayReadOnly.Text = "Date Of Birth:";
            this.textBirthDayReadOnly.Visible = false;
            // 
            // textNameReadOnly
            // 
            this.textNameReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.textNameReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNameReadOnly.Location = new System.Drawing.Point(201, 67);
            this.textNameReadOnly.Name = "textNameReadOnly";
            this.textNameReadOnly.ReadOnly = true;
            this.textNameReadOnly.Size = new System.Drawing.Size(100, 19);
            this.textNameReadOnly.TabIndex = 2;
            this.textNameReadOnly.Text = "Name:";
            this.textNameReadOnly.Visible = false;
            // 
            // pictureProfile
            // 
            this.pictureProfile.Location = new System.Drawing.Point(27, 58);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(147, 159);
            this.pictureProfile.TabIndex = 1;
            this.pictureProfile.TabStop = false;
            this.pictureProfile.Visible = false;
            // 
            // buttonLoginLogout
            // 
            this.buttonLoginLogout.Location = new System.Drawing.Point(27, 6);
            this.buttonLoginLogout.Name = "buttonLoginLogout";
            this.buttonLoginLogout.Size = new System.Drawing.Size(81, 46);
            this.buttonLoginLogout.TabIndex = 0;
            this.buttonLoginLogout.Text = "Login";
            this.buttonLoginLogout.UseVisualStyleBackColor = true;
            this.buttonLoginLogout.Click += new System.EventHandler(this.ButtonLoginLogout_Click);
            // 
            // FeedTab
            // 
            this.FeedTab.Location = new System.Drawing.Point(4, 29);
            this.FeedTab.Name = "FeedTab";
            this.FeedTab.Padding = new System.Windows.Forms.Padding(3);
            this.FeedTab.Size = new System.Drawing.Size(792, 417);
            this.FeedTab.TabIndex = 1;
            this.FeedTab.Text = "Feed";
            this.FeedTab.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textUserGender
            // 
            this.textUserGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserGender.Location = new System.Drawing.Point(321, 185);
            this.textUserGender.Name = "textUserGender";
            this.textUserGender.Size = new System.Drawing.Size(256, 19);
            this.textUserGender.TabIndex = 9;
            this.textUserGender.Visible = false;
            // 
            // textGenderReadOnly
            // 
            this.textGenderReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.textGenderReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textGenderReadOnly.Location = new System.Drawing.Point(201, 185);
            this.textGenderReadOnly.Name = "textGenderReadOnly";
            this.textGenderReadOnly.ReadOnly = true;
            this.textGenderReadOnly.Size = new System.Drawing.Size(100, 19);
            this.textGenderReadOnly.TabIndex = 8;
            this.textGenderReadOnly.Text = "Gender:";
            this.textGenderReadOnly.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(157, 263);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(410, 139);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FaceBookMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabsControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FaceBookMainForm";
            this.Text = "FaceBook";
            this.tabsControl.ResumeLayout(false);
            this.ProfileTab.ResumeLayout(false);
            this.ProfileTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage ProfileTab;
        private System.Windows.Forms.TabPage FeedTab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonLoginLogout;
        private System.Windows.Forms.PictureBox pictureProfile;
        private System.Windows.Forms.TextBox textUserEmail;
        private System.Windows.Forms.TextBox textUserBirthDay;
        private System.Windows.Forms.TextBox textUserFullName;
        private System.Windows.Forms.TextBox textEmailReadOnly;
        private System.Windows.Forms.TextBox textBirthDayReadOnly;
        private System.Windows.Forms.TextBox textNameReadOnly;
        private System.Windows.Forms.TextBox textUserGender;
        private System.Windows.Forms.TextBox textGenderReadOnly;
        private System.Windows.Forms.ListView listView1;
    }
}

