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
            this.MatchFinderTab = new System.Windows.Forms.TabPage();
            this.panelMatchDetails = new System.Windows.Forms.Panel();
            this.textBoxMatchFoundBday = new System.Windows.Forms.TextBox();
            this.textBoxMatchFoundGender = new System.Windows.Forms.TextBox();
            this.textBoxMatchFoundName = new System.Windows.Forms.TextBox();
            this.labelMatchFoundBday = new System.Windows.Forms.Label();
            this.labelMatchFoundGender = new System.Windows.Forms.Label();
            this.labelMatchFoundName = new System.Windows.Forms.Label();
            this.pictureBoxMatch = new System.Windows.Forms.PictureBox();
            this.listBoxMatches = new System.Windows.Forms.ListBox();
            this.buttonMatchFinder = new System.Windows.Forms.Button();
            this.numericUpDownMaxAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinAge = new System.Windows.Forms.NumericUpDown();
            this.labelMatchMaxAge = new System.Windows.Forms.Label();
            this.labelMatchMinAge = new System.Windows.Forms.Label();
            this.comboBoxMatchGender = new System.Windows.Forms.ComboBox();
            this.labelMatchGender = new System.Windows.Forms.Label();
            this.labelMatchQuestion = new System.Windows.Forms.Label();
            this.FriendsListTab = new System.Windows.Forms.TabPage();
            this.listViewFriendsList = new System.Windows.Forms.ListView();
            this.friendColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxNumberOfFriends = new System.Windows.Forms.TextBox();
            this.textBoxFriendsCounter = new System.Windows.Forms.TextBox();
            this.tabsControl.SuspendLayout();
            this.ProfileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.MatchFinderTab.SuspendLayout();
            this.panelMatchDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).BeginInit();
            this.FriendsListTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.ProfileTab);
            this.tabsControl.Controls.Add(this.MatchFinderTab);
            this.tabsControl.Controls.Add(this.FriendsListTab);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Location = new System.Drawing.Point(0, 0);
            this.tabsControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(978, 744);
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
            this.ProfileTab.Size = new System.Drawing.Size(970, 711);
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
            this.comboBoxStatusesSort.Location = new System.Drawing.Point(33, 263);
            this.comboBoxStatusesSort.Name = "comboBoxStatusesSort";
            this.comboBoxStatusesSort.Size = new System.Drawing.Size(221, 28);
            this.comboBoxStatusesSort.TabIndex = 13;
            this.comboBoxStatusesSort.Text = "Sort Statuses by";
            this.comboBoxStatusesSort.Visible = false;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(133, 24);
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
            this.buttonLoginLogout.Location = new System.Drawing.Point(33, 13);
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
            this.textUserGender.Location = new System.Drawing.Point(327, 192);
            this.textUserGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUserGender.Name = "textUserGender";
            this.textUserGender.Size = new System.Drawing.Size(256, 19);
            this.textUserGender.TabIndex = 9;
            this.textUserGender.Visible = false;
            // 
            // pictureProfile
            // 
            this.pictureProfile.Location = new System.Drawing.Point(33, 65);
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
            this.textGenderReadOnly.Location = new System.Drawing.Point(207, 192);
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
            this.textEmailReadOnly.Location = new System.Drawing.Point(207, 153);
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
            this.textUserEmail.Location = new System.Drawing.Point(327, 153);
            this.textUserEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUserEmail.Name = "textUserEmail";
            this.textUserEmail.Size = new System.Drawing.Size(256, 19);
            this.textUserEmail.TabIndex = 7;
            this.textUserEmail.Visible = false;
            // 
            // textUserFullName
            // 
            this.textUserFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserFullName.Location = new System.Drawing.Point(327, 75);
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
            this.textNameReadOnly.Location = new System.Drawing.Point(207, 75);
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
            this.textBirthDayReadOnly.Location = new System.Drawing.Point(207, 113);
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
            this.textUserBirthDay.Location = new System.Drawing.Point(327, 113);
            this.textUserBirthDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUserBirthDay.Name = "textUserBirthDay";
            this.textUserBirthDay.Size = new System.Drawing.Size(256, 19);
            this.textUserBirthDay.TabIndex = 6;
            this.textUserBirthDay.Visible = false;
            // 
            // MatchFinderTab
            // 
            this.MatchFinderTab.Controls.Add(this.panelMatchDetails);
            this.MatchFinderTab.Controls.Add(this.listBoxMatches);
            this.MatchFinderTab.Controls.Add(this.buttonMatchFinder);
            this.MatchFinderTab.Controls.Add(this.numericUpDownMaxAge);
            this.MatchFinderTab.Controls.Add(this.numericUpDownMinAge);
            this.MatchFinderTab.Controls.Add(this.labelMatchMaxAge);
            this.MatchFinderTab.Controls.Add(this.labelMatchMinAge);
            this.MatchFinderTab.Controls.Add(this.comboBoxMatchGender);
            this.MatchFinderTab.Controls.Add(this.labelMatchGender);
            this.MatchFinderTab.Controls.Add(this.labelMatchQuestion);
            this.MatchFinderTab.Location = new System.Drawing.Point(4, 29);
            this.MatchFinderTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MatchFinderTab.Name = "MatchFinderTab";
            this.MatchFinderTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MatchFinderTab.Size = new System.Drawing.Size(970, 711);
            this.MatchFinderTab.TabIndex = 1;
            this.MatchFinderTab.Text = "MatchFinder";
            this.MatchFinderTab.UseVisualStyleBackColor = true;
            // 
            // panelMatchDetails
            // 
            this.panelMatchDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMatchDetails.Controls.Add(this.textBoxMatchFoundBday);
            this.panelMatchDetails.Controls.Add(this.textBoxMatchFoundGender);
            this.panelMatchDetails.Controls.Add(this.textBoxMatchFoundName);
            this.panelMatchDetails.Controls.Add(this.labelMatchFoundBday);
            this.panelMatchDetails.Controls.Add(this.labelMatchFoundGender);
            this.panelMatchDetails.Controls.Add(this.labelMatchFoundName);
            this.panelMatchDetails.Controls.Add(this.pictureBoxMatch);
            this.panelMatchDetails.Location = new System.Drawing.Point(706, 61);
            this.panelMatchDetails.Name = "panelMatchDetails";
            this.panelMatchDetails.Size = new System.Drawing.Size(220, 245);
            this.panelMatchDetails.TabIndex = 9;
            // 
            // textBoxMatchFoundBday
            // 
            this.textBoxMatchFoundBday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMatchFoundBday.Location = new System.Drawing.Point(93, 199);
            this.textBoxMatchFoundBday.Name = "textBoxMatchFoundBday";
            this.textBoxMatchFoundBday.Size = new System.Drawing.Size(124, 19);
            this.textBoxMatchFoundBday.TabIndex = 6;
            // 
            // textBoxMatchFoundGender
            // 
            this.textBoxMatchFoundGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMatchFoundGender.Location = new System.Drawing.Point(93, 162);
            this.textBoxMatchFoundGender.Name = "textBoxMatchFoundGender";
            this.textBoxMatchFoundGender.Size = new System.Drawing.Size(124, 19);
            this.textBoxMatchFoundGender.TabIndex = 5;
            // 
            // textBoxMatchFoundName
            // 
            this.textBoxMatchFoundName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMatchFoundName.Location = new System.Drawing.Point(93, 127);
            this.textBoxMatchFoundName.Name = "textBoxMatchFoundName";
            this.textBoxMatchFoundName.Size = new System.Drawing.Size(124, 19);
            this.textBoxMatchFoundName.TabIndex = 4;
            // 
            // labelMatchFoundBday
            // 
            this.labelMatchFoundBday.AutoSize = true;
            this.labelMatchFoundBday.Location = new System.Drawing.Point(4, 199);
            this.labelMatchFoundBday.Name = "labelMatchFoundBday";
            this.labelMatchFoundBday.Size = new System.Drawing.Size(71, 20);
            this.labelMatchFoundBday.TabIndex = 3;
            this.labelMatchFoundBday.Text = "Birthday:";
            this.labelMatchFoundBday.Visible = false;
            // 
            // labelMatchFoundGender
            // 
            this.labelMatchFoundGender.AutoSize = true;
            this.labelMatchFoundGender.Location = new System.Drawing.Point(4, 162);
            this.labelMatchFoundGender.Name = "labelMatchFoundGender";
            this.labelMatchFoundGender.Size = new System.Drawing.Size(67, 20);
            this.labelMatchFoundGender.TabIndex = 2;
            this.labelMatchFoundGender.Text = "Gender:";
            this.labelMatchFoundGender.Visible = false;
            // 
            // labelMatchFoundName
            // 
            this.labelMatchFoundName.AutoSize = true;
            this.labelMatchFoundName.Location = new System.Drawing.Point(4, 127);
            this.labelMatchFoundName.Name = "labelMatchFoundName";
            this.labelMatchFoundName.Size = new System.Drawing.Size(55, 20);
            this.labelMatchFoundName.TabIndex = 1;
            this.labelMatchFoundName.Text = "Name:";
            this.labelMatchFoundName.Visible = false;
            // 
            // pictureBoxMatch
            // 
            this.pictureBoxMatch.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxMatch.Name = "pictureBoxMatch";
            this.pictureBoxMatch.Size = new System.Drawing.Size(125, 110);
            this.pictureBoxMatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMatch.TabIndex = 0;
            this.pictureBoxMatch.TabStop = false;
            // 
            // listBoxMatches
            // 
            this.listBoxMatches.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxMatches.FormattingEnabled = true;
            this.listBoxMatches.ItemHeight = 20;
            this.listBoxMatches.Location = new System.Drawing.Point(371, 61);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(233, 244);
            this.listBoxMatches.TabIndex = 8;
            // 
            // buttonMatchFinder
            // 
            this.buttonMatchFinder.Location = new System.Drawing.Point(60, 265);
            this.buttonMatchFinder.Name = "buttonMatchFinder";
            this.buttonMatchFinder.Size = new System.Drawing.Size(205, 41);
            this.buttonMatchFinder.TabIndex = 7;
            this.buttonMatchFinder.Text = "Find me a match";
            this.buttonMatchFinder.UseVisualStyleBackColor = true;
            this.buttonMatchFinder.Click += new System.EventHandler(this.ButtonMatchFinder_Click);
            // 
            // numericUpDownMaxAge
            // 
            this.numericUpDownMaxAge.Location = new System.Drawing.Point(209, 200);
            this.numericUpDownMaxAge.Name = "numericUpDownMaxAge";
            this.numericUpDownMaxAge.Size = new System.Drawing.Size(55, 26);
            this.numericUpDownMaxAge.TabIndex = 6;
            // 
            // numericUpDownMinAge
            // 
            this.numericUpDownMinAge.Location = new System.Drawing.Point(209, 155);
            this.numericUpDownMinAge.Name = "numericUpDownMinAge";
            this.numericUpDownMinAge.Size = new System.Drawing.Size(55, 26);
            this.numericUpDownMinAge.TabIndex = 5;
            // 
            // labelMatchMaxAge
            // 
            this.labelMatchMaxAge.AutoSize = true;
            this.labelMatchMaxAge.Location = new System.Drawing.Point(56, 200);
            this.labelMatchMaxAge.Name = "labelMatchMaxAge";
            this.labelMatchMaxAge.Size = new System.Drawing.Size(111, 20);
            this.labelMatchMaxAge.TabIndex = 4;
            this.labelMatchMaxAge.Text = "Maximum age:";
            // 
            // labelMatchMinAge
            // 
            this.labelMatchMinAge.AutoSize = true;
            this.labelMatchMinAge.Location = new System.Drawing.Point(56, 155);
            this.labelMatchMinAge.Name = "labelMatchMinAge";
            this.labelMatchMinAge.Size = new System.Drawing.Size(107, 20);
            this.labelMatchMinAge.TabIndex = 3;
            this.labelMatchMinAge.Text = "Minimum age:";
            // 
            // comboBoxMatchGender
            // 
            this.comboBoxMatchGender.FormattingEnabled = true;
            this.comboBoxMatchGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Both"});
            this.comboBoxMatchGender.Location = new System.Drawing.Point(144, 105);
            this.comboBoxMatchGender.Name = "comboBoxMatchGender";
            this.comboBoxMatchGender.Size = new System.Drawing.Size(121, 28);
            this.comboBoxMatchGender.TabIndex = 2;
            // 
            // labelMatchGender
            // 
            this.labelMatchGender.AutoSize = true;
            this.labelMatchGender.Location = new System.Drawing.Point(56, 108);
            this.labelMatchGender.Name = "labelMatchGender";
            this.labelMatchGender.Size = new System.Drawing.Size(67, 20);
            this.labelMatchGender.TabIndex = 1;
            this.labelMatchGender.Text = "Gender:";
            // 
            // labelMatchQuestion
            // 
            this.labelMatchQuestion.AutoSize = true;
            this.labelMatchQuestion.Location = new System.Drawing.Point(52, 61);
            this.labelMatchQuestion.Name = "labelMatchQuestion";
            this.labelMatchQuestion.Size = new System.Drawing.Size(213, 20);
            this.labelMatchQuestion.TabIndex = 0;
            this.labelMatchQuestion.Text = "What Are You Interested In?";
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
            this.FriendsListTab.Size = new System.Drawing.Size(970, 711);
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
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.tabsControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1200, 1200);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "FaceBookMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FaceBook";
            this.tabsControl.ResumeLayout(false);
            this.ProfileTab.ResumeLayout(false);
            this.ProfileTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.MatchFinderTab.ResumeLayout(false);
            this.MatchFinderTab.PerformLayout();
            this.panelMatchDetails.ResumeLayout(false);
            this.panelMatchDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).EndInit();
            this.FriendsListTab.ResumeLayout(false);
            this.FriendsListTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage MatchFinderTab;
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
        private System.Windows.Forms.Button buttonMatchFinder;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxAge;
        private System.Windows.Forms.NumericUpDown numericUpDownMinAge;
        private System.Windows.Forms.Label labelMatchMaxAge;
        private System.Windows.Forms.Label labelMatchMinAge;
        private System.Windows.Forms.ComboBox comboBoxMatchGender;
        private System.Windows.Forms.Label labelMatchGender;
        private System.Windows.Forms.Label labelMatchQuestion;
        private System.Windows.Forms.ListBox listBoxMatches;
        private System.Windows.Forms.Panel panelMatchDetails;
        private System.Windows.Forms.TextBox textBoxMatchFoundBday;
        private System.Windows.Forms.TextBox textBoxMatchFoundGender;
        private System.Windows.Forms.TextBox textBoxMatchFoundName;
        private System.Windows.Forms.Label labelMatchFoundBday;
        private System.Windows.Forms.Label labelMatchFoundGender;
        private System.Windows.Forms.Label labelMatchFoundName;
        private System.Windows.Forms.PictureBox pictureBoxMatch;
    }
}

