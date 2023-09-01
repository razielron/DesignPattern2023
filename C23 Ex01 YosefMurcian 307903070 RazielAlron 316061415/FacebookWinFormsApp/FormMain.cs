using System;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.ComponentModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private LoginResult m_LoginResult;
        private User m_TheLoggedInUser;
        private UiControler m_UiControler;
        private AppSettings m_AppSettings;
        private Thread dataFetchThread;

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
            m_AppSettings = new AppSettings();
            this.StartPosition = FormStartPosition.Manual;
         
            comboBoxCategories.Items.AddRange(new string[] 
            {
                Consts.CategoryCountries,
                Consts.CategoryCreatedDate
            });
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            m_AppSettings = m_AppSettings.FromFileOrDefault();
            this.Size = m_AppSettings.LastWindowSize;
            this.WindowState = m_AppSettings.LastWindowState;
            this.Location = m_AppSettings.LastWindowPoint;
            this.checkBoxRememberUser.Checked = m_AppSettings.RememberUser;

            if (m_AppSettings.RememberUser && m_AppSettings.LastAccessToken != null)
            {
                new Thread(this.autoLogin).Start();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            m_AppSettings.LastWindowState = this.WindowState;
            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.LastWindowPoint = this.Location;
            m_AppSettings.RememberUser = this.checkBoxRememberUser.Checked;
            m_AppSettings.LastAccessToken = this.m_LoginResult?.AccessToken;
            m_AppSettings.SaveToFile();
        }


        private void autoLogin()
        {
            try
            {
                m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                updateLogginForm();
            }
            catch (Exception ex)
            {
                /// this is probably because of an AccessToken expiration:
                this.Invoke((Action)login);
            }
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
                );

            updateLogginForm();

        }
        private void updateLogginForm()
        {
            m_TheLoggedInUser = m_LoginResult.LoggedInUser;
            userBindingSource.DataSource = m_TheLoggedInUser;
            UiControler.Initialize(m_TheLoggedInUser);
            m_UiControler = UiControler.Instance;

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                buttonLogin.Invoke(new Action(() => buttonLogin.Text = $"Logged in as {m_TheLoggedInUser.Name}"));

                buttonLogin.Invoke(new Action(() => buttonLogin.BackColor = Color.LightGreen));
                pictureBoxProfile.Invoke(new Action(() => pictureBoxProfile.ImageLocation = m_TheLoggedInUser.PictureNormalURL));
                labelAbout.Invoke(new Action(() => m_UiControler.UpdateDetailsAboutUser(labelAbout)));
                buttonLogin.Invoke(new Action(() => buttonLogin.Enabled = false));
                buttonLogout.Invoke(new Action(() => buttonLogout.Enabled = true));
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

        private void buttonFetchPostsDataBinding_Click(object sender, EventArgs e)
        {
            postBindingSource.DataSource = m_TheLoggedInUser.Posts;
        }

        //private void listBoxPostDataBinding_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    //Post selectedPost = listBoxPostDataBinding.SelectedItem as Post;
        //    //postBindingSource.DataSource = selectedPost;
        //}

    }
}
