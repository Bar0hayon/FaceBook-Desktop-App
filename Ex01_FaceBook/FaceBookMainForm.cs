using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;

namespace Ex01_FaceBook
{
    public partial class FaceBookMainForm : Form
    {
        private User m_LoggedInUser;
        private bool v_LoggedIn = false;
        ImageList m_ImageList = new ImageList();
        List<String> m_ImageListUrls = new List<string>();
        private AppSettings m_AppSettings;
        LoginResult m_LoginResult;

        public FaceBookMainForm()
        {
            InitializeComponent();
            m_AppSettings = new AppSettings();
            m_AppSettings.LoadData();
            this.Size = m_AppSettings.LastWindowSize;
            this.Location = m_AppSettings.LastWindowLocation;
            this.checkBoxRememberMe.Checked = m_AppSettings.RememberUser;
            this.comboBoxStatusesSort.SelectedIndexChanged += ComboBoxStatusesSort_SelectedIndexChanged;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (m_AppSettings.RememberUser &&
                !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                try
                {
                    m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                    loggedIn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: could not automaticlly connect to facebook");
                }
            }
        }

        private void loggedIn()
        {
            v_LoggedIn = true;
            buttonLoginLogout.Text = "Logout";
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                fetchProfile();
                fetchFriendsList();
                fetchAlbumsList();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.RememberUser = this.checkBoxRememberMe.Checked;
            if (m_AppSettings.RememberUser)
            {
                m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
            }
            else
            {
                m_AppSettings.LastAccessToken = null;
            }

            m_AppSettings.SaveToFile();
        }

        private void loggedOut()
        {
            v_LoggedIn = false;
            buttonLoginLogout.Text = "Login";
            ///////move all the profile info to invisible!!************
            //profile
            pictureProfile.Visible = false;
            textNameReadOnly.Visible =     false;
            textEmailReadOnly.Visible =    false;
            textGenderReadOnly.Visible =   false;
            textUserFullName.Visible =     false;
            textUserBirthDay.Visible =     false;
            textUserEmail.Visible =        false;
            textUserGender.Visible =       false;
            comboBoxStatusesSort.Visible = false;
            textBirthDayReadOnly.Visible = false;
            //statuses
            comboBoxStatusesSort.Visible = false;
            listViewUserStatuses.Visible = false;
            //matchFinder
            pictureBoxMatch.Visible = false;
            textBoxMatchFoundBday.Visible = false;
            textBoxMatchFoundGender.Visible = false;
            textBoxMatchFoundName.Visible = false;
            labelMatchFoundBday.Visible = false;
            labelMatchFoundGender.Visible = false;
            labelMatchFoundName.Visible = false;
            listBoxMatches.Items.Clear();
        }

        private void login()
        {
            try
            {
                m_LoginResult = FacebookService.Login("1450160541956417", //(desig patter's "Design Patterns Course App 2.4" app)
                    "public_profile",
                    "email",
                    "groups_access_member_info",
                    "publish_to_groups",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_tagged_places",
                    "user_videos"
                    );
            }
            catch(Exception ex)
            {
                MessageBox.Show("an Error aqured while trying to connect to the facebook servers, please try again later",
                    "Login Request Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
