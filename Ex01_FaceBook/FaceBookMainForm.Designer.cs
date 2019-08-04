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
            this.listView1 = new System.Windows.Forms.ListView();
            this.textUserGender = new System.Windows.Forms.TextBox();
            this.textGenderReadOnly = new System.Windows.Forms.TextBox();
            this.textUserEmail = new System.Windows.Forms.TextBox();
            this.textUserBirthDay = new System.Windows.Forms.TextBox();
            this.textUserFullName = new System.Windows.Forms.TextBox();
            this.textEmailReadOnly = new System.Windows.Forms.TextBox();
            this.textBirthDayReadOnly = new System.Windows.Forms.TextBox();
            this.textNameReadOnly = new System.Windows.Forms.TextBox();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.buttonLoginLogout = new System.Windows.Forms.Button();
            this.FeedTab = new System.Windows.Forms.TabPage();
            this.FriendsListTab = new System.Windows.Forms.TabPage();
            this.listViewFriendsList = new System.Windows.Forms.ListView();
            this.friendColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxNumberOfFriends = new System.Windows.Forms.TextBox();
            this.textBoxFriendsCounter = new System.Windows.Forms.TextBox();
            this.tabsControl.SuspendLayout();
            this.ProfileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.FriendsListTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.ProfileTab);
            this.tabsControl.Controls.Add(this.FeedTab);
            this.tabsControl.Controls.Add(this.FriendsListTab);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Location = new System.Drawing.Point(0, 0);
            this.tabsControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(923, 458);
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
            this.ProfileTab.Location = new System.Drawing.Point(4, 25);
            this.ProfileTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProfileTab.Name = "ProfileTab";
            this.ProfileTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProfileTab.Size = new System.Drawing.Size(915, 429);
            this.ProfileTab.TabIndex = 0;
            this.ProfileTab.Text = "Profile";
            this.ProfileTab.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(140, 210);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(365, 112);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textUserGender
            // 
            this.textUserGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserGender.Location = new System.Drawing.Point(285, 148);
            this.textUserGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUserGender.Name = "textUserGender";
            this.textUserGender.Size = new System.Drawing.Size(228, 15);
            this.textUserGender.TabIndex = 9;
            this.textUserGender.Visible = false;
            // 
            // textGenderReadOnly
            // 
            this.textGenderReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.textGenderReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textGenderReadOnly.Location = new System.Drawing.Point(179, 148);
            this.textGenderReadOnly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textGenderReadOnly.Name = "textGenderReadOnly";
            this.textGenderReadOnly.ReadOnly = true;
            this.textGenderReadOnly.Size = new System.Drawing.Size(89, 15);
            this.textGenderReadOnly.TabIndex = 8;
            this.textGenderReadOnly.Text = "Gender:";
            this.textGenderReadOnly.Visible = false;
            // 
            // textUserEmail
            // 
            this.textUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserEmail.Location = new System.Drawing.Point(285, 117);
            this.textUserEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUserEmail.Name = "textUserEmail";
            this.textUserEmail.Size = new System.Drawing.Size(228, 15);
            this.textUserEmail.TabIndex = 7;
            this.textUserEmail.Visible = false;
            // 
            // textUserBirthDay
            // 
            this.textUserBirthDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserBirthDay.Location = new System.Drawing.Point(285, 85);
            this.textUserBirthDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUserBirthDay.Name = "textUserBirthDay";
            this.textUserBirthDay.Size = new System.Drawing.Size(228, 15);
            this.textUserBirthDay.TabIndex = 6;
            this.textUserBirthDay.Visible = false;
            // 
            // textUserFullName
            // 
            this.textUserFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserFullName.Location = new System.Drawing.Point(285, 54);
            this.textUserFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUserFullName.Name = "textUserFullName";
            this.textUserFullName.Size = new System.Drawing.Size(228, 15);
            this.textUserFullName.TabIndex = 5;
            this.textUserFullName.Visible = false;
            // 
            // textEmailReadOnly
            // 
            this.textEmailReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.textEmailReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmailReadOnly.Location = new System.Drawing.Point(179, 117);
            this.textEmailReadOnly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEmailReadOnly.Name = "textEmailReadOnly";
            this.textEmailReadOnly.ReadOnly = true;
            this.textEmailReadOnly.Size = new System.Drawing.Size(89, 15);
            this.textEmailReadOnly.TabIndex = 4;
            this.textEmailReadOnly.Text = "Email:";
            this.textEmailReadOnly.Visible = false;
            // 
            // textBirthDayReadOnly
            // 
            this.textBirthDayReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.textBirthDayReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBirthDayReadOnly.Location = new System.Drawing.Point(179, 85);
            this.textBirthDayReadOnly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBirthDayReadOnly.Name = "textBirthDayReadOnly";
            this.textBirthDayReadOnly.ReadOnly = true;
            this.textBirthDayReadOnly.Size = new System.Drawing.Size(89, 15);
            this.textBirthDayReadOnly.TabIndex = 3;
            this.textBirthDayReadOnly.Text = "Date Of Birth:";
            this.textBirthDayReadOnly.Visible = false;
            // 
            // textNameReadOnly
            // 
            this.textNameReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.textNameReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNameReadOnly.Location = new System.Drawing.Point(179, 54);
            this.textNameReadOnly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNameReadOnly.Name = "textNameReadOnly";
            this.textNameReadOnly.ReadOnly = true;
            this.textNameReadOnly.Size = new System.Drawing.Size(89, 15);
            this.textNameReadOnly.TabIndex = 2;
            this.textNameReadOnly.Text = "Name:";
            this.textNameReadOnly.Visible = false;
            // 
            // pictureProfile
            // 
            this.pictureProfile.Location = new System.Drawing.Point(24, 46);
            this.pictureProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(131, 127);
            this.pictureProfile.TabIndex = 1;
            this.pictureProfile.TabStop = false;
            this.pictureProfile.Visible = false;
            // 
            // buttonLoginLogout
            // 
            this.buttonLoginLogout.Location = new System.Drawing.Point(24, 5);
            this.buttonLoginLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoginLogout.Name = "buttonLoginLogout";
            this.buttonLoginLogout.Size = new System.Drawing.Size(72, 37);
            this.buttonLoginLogout.TabIndex = 0;
            this.buttonLoginLogout.Text = "Login";
            this.buttonLoginLogout.UseVisualStyleBackColor = true;
            this.buttonLoginLogout.Click += new System.EventHandler(this.ButtonLoginLogout_Click);
            // 
            // FeedTab
            // 
            this.FeedTab.Location = new System.Drawing.Point(4, 25);
            this.FeedTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeedTab.Name = "FeedTab";
            this.FeedTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeedTab.Size = new System.Drawing.Size(915, 429);
            this.FeedTab.TabIndex = 1;
            this.FeedTab.Text = "Feed";
            this.FeedTab.UseVisualStyleBackColor = true;
            // 
            // FriendsListTab
            // 
            this.FriendsListTab.Controls.Add(this.listViewFriendsList);
            this.FriendsListTab.Controls.Add(this.textBoxNumberOfFriends);
            this.FriendsListTab.Controls.Add(this.textBoxFriendsCounter);
            this.FriendsListTab.Location = new System.Drawing.Point(4, 25);
            this.FriendsListTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FriendsListTab.Name = "FriendsListTab";
            this.FriendsListTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FriendsListTab.Size = new System.Drawing.Size(915, 429);
            this.FriendsListTab.TabIndex = 2;
            this.FriendsListTab.Text = "FriendsListTab";
            this.FriendsListTab.UseVisualStyleBackColor = true;
            // 
            // listViewFriendsList
            // 
            this.listViewFriendsList.AllowDrop = true;
            this.listViewFriendsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.friendColumnHeader});
            this.listViewFriendsList.FullRowSelect = true;
            this.listViewFriendsList.GridLines = true;
            this.listViewFriendsList.Location = new System.Drawing.Point(8, 76);
            this.listViewFriendsList.Name = "listViewFriendsList";
            this.listViewFriendsList.Size = new System.Drawing.Size(265, 162);
            this.listViewFriendsList.TabIndex = 17;
            this.listViewFriendsList.UseCompatibleStateImageBehavior = false;
            this.listViewFriendsList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // friendColumnHeader
            // 
            this.friendColumnHeader.Text = "";
            this.friendColumnHeader.Width = 150;
            // 
            // textBoxNumberOfFriends
            // 
            this.textBoxNumberOfFriends.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumberOfFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxNumberOfFriends.Location = new System.Drawing.Point(8, 21);
            this.textBoxNumberOfFriends.Name = "textBoxNumberOfFriends";
            this.textBoxNumberOfFriends.Size = new System.Drawing.Size(191, 18);
            this.textBoxNumberOfFriends.TabIndex = 15;
            this.textBoxNumberOfFriends.Text = "Total number of friends:";
            // 
            // textBoxFriendsCounter
            // 
            this.textBoxFriendsCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFriendsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxFriendsCounter.Location = new System.Drawing.Point(205, 21);
            this.textBoxFriendsCounter.Name = "textBoxFriendsCounter";
            this.textBoxFriendsCounter.Size = new System.Drawing.Size(39, 18);
            this.textBoxFriendsCounter.TabIndex = 14;
            this.textBoxFriendsCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FaceBookMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 458);
            this.Controls.Add(this.tabsControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FaceBookMainForm";
            this.Text = "FaceBook";
            this.tabsControl.ResumeLayout(false);
            this.ProfileTab.ResumeLayout(false);
            this.ProfileTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.FriendsListTab.ResumeLayout(false);
            this.FriendsListTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage ProfileTab;
        private System.Windows.Forms.TabPage FeedTab;
        private System.Windows.Forms.TabPage FriendsListTab;
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
        private System.Windows.Forms.TextBox textBoxFriendsCounter;
        private System.Windows.Forms.TextBox textBoxNumberOfFriends;
        private System.Windows.Forms.ListView listViewFriendsList;
        private System.Windows.Forms.ColumnHeader friendColumnHeader;
    }
}

