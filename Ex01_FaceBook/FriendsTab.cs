using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01_FaceBook
{
    partial class FaceBookMainForm
    {
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
