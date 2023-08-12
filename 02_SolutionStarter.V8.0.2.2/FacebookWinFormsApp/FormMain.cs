﻿using System;
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
        FacebookWrapper.LoginResult m_LoginResult;
        FacebookWrapper.ObjectModel.User m_TheLoggedInUser;
        UiControler m_UiControler;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25; 
        }

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
            m_UiControler = new UiControler(m_TheLoggedInUser);

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {m_TheLoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_TheLoggedInUser.PictureNormalURL;
                m_UiControler.UpdateDetailsAboutUser(labelAbout); 
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

        private void listBoxPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            Photo photo = (Photo)listBoxPictures.SelectedItem;
            pictureBoxPhotos.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhotos.ImageLocation = photo?.PictureNormalURL;
        }
        
        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxDataModel selectedAlbum = (ListBoxDataModel)listBoxAlbums.SelectedItem;

            try
            {
                Album album = m_TheLoggedInUser.Albums
                    .Where(x => x.Id == selectedAlbum?.Id)
                    .FirstOrDefault();
                listBoxPictures.DataSource = album?.Photos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            m_UiControler.FetchAlbumsAndDisplayToListBox(listBoxAlbums);
        } 
       
        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxDataModel selectedPost = (ListBoxDataModel)listBoxPosts.SelectedItem;

            try
            {
                Post post = m_TheLoggedInUser.Posts
                    .Where(x => x.Id == selectedPost.Id)
                    .FirstOrDefault();
                listBoxPostComments.DisplayMember = "Message";
                listBoxPostComments.DataSource = post.Comments;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            m_UiControler.FetchPostsAndDisplayToListBox(listBoxPosts);
        }

        private void listBoxPostComments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxLikePages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonFetchLikePages_Click(object sender, EventArgs e)
        {
            m_UiControler.FetchLikedPagesAndDisplayToListBox(listBoxLikePages);
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            m_UiControler.FetchGroupsAndDisplayToListBox(listBoxGroups);
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            m_UiControler.FetchCheckInAndDisplayToListBox(listBoxCheckIn);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void buttonFetchLikes_Click(object sender, EventArgs e)
        {

        }

        private void buttonFetchPhotosTaggedIn_Click(object sender, EventArgs e)
        {
            m_UiControler.FetchPhotosTaggedInAndDisplayToListBox(listBoxPhotosTaggedIn);
        }

        private void listBoxPhotosTaggedIn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGroupSearch_TextChanged(object sender, EventArgs e)
        {
            m_UiControler.DisplayGroupsToListBox(listBoxPosts, textBoxPostsSearch.Text);
        }

        private void textBoxPostsSearch_TextChanged(object sender, EventArgs e)
        {
            m_UiControler.DisplayPostsToListBox(listBoxPosts, textBoxPostsSearch.Text);
        }

        private void textBoxPhotosTaggenInSearch_TextChanged(object sender, EventArgs e)
        {
            m_UiControler.DisplayPhotosTaggedInToListBox(listBoxPhotosTaggedIn, textBoxPhotosTaggenInSearch.Text);
        }

        private void textBoxCheckInSearch_TextChanged(object sender, EventArgs e)
        {
            m_UiControler.DisplayCheckInToListBox(listBoxCheckIn, textBoxCheckInSearch.Text);
        }

        private void textBoxLikedPagesSearch_TextChanged(object sender, EventArgs e)
        {
            m_UiControler.DisplayLikedPagesToListBox(listBoxLikePages, textBoxLikedPagesSearch.Text);
        }
    }
}
