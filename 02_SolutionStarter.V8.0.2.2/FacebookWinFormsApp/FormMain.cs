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
                "user_friends",
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

        private void listBoxPostComments_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            BestFriendsFeature bestFriendsManager = new BestFriendsFeature();

            List<BestFriend> bestFriends = bestFriendsManager.FetchAndSortBestFriends(m_TheLoggedInUser);

            m_UiControler.DisplayBestFriends(bestFriends, listBoxBestFriend);
        }

        
       
        private void comboBoxPhotoSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSortingOption = comboBoxPhotoSortBy.SelectedItem.ToString().ToLower();

        }

        private void buttonFetchSortedPhotos_Click(object sender, EventArgs eM)
        {
            string selectedsortingoption = comboBoxPhotoSortBy.SelectedItem.ToString().ToLower();
            FacebookObjectCollection<Album> albums = m_TheLoggedInUser.Albums;
            PhotoManager photoManager = new PhotoManager(albums);

            if (selectedsortingoption == "countries")
            {
                List<string> countries = photoManager.GetUniqueCountries();
                DisplayCountriesList(countries);
            }
            else
            {
                List<Photo> sortedPhotos = GetSortedPhotos(selectedsortingoption, photoManager);
                DisplaySortedPhotos(sortedPhotos);
            }
        }

        private void DisplayCountriesList(List<string> countries)
        {
            listBoxCountries.DataSource = countries;
        }

        private List<Photo> GetSortedPhotos(string i_SortingOption, PhotoManager i_PhotoManager)
        {
            List<Photo> resSortedPhotos = new List<Photo>();

            switch (i_SortingOption)
            {
                case "most likes":
                    resSortedPhotos = SortByMostLikes();
                    break;
                case "most comments":
                    resSortedPhotos = SortByMostComments();
                    break;
                case "create date":
                    resSortedPhotos = SortByCreateDate();
                    break;
            }

            return resSortedPhotos;
        }

        public List<Photo> SortByMostLikes()
        {
            List<Photo> sortedPhotos = m_TheLoggedInUser.Albums.SelectMany(album => album.Photos)
                .OrderByDescending(photo => photo.LikedBy.Count)
                .ToList();

            return sortedPhotos;
        }

        public List<Photo> SortByMostComments()
        {
            List<Photo> sortedPhotos = m_TheLoggedInUser.Albums.SelectMany(album => album.Photos)
                .OrderByDescending(photo => photo.Comments.Count)
                .ToList();

            return sortedPhotos;
        }

        public List<Photo> SortByCreateDate()
        {
            List<Photo> sortedPhotos = m_TheLoggedInUser.Albums.SelectMany(album => album.Photos)
                .OrderBy(photo => photo.CreatedTime)
                .ToList();

            return sortedPhotos;
        }

        private void listBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacebookObjectCollection<Album> albums = m_TheLoggedInUser.Albums;
            PhotoManager photoManager = new PhotoManager(albums);
            string selectedCountry = listBoxCountries.SelectedItem.ToString();
            List<Photo> photosInCountry = photoManager.GetPhotosTakenInCountry(selectedCountry);
            DisplaySortedPhotos(photosInCountry);
        }

        private void DisplaySortedPhotos(List<Photo> photos)
        {
            listBoxSortedPhotos.DataSource = photos;
            listBoxSortedPhotos.DisplayMember = "PhotoName"; // Replace with the actual property name
        }

        private void listBoxBestFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            BestFriend selectedBestFriend = (BestFriend)listBoxBestFriends.SelectedItem;
            listBoxStatistics.Items.Clear();
            listBoxStatistics.Items.Add($"Likes: {selectedBestFriend.LikesCounter}");
            listBoxStatistics.Items.Add($"Comments: {selectedBestFriend.CommentsCounter}");
            listBoxStatistics.Items.Add($"Total Points: {selectedBestFriend.TotalPoints}");
        }
    }
}
