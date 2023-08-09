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
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
            }
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            listBoxAlbums.DisplayMember = "Name";
            listBoxAlbums.DataSource = m_TheLoggedInUser.Albums;
        }

        private void textBoxAppID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

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
            listBoxCheckIn.DisplayMember = "Message";
            try
            {
                foreach (Checkin checkin in m_TheLoggedInUser.Checkins)
                {
                    listBoxCheckIn.Items.Add(checkin);
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
    }
}
