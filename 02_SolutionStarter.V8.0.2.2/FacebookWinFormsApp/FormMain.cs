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
        LoginResult m_LoginResult;
        User m_TheLoggedInUser;
        UiControler m_UiControler;
        

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
            comboBoxCategories.Items.AddRange(new string[] {
                Consts.CategoryCountries,
                Consts.CategoryCreatedDate});
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
                "user_age_range",
                "user_birthday",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts"
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
            m_UiControler.DisplayImageInPictureBox(pictureBoxPhotos, photo?.PictureNormalURL);
        }
        
        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_UiControler.DisplayAlbumPhoto(listBoxAlbums, listBoxPictures);
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            m_UiControler.FetchAlbumsAndDisplayToListBox(listBoxAlbums);
        }
       
        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_UiControler.DisplayPostComments(listBoxPosts, listBoxPostComments);
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            m_UiControler.FetchPostsAndDisplayToListBox(listBoxPosts);
        }

        private void listBoxLikePages_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxDataModel<Page> selectedLikedPage = (ListBoxDataModel<Page>)listBoxLikePages.SelectedItem;
            m_UiControler.DisplayImageInPictureBox(pictureBoxLikedPages, selectedLikedPage?.Data?.PictureNormalURL);
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

        private void buttonFetchPhotosTaggedIn_Click(object sender, EventArgs e)
        {
            m_UiControler.FetchPhotosTaggedInAndDisplayToListBox(listBoxPhotosTaggedIn);
        }

        private void listBoxPhotosTaggedIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxDataModel<Photo> selectedPhotoTaggedIn = (ListBoxDataModel<Photo>)listBoxPhotosTaggedIn.SelectedItem;
            m_UiControler.DisplayImageInPictureBox(pictureBoxPhotosTaggedIn, selectedPhotoTaggedIn?.Data?.PictureThumbURL);
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

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxDataModel<Group> selectedGroups = (ListBoxDataModel<Group>)listBoxGroups.SelectedItem;
            m_UiControler.DisplayImageInPictureBox(pictureBoxGroups, selectedGroups?.Data?.IconUrl);
        }

        private void listBoxCheckIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxDataModel<Checkin> selectedCheckIn = (ListBoxDataModel<Checkin>)listBoxCheckIn.SelectedItem;
            m_UiControler.DisplayImageInPictureBox(pictureBoxCheckIn, selectedCheckIn?.Data?.PictureURL);
        }

        private void buttonFetchBestFriends_Click(object sender, EventArgs e)
        {
            m_UiControler.FetchBestFriendsAndDisplayToListBox(listBoxBestFriends);
        }
       
        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_UiControler.FetchPhotosPerCategoryAndDisplayToListBox(comboBoxCategories, listBoxItemsOfCategory);
        }

        private void buttonFetchSortedPhotos_Click(object sender, EventArgs eM)
        {
            m_UiControler.FetchPhotosPerCategoryAndDisplayToListBox(comboBoxCategories, listBoxItemsOfCategory);
        }

        private void listBoxItemsOfCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_UiControler.SelectItemOfCategoryAndDisplayToPhotoListBox(listBoxItemsOfCategory, listBoxSortedPhotos);
        }

        private void listBoxBestFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_UiControler.DisplayBestFriendStatistics(listBoxBestFriends);
        }

        private void listBoxSortedPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Photo selectedPhoto = (Photo)listBoxSortedPhotos.SelectedItem;
            m_UiControler.DisplayImageInPictureBox(pictureBoxCategoryPhoto, selectedPhoto?.PictureNormalURL);
        }
    }
}
