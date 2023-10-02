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
        private UiControler m_UiController;
        private AppSettings m_AppSettings;
        private AutomaticUpdater m_AutomaticUpdater;

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
            m_AppSettings = new AppSettings();
            m_AutomaticUpdater = new AutomaticUpdater();
            this.StartPosition = FormStartPosition.Manual;
            disableButtonsOnLogout();
            addAutoUpdateActions();

            comboBoxCategories.Items.AddRange(new string[] 
            {
                Consts.CategoryCountries,
                Consts.CategoryCreatedDate
            });

            comboBoxSortBy.Items.AddRange(new string[]
            {
                Consts.SortByLikes,
                Consts.SortByComments,
                Consts.SortByLatestPhotos,
                Consts.SortByEarliestPhotos
            });

            comboBoxAutoUpdate.Items.AddRange(new ComboBoxDataModel[]
            {
                new ComboBoxDataModel { Text = Consts.TurnOffText, Value = 0 },
                new ComboBoxDataModel { Text = Consts.OneMinuteText, Value = Consts.OneMinute },
                new ComboBoxDataModel { Text = Consts.FiveMinutesText, Value = Consts.FiveMinutes},
                new ComboBoxDataModel { Text = Consts.TenMinutesText, Value = Consts.TenMinutes },
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

        private void addAutoUpdateActions()
        {
            m_AutomaticUpdater.m_EntityUpdateAction += () => m_UiController.FetchAlbumsAndDisplayToListBox(listBoxAlbums);
            m_AutomaticUpdater.m_EntityUpdateAction += () => m_UiController.FetchPhotosTaggedInAndDisplayToListBox(listBoxPhotosTaggedIn);
            m_AutomaticUpdater.m_EntityUpdateAction += () => m_UiController.FetchLikedPagesAndDisplayToListBox(listBoxLikePages);
            m_AutomaticUpdater.m_EntityUpdateAction += () => m_UiController.FetchCheckInAndDisplayToListBox(listBoxCheckIn);
            m_AutomaticUpdater.m_EntityUpdateAction += () => m_UiController.FetchPostsAndDisplayToListBox(listBoxPosts);
        }
        
        private void disableButtonsOnLogout()
        {
            buttonFetchAlbums.Enabled = false;
            buttonFetchBestFriends.Enabled = false;
            buttonCheckIn.Enabled = false;
            buttonFetchGroups.Enabled = false;
            buttonFetchLikes.Enabled = false;
            buttonFetchPosts.Enabled = false;
            buttonLikePages.Enabled = false;
        }

        private void enableButtonsOnLogin()
        {
            buttonFetchAlbums.Enabled = true;
            buttonFetchBestFriends.Enabled = true;
            buttonCheckIn.Enabled = true;
            buttonFetchGroups.Enabled = true;
            buttonFetchLikes.Enabled = true;
            buttonFetchPosts.Enabled = true;
            buttonLikePages.Enabled = true;
        }

        private void autoLogin()
        {
            try
            {
                m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                updateLogginForm();
                fetchAllData();
            }
            catch (Exception ex)
            {
                if (m_LoginResult == null)
                {
                    /// this is probably because of an AccessToken expiration:
                    this.Invoke((Action)login);
                }
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
            fetchAllData();
        }

        private void fetchAllData()
        {
            new Thread(() => m_UiController.FetchAlbumsAndDisplayToListBox(listBoxAlbums)).Start();
            new Thread(() => m_UiController.FetchPhotosTaggedInAndDisplayToListBox(listBoxPhotosTaggedIn)).Start();
            new Thread(() => m_UiController.FetchLikedPagesAndDisplayToListBox(listBoxLikePages)).Start();
            new Thread(() => m_UiController.FetchCheckInAndDisplayToListBox(listBoxCheckIn)).Start();
            new Thread(() => m_UiController.FetchPostsAndDisplayToListBox(listBoxPosts)).Start();
        }

        private void updateLogginForm()
        {
            m_TheLoggedInUser = m_LoginResult.LoggedInUser;
            userBindingSource.DataSource = m_TheLoggedInUser;
            UiControler.Initialize(m_TheLoggedInUser);
            m_UiController = UiControler.Instance;

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {m_TheLoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_TheLoggedInUser.PictureNormalURL;
                labelAbout.Invoke(new Action(() => m_UiController.UpdateDetailsAboutUser(labelAbout)));
                enableButtonsOnLogin();
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
            m_UiController.DisplayImageInPictureBox(pictureBoxPhotos, photo?.PictureNormalURL);
        }
        
        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_UiController.DisplayAlbumPhoto(listBoxAlbums, listBoxPictures);
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            m_UiController.FetchAlbumsAndDisplayToListBox(listBoxAlbums);
        }
       
        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_UiController.DisplayPostComments(listBoxPosts, listBoxPostComments);
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            m_UiController.FetchPostsAndDisplayToListBox(listBoxPosts);
        }

        private void listBoxLikePages_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxDataModel<Page> selectedLikedPage = (ListBoxDataModel<Page>)listBoxLikePages.SelectedItem;
            m_UiController.DisplayImageInPictureBox(pictureBoxLikedPages, selectedLikedPage?.Data?.PictureNormalURL);
        }

        private void buttonFetchLikePages_Click(object sender, EventArgs e)
        {
            m_UiController.FetchLikedPagesAndDisplayToListBox(listBoxLikePages);
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            m_UiController.FetchGroupsAndDisplayToListBox(listBoxGroups);
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            m_UiController.FetchCheckInAndDisplayToListBox(listBoxCheckIn);
        }

        private void buttonFetchPhotosTaggedIn_Click(object sender, EventArgs e)
        {
            m_UiController.FetchPhotosTaggedInAndDisplayToListBox(listBoxPhotosTaggedIn);
        }

        private void listBoxPhotosTaggedIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxDataModel<Photo> selectedPhotoTaggedIn = (ListBoxDataModel<Photo>)listBoxPhotosTaggedIn.SelectedItem;
            m_UiController.DisplayImageInPictureBox(pictureBoxPhotosTaggedIn, selectedPhotoTaggedIn?.Data?.PictureThumbURL);
        }

        private void textBoxGroupSearch_TextChanged(object sender, EventArgs e)
        {
            m_UiController.DisplayGroupsToListBox(listBoxPosts, textBoxPostsSearch.Text);
        }

        private void textBoxPostsSearch_TextChanged(object sender, EventArgs e)
        {
            m_UiController.DisplayPostsToListBox(listBoxPosts, textBoxPostsSearch.Text);
        }

        private void textBoxPhotosTaggenInSearch_TextChanged(object sender, EventArgs e)
        {
            m_UiController.DisplayPhotosTaggedInToListBox(listBoxPhotosTaggedIn, textBoxPhotosTaggenInSearch.Text);
        }

        private void textBoxCheckInSearch_TextChanged(object sender, EventArgs e)
        {
            m_UiController.DisplayCheckInToListBox(listBoxCheckIn, textBoxCheckInSearch.Text);
        }

        private void textBoxLikedPagesSearch_TextChanged(object sender, EventArgs e)
        {
            m_UiController.DisplayLikedPagesToListBox(listBoxLikePages, textBoxLikedPagesSearch.Text);
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxDataModel<Group> selectedGroups = (ListBoxDataModel<Group>)listBoxGroups.SelectedItem;
            m_UiController.DisplayImageInPictureBox(pictureBoxGroups, selectedGroups?.Data?.IconUrl);
        }

        private void listBoxCheckIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxDataModel<Checkin> selectedCheckIn = (ListBoxDataModel<Checkin>)listBoxCheckIn.SelectedItem;
            m_UiController.DisplayImageInPictureBox(pictureBoxCheckIn, selectedCheckIn?.Data?.PictureURL);
        }

        private void buttonFetchBestFriends_Click(object sender, EventArgs e)
        {
            m_UiController.FetchBestFriendsAndDisplayToListBox(listBoxBestFriends);
        }
       
        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_UiController.FetchPhotosPerCategoryAndDisplayToListBox(comboBoxCategories, listBoxItemsOfCategory);
        }

        private void listBoxItemsOfCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_UiController.SelectItemOfCategoryAndDisplayToPhotoListBox(listBoxItemsOfCategory, listBoxSortedPhotos);
        }

        private void listBoxBestFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_UiController.DisplayBestFriendStatistics(listBoxBestFriends);
        }

        private void listBoxSortedPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Photo selectedPhoto = (Photo)listBoxSortedPhotos.SelectedItem;
            m_UiController.DisplayImageInPictureBox(pictureBoxCategoryPhoto, selectedPhoto?.PictureNormalURL);
        }

        private void buttonFetchPostsDataBinding_Click(object sender, EventArgs e)
        {
            postBindingSource.DataSource = m_TheLoggedInUser.Posts;
        }

        private void comboBoxAutoUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxDataModel selectedItem = comboBoxAutoUpdate.SelectedItem as ComboBoxDataModel;

            if (selectedItem.Text == Consts.TurnOffText)
            {
                m_AutomaticUpdater.StopTimer();
            }
            else
            {
                m_AutomaticUpdater.StartTimer(selectedItem.Value);
            }
        }

        private void comboBoxcomboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_UiController.FetchSortedPhotosAndDisplayToListBox(comboBoxSortBy, listBoxAlbums, listBoxPictures);
        }
    }
}
