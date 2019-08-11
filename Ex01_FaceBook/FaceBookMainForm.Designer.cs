namespace Ex01_FaceBook
{
    public partial class FaceBookMainForm
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
            this.labelMatchesTitleReadOnly = new System.Windows.Forms.Label();
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
            this.FriendsAndAlbums = new System.Windows.Forms.TabPage();
            this.textBoxAlbumOwner = new System.Windows.Forms.TextBox();
            this.textBoxAlbumCreationTime = new System.Windows.Forms.TextBox();
            this.textBoxAlbumLikesCount = new System.Windows.Forms.TextBox();
            this.textBoxAlbumCommentsCount = new System.Windows.Forms.TextBox();
            this.textBoxCommentsCountReadOnly = new System.Windows.Forms.TextBox();
            this.textBoxAlbumOwnerReadOnly = new System.Windows.Forms.TextBox();
            this.textBoxCreationTimeReadOnly = new System.Windows.Forms.TextBox();
            this.textBoxLikesCountReadOnly = new System.Windows.Forms.TextBox();
            this.textBoxPhotosTitle = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBoxFriendsListHeadLine = new System.Windows.Forms.TextBox();
            this.textBoxAlbumsHeadLine = new System.Windows.Forms.TextBox();
            this.listViewSelectedAlbumPhotos = new System.Windows.Forms.ListView();
            this.pictureBoxSelectedFriend = new System.Windows.Forms.PictureBox();
            this.listBoxFriendsList = new System.Windows.Forms.ListBox();
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
            this.FriendsAndAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.ProfileTab);
            this.tabsControl.Controls.Add(this.MatchFinderTab);
            this.tabsControl.Controls.Add(this.FriendsAndAlbums);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Location = new System.Drawing.Point(0, 0);
            this.tabsControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(1159, 752);
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
            this.ProfileTab.Size = new System.Drawing.Size(1151, 719);
            this.ProfileTab.TabIndex = 0;
            this.ProfileTab.Text = "Profile";
            this.ProfileTab.UseVisualStyleBackColor = true;
            // 
            // comboBoxStatusesSort
            // 
            this.comboBoxStatusesSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxStatusesSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatusesSort.Items.AddRange(new object[] {
            "Upload Date - most recent",
            "Number of likes",
            "Number of comments"});
            this.comboBoxStatusesSort.Location = new System.Drawing.Point(33, 262);
            this.comboBoxStatusesSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStatusesSort.Name = "comboBoxStatusesSort";
            this.comboBoxStatusesSort.Size = new System.Drawing.Size(221, 28);
            this.comboBoxStatusesSort.TabIndex = 13;
            this.comboBoxStatusesSort.Visible = false;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(133, 24);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.listViewUserStatuses.Location = new System.Drawing.Point(4, 274);
            this.listViewUserStatuses.Margin = new System.Windows.Forms.Padding(0);
            this.listViewUserStatuses.Name = "listViewUserStatuses";
            this.listViewUserStatuses.Size = new System.Drawing.Size(1151, 442);
            this.listViewUserStatuses.TabIndex = 10;
            this.listViewUserStatuses.UseCompatibleStateImageBehavior = false;
            this.listViewUserStatuses.View = System.Windows.Forms.View.Details;
            // 
            // buttonLoginLogout
            // 
            this.buttonLoginLogout.Location = new System.Drawing.Point(33, 12);
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
            this.textEmailReadOnly.Location = new System.Drawing.Point(207, 152);
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
            this.textUserEmail.Location = new System.Drawing.Point(327, 152);
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
            this.textBirthDayReadOnly.Location = new System.Drawing.Point(207, 112);
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
            this.textUserBirthDay.Location = new System.Drawing.Point(327, 112);
            this.textUserBirthDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUserBirthDay.Name = "textUserBirthDay";
            this.textUserBirthDay.Size = new System.Drawing.Size(256, 19);
            this.textUserBirthDay.TabIndex = 6;
            this.textUserBirthDay.Visible = false;
            // 
            // MatchFinderTab
            // 
            this.MatchFinderTab.Controls.Add(this.labelMatchesTitleReadOnly);
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
            this.MatchFinderTab.Size = new System.Drawing.Size(1151, 719);
            this.MatchFinderTab.TabIndex = 1;
            this.MatchFinderTab.Text = "MatchFinder";
            this.MatchFinderTab.UseVisualStyleBackColor = true;
            // 
            // labelMatchesTitleReadOnly
            // 
            this.labelMatchesTitleReadOnly.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMatchesTitleReadOnly.AutoSize = true;
            this.labelMatchesTitleReadOnly.Location = new System.Drawing.Point(540, 70);
            this.labelMatchesTitleReadOnly.Name = "labelMatchesTitleReadOnly";
            this.labelMatchesTitleReadOnly.Size = new System.Drawing.Size(74, 20);
            this.labelMatchesTitleReadOnly.TabIndex = 7;
            this.labelMatchesTitleReadOnly.Text = "Matches:";
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
            this.panelMatchDetails.Location = new System.Drawing.Point(888, 61);
            this.panelMatchDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMatchDetails.Name = "panelMatchDetails";
            this.panelMatchDetails.Size = new System.Drawing.Size(220, 245);
            this.panelMatchDetails.TabIndex = 9;
            // 
            // textBoxMatchFoundBday
            // 
            this.textBoxMatchFoundBday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMatchFoundBday.Location = new System.Drawing.Point(93, 199);
            this.textBoxMatchFoundBday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMatchFoundBday.Name = "textBoxMatchFoundBday";
            this.textBoxMatchFoundBday.Size = new System.Drawing.Size(124, 19);
            this.textBoxMatchFoundBday.TabIndex = 6;
            // 
            // textBoxMatchFoundGender
            // 
            this.textBoxMatchFoundGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMatchFoundGender.Location = new System.Drawing.Point(93, 162);
            this.textBoxMatchFoundGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMatchFoundGender.Name = "textBoxMatchFoundGender";
            this.textBoxMatchFoundGender.Size = new System.Drawing.Size(124, 19);
            this.textBoxMatchFoundGender.TabIndex = 5;
            // 
            // textBoxMatchFoundName
            // 
            this.textBoxMatchFoundName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMatchFoundName.Location = new System.Drawing.Point(93, 128);
            this.textBoxMatchFoundName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.labelMatchFoundName.Location = new System.Drawing.Point(4, 128);
            this.labelMatchFoundName.Name = "labelMatchFoundName";
            this.labelMatchFoundName.Size = new System.Drawing.Size(55, 20);
            this.labelMatchFoundName.TabIndex = 1;
            this.labelMatchFoundName.Text = "Name:";
            this.labelMatchFoundName.Visible = false;
            // 
            // pictureBoxMatch
            // 
            this.pictureBoxMatch.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxMatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.listBoxMatches.Location = new System.Drawing.Point(462, 101);
            this.listBoxMatches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(234, 204);
            this.listBoxMatches.TabIndex = 8;
            // 
            // buttonMatchFinder
            // 
            this.buttonMatchFinder.Location = new System.Drawing.Point(60, 265);
            this.buttonMatchFinder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.numericUpDownMaxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMaxAge.Name = "numericUpDownMaxAge";
            this.numericUpDownMaxAge.Size = new System.Drawing.Size(55, 26);
            this.numericUpDownMaxAge.TabIndex = 6;
            // 
            // numericUpDownMinAge
            // 
            this.numericUpDownMinAge.Location = new System.Drawing.Point(209, 155);
            this.numericUpDownMinAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.comboBoxMatchGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatchGender.FormattingEnabled = true;
            this.comboBoxMatchGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Both"});
            this.comboBoxMatchGender.Location = new System.Drawing.Point(144, 105);
            this.comboBoxMatchGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // FriendsAndAlbums
            // 
            this.FriendsAndAlbums.Controls.Add(this.textBoxAlbumOwner);
            this.FriendsAndAlbums.Controls.Add(this.textBoxAlbumCreationTime);
            this.FriendsAndAlbums.Controls.Add(this.textBoxAlbumLikesCount);
            this.FriendsAndAlbums.Controls.Add(this.textBoxAlbumCommentsCount);
            this.FriendsAndAlbums.Controls.Add(this.textBoxCommentsCountReadOnly);
            this.FriendsAndAlbums.Controls.Add(this.textBoxAlbumOwnerReadOnly);
            this.FriendsAndAlbums.Controls.Add(this.textBoxCreationTimeReadOnly);
            this.FriendsAndAlbums.Controls.Add(this.textBoxLikesCountReadOnly);
            this.FriendsAndAlbums.Controls.Add(this.textBoxPhotosTitle);
            this.FriendsAndAlbums.Controls.Add(this.listView1);
            this.FriendsAndAlbums.Controls.Add(this.textBoxFriendsListHeadLine);
            this.FriendsAndAlbums.Controls.Add(this.textBoxAlbumsHeadLine);
            this.FriendsAndAlbums.Controls.Add(this.listViewSelectedAlbumPhotos);
            this.FriendsAndAlbums.Controls.Add(this.pictureBoxSelectedFriend);
            this.FriendsAndAlbums.Controls.Add(this.listBoxFriendsList);
            this.FriendsAndAlbums.Controls.Add(this.textBoxNumberOfFriends);
            this.FriendsAndAlbums.Controls.Add(this.textBoxFriendsCounter);
            this.FriendsAndAlbums.Location = new System.Drawing.Point(4, 29);
            this.FriendsAndAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FriendsAndAlbums.Name = "FriendsAndAlbums";
            this.FriendsAndAlbums.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FriendsAndAlbums.Size = new System.Drawing.Size(1151, 719);
            this.FriendsAndAlbums.TabIndex = 2;
            this.FriendsAndAlbums.Text = "FriendsAndAlbums";
            this.FriendsAndAlbums.UseVisualStyleBackColor = true;
            // 
            // textBoxAlbumOwner
            // 
            this.textBoxAlbumOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlbumOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlbumOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxAlbumOwner.Location = new System.Drawing.Point(945, 96);
            this.textBoxAlbumOwner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAlbumOwner.Name = "textBoxAlbumOwner";
            this.textBoxAlbumOwner.Size = new System.Drawing.Size(162, 19);
            this.textBoxAlbumOwner.TabIndex = 33;
            // 
            // textBoxAlbumCreationTime
            // 
            this.textBoxAlbumCreationTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlbumCreationTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlbumCreationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxAlbumCreationTime.Location = new System.Drawing.Point(945, 126);
            this.textBoxAlbumCreationTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAlbumCreationTime.Name = "textBoxAlbumCreationTime";
            this.textBoxAlbumCreationTime.Size = new System.Drawing.Size(162, 19);
            this.textBoxAlbumCreationTime.TabIndex = 32;
            // 
            // textBoxAlbumLikesCount
            // 
            this.textBoxAlbumLikesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlbumLikesCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlbumLikesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxAlbumLikesCount.Location = new System.Drawing.Point(945, 156);
            this.textBoxAlbumLikesCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAlbumLikesCount.Name = "textBoxAlbumLikesCount";
            this.textBoxAlbumLikesCount.Size = new System.Drawing.Size(162, 19);
            this.textBoxAlbumLikesCount.TabIndex = 31;
            // 
            // textBoxAlbumCommentsCount
            // 
            this.textBoxAlbumCommentsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlbumCommentsCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlbumCommentsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxAlbumCommentsCount.Location = new System.Drawing.Point(945, 186);
            this.textBoxAlbumCommentsCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAlbumCommentsCount.Name = "textBoxAlbumCommentsCount";
            this.textBoxAlbumCommentsCount.Size = new System.Drawing.Size(162, 19);
            this.textBoxAlbumCommentsCount.TabIndex = 30;
            // 
            // textBoxCommentsCountReadOnly
            // 
            this.textBoxCommentsCountReadOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommentsCountReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCommentsCountReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxCommentsCountReadOnly.Location = new System.Drawing.Point(777, 186);
            this.textBoxCommentsCountReadOnly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCommentsCountReadOnly.Name = "textBoxCommentsCountReadOnly";
            this.textBoxCommentsCountReadOnly.Size = new System.Drawing.Size(162, 19);
            this.textBoxCommentsCountReadOnly.TabIndex = 29;
            this.textBoxCommentsCountReadOnly.Text = "Number Of Comments:";
            // 
            // textBoxAlbumOwnerReadOnly
            // 
            this.textBoxAlbumOwnerReadOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlbumOwnerReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlbumOwnerReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxAlbumOwnerReadOnly.Location = new System.Drawing.Point(777, 96);
            this.textBoxAlbumOwnerReadOnly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAlbumOwnerReadOnly.Name = "textBoxAlbumOwnerReadOnly";
            this.textBoxAlbumOwnerReadOnly.Size = new System.Drawing.Size(162, 19);
            this.textBoxAlbumOwnerReadOnly.TabIndex = 28;
            this.textBoxAlbumOwnerReadOnly.Text = "Created By:";
            // 
            // textBoxCreationTimeReadOnly
            // 
            this.textBoxCreationTimeReadOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCreationTimeReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCreationTimeReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxCreationTimeReadOnly.Location = new System.Drawing.Point(777, 126);
            this.textBoxCreationTimeReadOnly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCreationTimeReadOnly.Name = "textBoxCreationTimeReadOnly";
            this.textBoxCreationTimeReadOnly.Size = new System.Drawing.Size(162, 19);
            this.textBoxCreationTimeReadOnly.TabIndex = 27;
            this.textBoxCreationTimeReadOnly.Text = "Creation Time:";
            // 
            // textBoxLikesCountReadOnly
            // 
            this.textBoxLikesCountReadOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLikesCountReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLikesCountReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxLikesCountReadOnly.Location = new System.Drawing.Point(777, 156);
            this.textBoxLikesCountReadOnly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLikesCountReadOnly.Name = "textBoxLikesCountReadOnly";
            this.textBoxLikesCountReadOnly.Size = new System.Drawing.Size(162, 19);
            this.textBoxLikesCountReadOnly.TabIndex = 26;
            this.textBoxLikesCountReadOnly.Text = "Number Of Likes:";
            // 
            // textBoxPhotosTitle
            // 
            this.textBoxPhotosTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhotosTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhotosTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPhotosTitle.Location = new System.Drawing.Point(777, 221);
            this.textBoxPhotosTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPhotosTitle.Name = "textBoxPhotosTitle";
            this.textBoxPhotosTitle.Size = new System.Drawing.Size(215, 22);
            this.textBoxPhotosTitle.TabIndex = 25;
            this.textBoxPhotosTitle.Text = "Photos:";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(777, 258);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(292, 294);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxFriendsListHeadLine
            // 
            this.textBoxFriendsListHeadLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFriendsListHeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxFriendsListHeadLine.Location = new System.Drawing.Point(140, 26);
            this.textBoxFriendsListHeadLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFriendsListHeadLine.Name = "textBoxFriendsListHeadLine";
            this.textBoxFriendsListHeadLine.Size = new System.Drawing.Size(246, 37);
            this.textBoxFriendsListHeadLine.TabIndex = 22;
            this.textBoxFriendsListHeadLine.Text = "Desig\'s Friends";
            this.textBoxFriendsListHeadLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAlbumsHeadLine
            // 
            this.textBoxAlbumsHeadLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlbumsHeadLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlbumsHeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxAlbumsHeadLine.Location = new System.Drawing.Point(693, 26);
            this.textBoxAlbumsHeadLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAlbumsHeadLine.Name = "textBoxAlbumsHeadLine";
            this.textBoxAlbumsHeadLine.Size = new System.Drawing.Size(246, 37);
            this.textBoxAlbumsHeadLine.TabIndex = 21;
            this.textBoxAlbumsHeadLine.Text = "Albums";
            this.textBoxAlbumsHeadLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listViewSelectedAlbumPhotos
            // 
            this.listViewSelectedAlbumPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSelectedAlbumPhotos.Location = new System.Drawing.Point(595, 96);
            this.listViewSelectedAlbumPhotos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewSelectedAlbumPhotos.Name = "listViewSelectedAlbumPhotos";
            this.listViewSelectedAlbumPhotos.Size = new System.Drawing.Size(160, 456);
            this.listViewSelectedAlbumPhotos.TabIndex = 20;
            this.listViewSelectedAlbumPhotos.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBoxSelectedFriend
            // 
            this.pictureBoxSelectedFriend.Location = new System.Drawing.Point(352, 145);
            this.pictureBoxSelectedFriend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxSelectedFriend.Name = "pictureBoxSelectedFriend";
            this.pictureBoxSelectedFriend.Size = new System.Drawing.Size(106, 88);
            this.pictureBoxSelectedFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSelectedFriend.TabIndex = 19;
            this.pictureBoxSelectedFriend.TabStop = false;
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.HorizontalExtent = 10;
            this.listBoxFriendsList.ItemHeight = 29;
            this.listBoxFriendsList.Location = new System.Drawing.Point(26, 145);
            this.listBoxFriendsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(319, 410);
            this.listBoxFriendsList.TabIndex = 18;
            this.listBoxFriendsList.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendsList_SelectedIndexChanged);
            // 
            // textBoxNumberOfFriends
            // 
            this.textBoxNumberOfFriends.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumberOfFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxNumberOfFriends.Location = new System.Drawing.Point(26, 92);
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
            this.textBoxFriendsCounter.Location = new System.Drawing.Point(236, 92);
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
            this.ClientSize = new System.Drawing.Size(1159, 752);
            this.Controls.Add(this.tabsControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1200, 1192);
            this.MinimumSize = new System.Drawing.Size(750, 750);
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
            this.FriendsAndAlbums.ResumeLayout(false);
            this.FriendsAndAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFriend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage MatchFinderTab;
        private System.Windows.Forms.TabPage FriendsAndAlbums;
        private System.Windows.Forms.TextBox textBoxFriendsCounter;
        private System.Windows.Forms.TextBox textBoxNumberOfFriends;
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
        private System.Windows.Forms.ListBox listBoxFriendsList;
        private System.Windows.Forms.PictureBox pictureBoxSelectedFriend;
        private System.Windows.Forms.ListView listViewSelectedAlbumPhotos;
        private System.Windows.Forms.TextBox textBoxAlbumsHeadLine;
        private System.Windows.Forms.TextBox textBoxFriendsListHeadLine;
        private System.Windows.Forms.Label labelMatchesTitleReadOnly;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBoxPhotosTitle;
        private System.Windows.Forms.TextBox textBoxAlbumOwner;
        private System.Windows.Forms.TextBox textBoxAlbumCreationTime;
        private System.Windows.Forms.TextBox textBoxAlbumLikesCount;
        private System.Windows.Forms.TextBox textBoxAlbumCommentsCount;
        private System.Windows.Forms.TextBox textBoxCommentsCountReadOnly;
        private System.Windows.Forms.TextBox textBoxAlbumOwnerReadOnly;
        private System.Windows.Forms.TextBox textBoxCreationTimeReadOnly;
        private System.Windows.Forms.TextBox textBoxLikesCountReadOnly;
    }
}