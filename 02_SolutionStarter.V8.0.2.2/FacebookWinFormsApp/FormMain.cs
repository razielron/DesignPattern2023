using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        FacebookWrapper.LoginResult m_LoginResult;
        FacebookWrapper.ObjectModel.User m_TheLoggedInUser;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {

            m_LoginResult = FacebookService.Login(
                /// (This is Desig Patter's App ID. replace it with your own)
                "274259588558246",
                /// requested permissions:
                "email",
                //"public_profile",
                "user_age_range",
                "user_birthday",
                //"user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                //"user_link",
                "user_location",
                //"user_messenger_contact",
                "user_photos",
                "user_posts"
                //"user_videos"
                /// add any relevant permissions
                );
            m_TheLoggedInUser = m_LoginResult.LoggedInUser;
            
            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {m_TheLoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_TheLoggedInUser.PictureNormalURL;
                updateDetailsAboutUser(); 
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
            }
        }

        private void updateDetailsAboutUser()
        {
            labelAbout.Text = string.Format("{0} {1}{2}Email: {3}{4}Birth Date: {5}{6}Address: {7}", 
                m_TheLoggedInUser.FirstName, 
                m_TheLoggedInUser.LastName,
                Environment.NewLine,
                m_TheLoggedInUser.Email,
                Environment.NewLine,
                m_TheLoggedInUser.Birthday,
                Environment.NewLine,
                m_TheLoggedInUser.Location);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void listBoxPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            Photo photo = m_TheLoggedInUser.Albums[listBoxAlbums.SelectedIndex].Photos[listBoxPictures.SelectedIndex];
            pictureBoxPhotos.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhotos.ImageLocation = photo.PictureNormalURL;
        }
        
        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            Album album = m_TheLoggedInUser.Albums[listBoxAlbums.SelectedIndex];
            listBoxPictures.DataSource = album.Photos;
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";
            foreach (Album album in m_TheLoggedInUser.Albums)
            {
                listBoxAlbums.Items.Add(album);
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        
       
        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post post = m_TheLoggedInUser.Posts[listBoxPosts.SelectedIndex];
            listBoxPostComments.DisplayMember = "Message";
            listBoxPostComments.DataSource = post.Comments;
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            listBoxPosts.Items.Clear();

            foreach (Post post in m_TheLoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void listBoxPostComments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxLikePages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonFetchLikePages_Click(object sender, EventArgs e)
        {
            listBoxLikePages.Items.Clear();
            listBoxLikePages.DisplayMember = "Name";

            try
            {
                foreach (Page page in m_TheLoggedInUser.LikedPages)
                {
                    listBoxLikePages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxLikePages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = "Name";
            try
            {
                foreach (Group group in m_TheLoggedInUser.Groups)
                {
                    listBoxGroups.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            listBoxCheckIn.Items.Clear();
            listBoxCheckIn.DisplayMember = "Name";
            try
            {
                foreach (Checkin checkin in m_TheLoggedInUser.Checkins)
                {
                    if(checkin.Place != null)
                    {
                        listBoxCheckIn.Items.Add(checkin.Place);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxCheckIn.Items.Count == 0)
            {
                MessageBox.Show("No checkins to retrieve :(");
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void buttonFetchLikes_Click(object sender, EventArgs e)
        {

        }

        private void buttonFetchPhotosTaggedIn_Click(object sender, EventArgs e)
        {
            listBoxPhotosTaggedIn.Items.Clear();
            listBoxPhotosTaggedIn.DisplayMember = "Name";

            try
            {
                foreach (Photo photo in m_TheLoggedInUser.PhotosTaggedIn)
                {
                    listBoxPhotosTaggedIn.Items.Add(photo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxPhotosTaggedIn.Items.Count == 0)
            {
                MessageBox.Show("No photos tagged in to retrieve :(");
            }
        }

    }
}
