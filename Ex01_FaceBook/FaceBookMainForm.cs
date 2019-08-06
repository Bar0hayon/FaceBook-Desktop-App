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
            fetchPersonalInformation();
            //fetchFriendsList();
            fetchUserStatuses();
        }

        private void fetchUserStatuses()
        {
            ColumnHeader onlyColumn = new ColumnHeader();
            onlyColumn.Text = "Statuses";
            onlyColumn.TextAlign = HorizontalAlignment.Center;
            onlyColumn.Width = listViewUserStatuses.Width;
            listViewUserStatuses.Columns.Add(onlyColumn);
            foreach (Status status in m_LoggedInUser.Statuses)
            {
                addStatusToStatusesListView(status);
            }
        }

        private void addStatusToStatusesListView(Status i_Status)
        {
            const int statusFontSize = 12;
            const int statusInfoFontSize = 8;
            ListViewItem lvStatus = new ListViewItem(i_Status.Message);
            Font statusFont = new Font(FontFamily.GenericSansSerif, statusFontSize);
            lvStatus.Font = statusFont;
            lvStatus.BackColor = Color.LightBlue;
            ListViewItem lvStatusInfo = new ListViewItem(
                string.Format("updated at {0} | {1} likes | {2} comments", 
                i_Status.CreatedTime.ToString(),
                i_Status.LikedBy.Count.ToString(),
                i_Status.Comments.Count.ToString())
                );
            Font statusInfoFont = new Font(FontFamily.GenericSansSerif, statusInfoFontSize, 
                FontStyle.Italic);
            lvStatusInfo.Font = statusInfoFont;
            lvStatusInfo.BackColor = Color.LightBlue;
            ListViewItem lvSeparetor = new ListViewItem();
            listViewUserStatuses.Items.AddRange(new ListViewItem[] { lvStatus, lvStatusInfo, lvSeparetor });
            listViewUserStatuses.ItemSelectionChanged += listViewUserStatuses_ItemSelectionChanged;
        }

        private void listViewUserStatuses_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
                e.Item.Selected = false;
        }
        private void fetchPersonalInformation()
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

        private void fetchFriendsList()
        {
            int index = 0;
            m_ImageList.ImageSize = new Size(50, 50);
            listViewFriendsList.Items.Clear();
            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (index < 3)
                {
                    m_ImageListUrls.Add(friend.PictureSmallURL);

                    WebClient fetchImageUsingUrl = new WebClient();
                    byte[] imageByte = fetchImageUsingUrl.DownloadData(m_ImageListUrls[index]);
                    MemoryStream stream = new MemoryStream(imageByte);

                    Image newImage = Image.FromStream(stream);
                    m_ImageList.Images.Add(newImage);

                    listViewFriendsList.Items.Add(friend.Name, index);
                    index++;
                }
            }

            listViewFriendsList.SmallImageList = m_ImageList;

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }

            displayNumberOfFriends();
        }

        private void displayNumberOfFriends()
        {
            textBoxFriendsCounter.Text = listViewFriendsList.Items.Count.ToString();
        }
    }
}
