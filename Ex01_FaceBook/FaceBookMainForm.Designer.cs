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
            this.comboBoxStatusesSort = new System.Windows.Forms.ComboBox();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.listViewUserStatuses = new System.Windows.Forms.ListView();
            this.buttonLoginLogout = new System.Windows.Forms.Button();
            this.textUserGender = new System.Windows.Forms.TextBox();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.textGenderReadOnly = new System.Windows.Forms.TextBox();
            this.textEmailReadOnly = new System.Windows.Forms.TextBox();
            this.textUserEmail = new System.Windows.Forms.TextBox();
            this.textUserFullName = new System.Windows.Forms.TextBox();
            this.textNameReadOnly = new System.Windows.Forms.TextBox();
            this.textBirthDayReadOnly = new System.Windows.Forms.TextBox();
            this.textUserBirthDay = new System.Windows.Forms.TextBox();
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
            this.tabsControl.Size = new System.Drawing.Size(1038, 572);
            this.tabsControl.TabIndex = 0;
            // 
            // ProfileTab
            // 
            this.ProfileTab.Controls.Add(this.comboBoxStatusesSort);
            this.ProfileTab.Controls.Add(this.checkBoxRememberMe);
            this.ProfileTab.Controls.Add(this.listViewUserStatuses);
            this.ProfileTab.Controls.Add(this.buttonLoginLogout);
            this.ProfileTab.Controls.Add(this.textUserGender);
            this.ProfileTab.Controls.Add(this.pictureProfile);
            this.ProfileTab.Controls.Add(this.textGenderReadOnly);
            this.ProfileTab.Controls.Add(this.textEmailReadOnly);
            this.ProfileTab.Controls.Add(this.textUserEmail);
            this.ProfileTab.Controls.Add(this.textUserFullName);
            this.ProfileTab.Controls.Add(this.textNameReadOnly);
            this.ProfileTab.Controls.Add(this.textBirthDayReadOnly);
            this.ProfileTab.Controls.Add(this.textUserBirthDay);
            this.ProfileTab.Location = new System.Drawing.Point(4, 29);
            this.ProfileTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProfileTab.Name = "ProfileTab";
            this.ProfileTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProfileTab.Size = new System.Drawing.Size(1030, 539);
            this.ProfileTab.TabIndex = 0;
            this.ProfileTab.Text = "Profile";
            this.ProfileTab.UseVisualStyleBackColor = true;
            // 
            // comboBoxStatusesSort
            // 
            this.comboBoxStatusesSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxStatusesSort.Items.AddRange(new object[] {
            "Upload Date - most recent",
            "Number of likes",
            "Number of comments"});
            this.comboBoxStatusesSort.Location = new System.Drawing.Point(65, 263);
            this.comboBoxStatusesSort.Name = "comboBoxStatusesSort";
            this.comboBoxStatusesSort.Size = new System.Drawing.Size(221, 28);
            this.comboBoxStatusesSort.TabIndex = 13;
            this.comboBoxStatusesSort.Text = "Sort Statuses by";
            this.comboBoxStatusesSort.Visible = false;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(165, 24);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(140, 24);
            this.checkBoxRememberMe.TabIndex = 11;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // listViewUserStatuses
            // 
            this.listViewUserStatuses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewUserStatuses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewUserStatuses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewUserStatuses.Location = new System.Drawing.Point(5, 296);
            this.listViewUserStatuses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewUserStatuses.Name = "listViewUserStatuses";
            this.listViewUserStatuses.Size = new System.Drawing.Size(1018, 231);
            this.listViewUserStatuses.TabIndex = 10;
            this.listViewUserStatuses.UseCompatibleStateImageBehavior = false;
            this.listViewUserStatuses.View = System.Windows.Forms.View.Details;
            // 
            // buttonLoginLogout
            // 
            this.buttonLoginLogout.Location = new System.Drawing.Point(65, 13);
            this.buttonLoginLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoginLogout.Name = "buttonLoginLogout";
            this.buttonLoginLogout.Size = new System.Drawing.Size(81, 46);
            this.buttonLoginLogout.TabIndex = 0;
            this.buttonLoginLogout.Text = "Login";
            this.buttonLoginLogout.UseVisualStyleBackColor = true;
            this.buttonLoginLogout.Click += new System.EventHandler(this.ButtonLoginLogout_Click);
            // 
            // textUserGender
            // 
            this.textUserGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserGender.Location = new System.Drawing.Point(359, 192);
            this.textUserGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUserGender.Name = "textUserGender";
            this.textUserGender.Size = new System.Drawing.Size(256, 19);
            this.textUserGender.TabIndex = 9;
            this.textUserGender.Visible = false;
            // 
            // pictureProfile
            // 
            this.pictureProfile.Location = new System.Drawing.Point(65, 65);
            this.pictureProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(147, 159);
            this.pictureProfile.TabIndex = 1;
            this.pictureProfile.TabStop = false;
            this.pictureProfile.Visible = false;
            // 
            // textGenderReadOnly
            // 
            this.textGenderReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.textGenderReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textGenderReadOnly.Location = new System.Drawing.Point(239, 192);
            this.textGenderReadOnly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textGenderReadOnly.Name = "textGenderReadOnly";
            this.textGenderReadOnly.ReadOnly = true;
            this.textGenderReadOnly.Size = new System.Drawing.Size(100, 19);
            this.textGenderReadOnly.TabIndex = 8;
            this.textGenderReadOnly.Text = "Gender:";
            this.textGenderReadOnly.Visible = false;
            // 
            // textEmailReadOnly
            // 
            this.textEmailReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.textEmailReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmailReadOnly.Location = new System.Drawing.Point(239, 153);
            this.textEmailReadOnly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEmailReadOnly.Name = "textEmailReadOnly";
            this.textEmailReadOnly.ReadOnly = true;
            this.textEmailReadOnly.Size = new System.Drawing.Size(100, 19);
            this.textEmailReadOnly.TabIndex = 4;
            this.textEmailReadOnly.Text = "Email:";
            this.textEmailReadOnly.Visible = false;
            // 
            // textUserEmail
            // 
            this.textUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserEmail.Location = new System.Drawing.Point(359, 153);
            this.textUserEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUserEmail.Name = "textUserEmail";
            this.textUserEmail.Size = new System.Drawing.Size(256, 19);
            this.textUserEmail.TabIndex = 7;
            this.textUserEmail.Visible = false;
            // 
            // textUserFullName
            // 
            this.textUserFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserFullName.Location = new System.Drawing.Point(359, 75);
            this.textUserFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUserFullName.Name = "textUserFullName";
            this.textUserFullName.Size = new System.Drawing.Size(256, 19);
            this.textUserFullName.TabIndex = 5;
            this.textUserFullName.Visible = false;
            // 
            // textNameReadOnly
            // 
            this.textNameReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.textNameReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNameReadOnly.Location = new System.Drawing.Point(239, 75);
            this.textNameReadOnly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNameReadOnly.Name = "textNameReadOnly";
            this.textNameReadOnly.ReadOnly = true;
            this.textNameReadOnly.Size = new System.Drawing.Size(100, 19);
            this.textNameReadOnly.TabIndex = 2;
            this.textNameReadOnly.Text = "Name:";
            this.textNameReadOnly.Visible = false;
            // 
            // textBirthDayReadOnly
            // 
            this.textBirthDayReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.textBirthDayReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBirthDayReadOnly.Location = new System.Drawing.Point(239, 113);
            this.textBirthDayReadOnly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBirthDayReadOnly.Name = "textBirthDayReadOnly";
            this.textBirthDayReadOnly.ReadOnly = true;
            this.textBirthDayReadOnly.Size = new System.Drawing.Size(100, 19);
            this.textBirthDayReadOnly.TabIndex = 3;
            this.textBirthDayReadOnly.Text = "Date Of Birth:";
            this.textBirthDayReadOnly.Visible = false;
            // 
            // textUserBirthDay
            // 
            this.textUserBirthDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserBirthDay.Location = new System.Drawing.Point(359, 113);
            this.textUserBirthDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUserBirthDay.Name = "textUserBirthDay";
            this.textUserBirthDay.Size = new System.Drawing.Size(256, 19);
            this.textUserBirthDay.TabIndex = 6;
            this.textUserBirthDay.Visible = false;
            // 
            // FeedTab
            // 
            this.FeedTab.Location = new System.Drawing.Point(4, 29);
            this.FeedTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeedTab.Name = "FeedTab";
            this.FeedTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeedTab.Size = new System.Drawing.Size(1030, 539);
            this.FeedTab.TabIndex = 1;
            this.FeedTab.Text = "Feed";
            this.FeedTab.UseVisualStyleBackColor = true;
            // 
            // FriendsListTab
            // 
            this.FriendsListTab.Controls.Add(this.listViewFriendsList);
            this.FriendsListTab.Controls.Add(this.textBoxNumberOfFriends);
            this.FriendsListTab.Controls.Add(this.textBoxFriendsCounter);
            this.FriendsListTab.Location = new System.Drawing.Point(4, 29);
            this.FriendsListTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FriendsListTab.Name = "FriendsListTab";
            this.FriendsListTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FriendsListTab.Size = new System.Drawing.Size(1030, 539);
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
            this.listViewFriendsList.Location = new System.Drawing.Point(9, 95);
            this.listViewFriendsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewFriendsList.Name = "listViewFriendsList";
            this.listViewFriendsList.Size = new System.Drawing.Size(298, 202);
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
            this.textBoxNumberOfFriends.Location = new System.Drawing.Point(9, 26);
            this.textBoxNumberOfFriends.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumberOfFriends.Name = "textBoxNumberOfFriends";
            this.textBoxNumberOfFriends.Size = new System.Drawing.Size(215, 22);
            this.textBoxNumberOfFriends.TabIndex = 15;
            this.textBoxNumberOfFriends.Text = "Total number of friends:";
            // 
            // textBoxFriendsCounter
            // 
            this.textBoxFriendsCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFriendsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxFriendsCounter.Location = new System.Drawing.Point(231, 26);
            this.textBoxFriendsCounter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFriendsCounter.Name = "textBoxFriendsCounter";
            this.textBoxFriendsCounter.Size = new System.Drawing.Size(44, 22);
            this.textBoxFriendsCounter.TabIndex = 14;
            this.textBoxFriendsCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FaceBookMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 572);
            this.Controls.Add(this.tabsControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FaceBookMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
        private System.Windows.Forms.TabPage FeedTab;
        private System.Windows.Forms.TabPage FriendsListTab;
        private System.Windows.Forms.TextBox textBoxFriendsCounter;
        private System.Windows.Forms.TextBox textBoxNumberOfFriends;
        private System.Windows.Forms.ListView listViewFriendsList;
        private System.Windows.Forms.ColumnHeader friendColumnHeader;
        private System.Windows.Forms.TabPage ProfileTab;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.ListView listViewUserStatuses;
        private System.Windows.Forms.TextBox textUserGender;
        private System.Windows.Forms.TextBox textGenderReadOnly;
        private System.Windows.Forms.TextBox textUserEmail;
        private System.Windows.Forms.TextBox textNameReadOnly;
        private System.Windows.Forms.TextBox textUserBirthDay;
        private System.Windows.Forms.TextBox textBirthDayReadOnly;
        private System.Windows.Forms.TextBox textUserFullName;
        private System.Windows.Forms.TextBox textEmailReadOnly;
        private System.Windows.Forms.PictureBox pictureProfile;
        private System.Windows.Forms.Button buttonLoginLogout;
        private System.Windows.Forms.ComboBox comboBoxStatusesSort;
    }
}

