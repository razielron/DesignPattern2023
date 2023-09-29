using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using ProxyComponents;

namespace BasicFacebookFeatures
{
    public sealed class UiControler
    {
        private static readonly object sr_Lock = new object();
        private static User s_TheLoggedInUserInitValue;
        private static User s_TheLoggedInUser;
        private static UiControler s_Instance = null;
        private Sorter m_PhotoSorter;
        private ListBoxFilterManager<Post> m_PostsFilterManager;
        private ListBoxFilterManager<Page> m_LikedPagesFilterManager;
        private ListBoxFilterManager<Checkin> m_CheckInFilterManager;
        private ListBoxFilterManager<Album> m_AlbumsFilterManager;
        private ListBoxFilterManager<Group> m_GroupsFilterManager;
        private ListBoxFilterManager<Photo> m_PhotosTaggedInFilterManager;
        private ICategoryPhotoManager m_CategoryPhotoManager;
        private BestFriendsManager m_BestFriendsManager;

        public static UiControler Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_Lock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new UiControler(s_TheLoggedInUserInitValue);
                        }
                    }
                }

                return s_Instance;
            }
        }

        private UiControler(User i_TheLoggedInUser)
        {
            s_TheLoggedInUser = i_TheLoggedInUser;
            m_PhotoSorter = new Sorter();
        }

        public static void Initialize(User i_TheLoggedInUser)
        {
            if(s_Instance != null)
            {
                throw new InvalidOperationException("UI controler was already created");
            }

            s_TheLoggedInUserInitValue = i_TheLoggedInUser;
        }
        
        public void UpdateDetailsAboutUser(Label i_LabelAbout)
        {
            i_LabelAbout.Text = string.Format(
                "{0} {1}{2}Email: {3}{4}Birth Date: {5}{6}Address: {7}",
                s_TheLoggedInUser.FirstName,
                s_TheLoggedInUser.LastName,
                Environment.NewLine,
                s_TheLoggedInUser.Email,
                Environment.NewLine,
                s_TheLoggedInUser.Birthday,
                Environment.NewLine,
                s_TheLoggedInUser.Location);
        }

        public void FetchPostsAndDisplayToListBox(ListBoxProxy i_ListBoxPosts)
        {
            FacebookObjectCollection<Post> allPosts = null;

            try
            {
                initiateListBox(i_ListBoxPosts);
                allPosts = s_TheLoggedInUser.Posts;
                m_PostsFilterManager = new ListBoxFilterManager<Post>(allPosts
                    .Select(convertPostToListBoxDataModel)
                    .ToList());
                DisplayPostsToListBox(i_ListBoxPosts, i_Filter: string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                handleNoData(allPosts);
            }
        }

        public void FetchLikedPagesAndDisplayToListBox(ListBoxProxy i_ListBoxLikePages)
        {
            FacebookObjectCollection<Page> allPages = null;

            try
            {
                initiateListBox(i_ListBoxLikePages);
                allPages = s_TheLoggedInUser.LikedPages;
                m_LikedPagesFilterManager = new ListBoxFilterManager<Page>(allPages
                    .Select(convertLikedPagesToListBoxDataModel)
                    .ToList());
                DisplayLikedPagesToListBox(i_ListBoxLikePages, i_Filter: string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                handleNoData(allPages);
            }
        }

        public void FetchCheckInAndDisplayToListBox(ListBoxProxy i_ListBoxCheckIn)
        {
            FacebookObjectCollection<Checkin> allCheckin = null;

            try
            {
                initiateListBox(i_ListBoxCheckIn);
                allCheckin = s_TheLoggedInUser.Checkins;
                m_CheckInFilterManager = new ListBoxFilterManager<Checkin>(allCheckin
                    .Select(convertCheckInToListBoxDataModel)
                    .ToList());
                DisplayCheckInToListBox(i_ListBoxCheckIn, i_Filter: string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                handleNoData(allCheckin);
            }
        }

        public void FetchAlbumsAndDisplayToListBox(ListBoxProxy i_ListBoxAlbums)
        {
            FacebookObjectCollection<Album> allAlbums = null;

            try
            {
                initiateListBox(i_ListBoxAlbums);
                allAlbums = s_TheLoggedInUser.Albums;
                m_AlbumsFilterManager = new ListBoxFilterManager<Album>(allAlbums
                    .Select(convertAlbumToListBoxDataModel)
                    .ToList());
                DisplayAlbumsToListBox(i_ListBoxAlbums, i_Filter: string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                handleNoData(allAlbums);
            }
        }

        public void FetchGroupsAndDisplayToListBox(ListBoxProxy i_ListBoxGroups)
        {
            FacebookObjectCollection<Group> allGroups = null;

            try
            {
                initiateListBox(i_ListBoxGroups);
                allGroups = s_TheLoggedInUser.Groups;
                m_GroupsFilterManager = new ListBoxFilterManager<Group>(allGroups
                    .Select(convertGroupToListBoxDataModel)
                    .ToList());
                DisplayGroupsToListBox(i_ListBoxGroups, i_Filter: string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                handleNoData(allGroups);
            }
        }

        public void FetchPhotosTaggedInAndDisplayToListBox(ListBoxProxy i_ListBoxPhotosTaggedIn)
        {
            FacebookObjectCollection<Photo> allPhotos = null;

            try
            {
                initiateListBox(i_ListBoxPhotosTaggedIn);
                allPhotos = s_TheLoggedInUser.PhotosTaggedIn;
                m_PhotosTaggedInFilterManager = new ListBoxFilterManager<Photo>(allPhotos
                    .Select(convertPhotoToListBoxDataModel)
                    .ToList());
                DisplayPhotosTaggedInToListBox(i_ListBoxPhotosTaggedIn, i_Filter: string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                handleNoData(allPhotos);
            }
        }

        public void FetchPhotosPerCategoryAndDisplayToListBox(ComboBox i_ComboBox, ListBox i_ListBox)
        {
            FacebookObjectCollection<Album> albums = null;

            try
            {
                List<Photo> allPhotos;
                string selectedCategory = i_ComboBox.SelectedItem.ToString().ToLower();
                
                albums = s_TheLoggedInUser.Albums;
                allPhotos = albums.SelectMany(x => x.Photos).ToList();
                m_CategoryPhotoManager = CategoryPhotoManagerFactory.CreateCategoryPhotoManager(selectedCategory, allPhotos);
                DisplayItemsToCategoryListBox(i_ListBox);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                handleNoData(albums);
            }
        }

        public void FetchBestFriendsAndDisplayToListBox(ListBox i_ListBox)
        {
            FacebookObjectCollection<Post> postsResponse = null;

            try
            {
                postsResponse = s_TheLoggedInUser.Posts;
                m_BestFriendsManager = new BestFriendsManager(postsResponse.ToList());
                DisplayBestFriendsToListBox(i_ListBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                handleNoData(postsResponse);
            }
        }

        public void FetchSortedPhotosAndDisplayToListBox(ComboBox comboBoxSortBy, ListBoxProxy i_SelectedAlbum, ListBox i_ListBoxPictures)
        {
            string selectedCriterion = comboBoxSortBy.SelectedItem.ToString();
            ListBoxDataModel<Album> selectedAlbum = (ListBoxDataModel<Album>)i_SelectedAlbum.SelectedItem;

            switch (selectedCriterion)
            {
                case Consts.SortByLikes:
                    m_PhotoSorter.ComparisonStrategy = new LikedByComparisonCriterion();
                    break;
                case Consts.SortByComments:
                    m_PhotoSorter.ComparisonStrategy = new CommentsComparisonCriterion();
                    break;
                case Consts.SortByLatestPhotos:
                    m_PhotoSorter.ComparisonStrategy = new LatestPhotosComparisonCriterion();
                    break;
                case Consts.SortByEarliestPhotos:
                    m_PhotoSorter.ComparisonStrategy = new EarliestPhotosComparisonCriterion();
                    break;
            }

            DisplayAlbumPhotos(selectedAlbum, i_ListBoxPictures, m_PhotoSorter);
        }

        public void DisplayAlbumPhotos(ListBoxDataModel<Album> selectedAlbum, ListBox photosListBox, Sorter strategy)
        {
            if (selectedAlbum != null)
            {
                Album album = selectedAlbum.Data;
                List<Photo> sortedPhotos = album.Photos.ToList();

                strategy.Sort(sortedPhotos);

                photosListBox.DataSource = sortedPhotos;
            }
        }

        public void SelectItemOfCategoryAndDisplayToPhotoListBox(ListBox i_SelectListBox, ListBox i_DisplayListBox)
        {
            string selectedItem = i_SelectListBox.SelectedItem.ToString().ToLower();
            i_DisplayListBox.DataSource = m_CategoryPhotoManager.GetPhotosByItem(selectedItem);
        }

        public void DisplayItemsToCategoryListBox(ListBox i_ListBox)
        {
            i_ListBox.DataSource = m_CategoryPhotoManager.Items;
        }

        public void DisplayPostsToListBox(ListBoxProxy i_ListBox, string i_Filter)
        {
            i_ListBox.DataSource = m_PostsFilterManager.FilterData(i_Filter);
        }

        public void DisplayLikedPagesToListBox(ListBoxProxy i_ListBox, string i_Filter)
        {
            i_ListBox.DataSource = m_LikedPagesFilterManager.FilterData(i_Filter);
        }

        public void DisplayCheckInToListBox(ListBoxProxy i_ListBox, string i_Filter)
        {
            i_ListBox.DataSource = m_CheckInFilterManager.FilterData(i_Filter);
        }

        public void DisplayAlbumsToListBox(ListBoxProxy i_ListBox, string i_Filter)
        {
            i_ListBox.DataSource = m_AlbumsFilterManager.FilterData(i_Filter);
        }

        public void DisplayGroupsToListBox(ListBoxProxy i_ListBox, string i_Filter)
        {
            i_ListBox.DataSource = m_GroupsFilterManager.FilterData(i_Filter);
        }

        public void DisplayPhotosTaggedInToListBox(ListBoxProxy i_ListBox, string i_Filter)
        {
            i_ListBox.DataSource = m_PhotosTaggedInFilterManager.FilterData(i_Filter);
        }

        public void DisplayImageInPictureBox(PictureBox i_PictureBox, string i_PictureURL)
        {
            i_PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            i_PictureBox.ImageLocation = i_PictureURL;
        }

        public void DisplayPostComments(ListBox i_SourceListBox, ListBox i_DestListBox)
        {
            try
            {
                ListBoxDataModel<Post> selectedPost = (ListBoxDataModel<Post>)i_SourceListBox.SelectedItem;

                if (selectedPost != null)
                {
                    Post post = selectedPost.Data;
                    i_DestListBox.DisplayMember = "Message";
                    i_DestListBox.DataSource = post.Comments;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplayAlbumPhoto(ListBox i_SourceListBox, ListBox i_DestListBox)
        {
            try
            {
                ListBoxDataModel<Album> selectedAlbum = (ListBoxDataModel<Album>)i_SourceListBox.SelectedItem;

                if (selectedAlbum != null)
                {
                    Album album = selectedAlbum.Data;
                    i_DestListBox.DataSource = album.Photos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplayBestFriendStatistics(ListBox i_ListBox)
        {
            BestFriend selectedBestFriend = (BestFriend)i_ListBox.SelectedItem;

            if (selectedBestFriend != null)
            {
                i_ListBox.DataSource = m_BestFriendsManager.GetLikeAndCommentsStatistics(selectedBestFriend);
            }
        }

        private void DisplayBestFriendsToListBox(ListBox i_ListBox)
        {
            i_ListBox.DataSource = m_BestFriendsManager.BestFriends;
        }

        private void initiateListBox(ListBoxProxy i_ListBox)
        {
            i_ListBox.DataSource = null;
            i_ListBox.DisplayMember = "DisplayName";
        }

        private void handleNoData<T>(FacebookObjectCollection<T> i_FacebookObject)
        {
            if (i_FacebookObject == null || i_FacebookObject.Count == 0)
            {
                MessageBox.Show("No data to retrieve :(");
            }
        }

        private ListBoxDataModel<Post> convertPostToListBoxDataModel(Post i_Post)
        {
            string displayName = string.Empty;

            if (i_Post.Message != null)
            {
                displayName = i_Post.Message;
            }
            else if (i_Post.Caption != null)
            {
                displayName = i_Post.Caption;
            }
            else
            {
                displayName = string.Format("[{0}]", i_Post.Type);
            }

            return new ListBoxDataModel<Post>
            {
                Id = i_Post.Id,
                DisplayName = displayName,
                Data = i_Post,
            };
        }

        private ListBoxDataModel<Page> convertLikedPagesToListBoxDataModel(Page i_Page)
        {
            return new ListBoxDataModel<Page>
            {
                Id = i_Page.Id,
                DisplayName = i_Page.Name,
                Data = i_Page,
            };
        }

        private ListBoxDataModel<Checkin> convertCheckInToListBoxDataModel(Checkin i_CheckIn)
        {
            string displayName = string.Empty;

            if (i_CheckIn?.Place?.Name != null)
            {
                displayName = i_CheckIn.Place.Name;
            }
            else if(i_CheckIn.Name != null)
            {
                displayName = i_CheckIn.Name;
            }
            else if(i_CheckIn.Message != null)
            {
                displayName = i_CheckIn.Message;
            }
            else
            {
                displayName = string.Format("[{0}]", i_CheckIn.Type);
            }

            return new ListBoxDataModel<Checkin>
            {
                Id = i_CheckIn.Id,
                DisplayName = displayName,
                Data = i_CheckIn,
            };
        }

        private ListBoxDataModel<Album> convertAlbumToListBoxDataModel(Album i_Album)
        {
            return new ListBoxDataModel<Album>
            {
                Id = i_Album.Id,
                DisplayName = i_Album.Name,
                Data = i_Album,
            };
        }

        private ListBoxDataModel<Group> convertGroupToListBoxDataModel(Group i_Group)
        {
            return new ListBoxDataModel<Group>
            {
                Id = i_Group.Id,
                DisplayName = i_Group.Name,
                Data = i_Group,
            };
        }

        private ListBoxDataModel<Photo> convertPhotoToListBoxDataModel(Photo i_Photo)
        {
            return new ListBoxDataModel<Photo>
            {
                Id = i_Photo.Id,
                DisplayName = i_Photo.Name,
                Data = i_Photo,
            };
        }
    }
}
