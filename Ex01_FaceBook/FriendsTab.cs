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
            int albumIndex = 0;
            m_ImageList.ImageSize = new Size(40, 40);
            try
            {
                if (listViewSelectedAlbumPhotos.SelectedIndices.Count > 0)
                {
                    listView1.Clear();
                    int selectedIndex = listViewSelectedAlbumPhotos.SelectedIndices[0];
                    for (int i = 0; i <m_LoggedInUser.Albums[selectedIndex].Count; i++)
                    {
                        fetchAlbumData(selectedIndex);
                        m_ImageListUrls.Add(m_LoggedInUser.Albums[selectedIndex].PictureSmallURL);

                        WebClient fetchImageUsingUrl = new WebClient();
                        byte[] imageByte = fetchImageUsingUrl.DownloadData(m_ImageListUrls[albumIndex]);
                        MemoryStream stream = new MemoryStream(imageByte);

                        Image newImage = Image.FromStream(stream);
                        m_ImageList.Images.Add(newImage);

                        listView1.Items.Add("", albumIndex);
                        albumIndex++;
                    }
                    listView1.LargeImageList = m_ImageList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchAlbumData(int i_AlbumIndex)
        {
            textBoxAlbumCommentsCount.Text =
                m_LoggedInUser.Albums[i_AlbumIndex].Comments.Count.ToString();
            textBoxAlbumCreationTime.Text =
                m_LoggedInUser.Albums[i_AlbumIndex].CreatedTime.ToString();
            textBoxAlbumLikesCount.Text =
                m_LoggedInUser.Albums[i_AlbumIndex].LikedBy.Count.ToString();
            textBoxAlbumOwner.Text =
                m_LoggedInUser.Albums[i_AlbumIndex].From.Name;
        }
    }
}
