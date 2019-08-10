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
                if (selectedFriend.PictureSqaureURL != null)
                {
                    pictureBoxSelectedFriend.LoadAsync(selectedFriend.PictureSqaureURL);
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
/*
                    listBoxAlbumsList.Items.Clear();
                    listBoxAlbumsList.DisplayMember = "Album";
                    foreach (Album album in m_LoggedInUser.Albums)
                    {
                        listBoxAlbumsList.Items.Add(album.Name);
                    }

                    if (m_LoggedInUser.Albums.Count == 0)
                    {
                        MessageBox.Show("No Albums to retrieve :(");
                    }
 */

/*
        int friendProfilePicturesIndex = 0;
        m_ImageList.ImageSize = new Size(40, 40);
        foreach (User friend in m_LoggedInUser.Friends)
        {
            if (friendProfilePicturesIndex < 3)
            {
                m_ImageListUrls.Add(friend.PictureSmallURL);

                WebClient fetchImageUsingUrl = new WebClient();
                byte[] imageByte = fetchImageUsingUrl.DownloadData(m_ImageListUrls[friendProfilePicturesIndex]);
                MemoryStream stream = new MemoryStream(imageByte);

                Image newImage = Image.FromStream(stream);
                m_ImageList.Images.Add(newImage);

                listViewFriendsList.Items.Add(friend.Name, friendProfilePicturesIndex);
                friendProfilePicturesIndex++;
            }
        }
        listViewFriendsList.LargeImageList = m_ImageList;
*/

/*
         private void listBoxAlbumsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int myIndex = 0;
            m_ImageList.ImageSize = new Size(50, 50);
            listViewSelectedAlbumPictures.Items.Clear();
            ImageList imageList = new ImageList();
            Album selectedAlbum = listBoxAlbumsList.SelectedItem as Album;
            
            foreach (Album album in m_LoggedInUser.Albums)
            {
                WebClient fetchImageUsingUrl = new WebClient();
                byte[] imageByte = fetchImageUsingUrl.DownloadData(m_ImageListUrls[myIndex]);
                MemoryStream stream = new MemoryStream(imageByte);

                Image newImage = Image.FromStream(stream);
                m_ImageList.Images.Add(newImage);

                listViewSelectedAlbumPictures.Items.Add("", myIndex);
                myIndex++;
            }
        }
*/

/*
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
*/
    }
}
