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

namespace Ex01_FaceBook
{
    public partial class FaceBookMainForm : Form
    {
        private User m_LoggedInUser;
        private bool v_LoggedIn = false;

        public FaceBookMainForm()
        {
            InitializeComponent();
        }

        private void ButtonLoginLogout_Click(object sender, EventArgs e)
        {
            if(!v_LoggedIn)
            {
                login();
                buttonLoginLogout.Text = "Logout";
            }
            else
            {
                FacebookService.Logout(loggedOutSuccessfully);
                buttonLoginLogout.Text = "Login";
            }
            v_LoggedIn = !v_LoggedIn;
        }

        private void loggedOutSuccessfully()
        {
            ///////move all the profile info to invisible!!************
        }

        private void login()
        {
            LoginResult loginResult = FacebookService.Login("1450160541956417", //(desig patter's "Design Patterns Course App 2.4" app)
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
            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                m_LoggedInUser = loginResult.LoggedInUser;
                fetchProfile();
            }
            else
            {
                MessageBox.Show(loginResult.ErrorMessage);
            }
        }

        private void fetchProfile()
        {
            pictureProfile.Visible = true;
            pictureProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            FetchPersonalInformation();
        }

        private void FetchPersonalInformation()
        {
            textBirthDayReadOnly.Visible = true;
            textNameReadOnly.Visible = true;
            textEmailReadOnly.Visible = true;
            textGenderReadOnly.Visible = true;
            textUserFullName.Visible = true;
            textUserBirthDay.Visible = true;
            textUserEmail.Visible = true;
            textUserGender.Visible = true;
            textUserFullName.Text = m_LoggedInUser.Name;
            textUserBirthDay.Text = m_LoggedInUser.Birthday;
            textUserEmail.Text = m_LoggedInUser.Email;
            textUserGender.Text = m_LoggedInUser.Gender.ToString();
        }
    }
}
