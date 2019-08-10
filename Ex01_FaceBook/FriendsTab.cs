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
        private void listBoxFriendsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void fetchFriendsList()
        {
             listBoxFriendsList.Items.Clear();
             listBoxFriendsList.DisplayMember = "Name";
             foreach (User friend in m_LoggedInUser.Friends)
             {
                 listBoxFriendsList.Items.Add(friend);
                 friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
             }

             if (m_LoggedInUser.Friends.Count == 0)
             {
                 MessageBox.Show("No Friends to retrieve :(");
             }

            displayNumberOfFriends();
        }

        private void displaySelectedFriend()
        {
            if (listBoxFriendsList.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFriendsList.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxSelectedFriend.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    pictureBoxSelectedFriend.Image = pictureBoxSelectedFriend.ErrorImage;
                }
            }
        }


        private void displayNumberOfFriends()
        {
            textBoxFriendsCounter.Text = listBoxFriendsList.Items.Count.ToString();
        }


        private void fetchAlbumsList()
        {
            listViewSelectedAlbumPhotos.ItemSelectionChanged += ListViewSelectedAlbumPhotos_ItemSelectionChanged;
            int albumIndex = 0;
            m_ImageList.ImageSize = new Size(40, 40);
            foreach (Album album in m_LoggedInUser.Albums)
            {
                m_ImageListUrls.Add(album.PictureSmallURL);

                WebClient fetchImageUsingUrl = new WebClient();
                byte[] imageByte = fetchImageUsingUrl.DownloadData(m_ImageListUrls[albumIndex]);
                MemoryStream stream = new MemoryStream(imageByte);

                Image newImage = Image.FromStream(stream);
                m_ImageList.Images.Add(newImage);

                listViewSelectedAlbumPhotos.Items.Add(album.Name, albumIndex);
                albumIndex++;
            }
            listViewSelectedAlbumPhotos.LargeImageList = m_ImageList;
        }

        private void ListViewSelectedAlbumPhotos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                int selectedIndex = listViewSelectedAlbumPhotos.SelectedIndices[0];
                label1.Text = m_LoggedInUser.Albums[selectedIndex].Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
