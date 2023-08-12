using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class UiControler
    {
        private User m_TheLoggedInUser;
        private ListBoxFilterManager m_PostsFilterManager;
        private ListBoxFilterManager m_LikedPagesFilterManager;
        private ListBoxFilterManager m_CheckInFilterManager;
        private ListBoxFilterManager m_AlbumsFilterManager;
        private ListBoxFilterManager m_GroupsFilterManager;
        private ListBoxFilterManager m_PhotosTaggedInFilterManager;

        public UiControler(FacebookWrapper.ObjectModel.User i_TheLoggedInUser)
        {
            m_TheLoggedInUser = i_TheLoggedInUser;
        }

        public void UpdateDetailsAboutUser(Label i_LabelAbout)
        {
            i_LabelAbout.Text = string.Format("{0} {1}{2}Email: {3}{4}Birth Date: {5}{6}Address: {7}",
                m_TheLoggedInUser.FirstName,
                m_TheLoggedInUser.LastName,
                Environment.NewLine,
                m_TheLoggedInUser.Email,
                Environment.NewLine,
                m_TheLoggedInUser.Birthday,
                Environment.NewLine,
                m_TheLoggedInUser.Location);
        }

        public void FetchPostsAndDisplayToListBox(ListBox i_ListBoxPosts)
        {
            FacebookObjectCollection<Post> allPosts = null;

            try
            {
                initiateListBox(i_ListBoxPosts);
                allPosts = m_TheLoggedInUser.Posts;
                m_PostsFilterManager = new ListBoxFilterManager(allPosts.Select(convertPostToListBoxDataModel));
                DisplayPostsToListBox(i_ListBoxPosts, i_Filter: string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                handleNoData(i_ListBoxPosts, allPosts);
            }
        }

        public void FetchLikedPagesAndDisplayToListBox(ListBox i_ListBoxLikePages)
        {
            FacebookObjectCollection<Page> allPages = null;

            try
            {
                initiateListBox(i_ListBoxLikePages);
                allPages = m_TheLoggedInUser.LikedPages;
                m_LikedPagesFilterManager = new ListBoxFilterManager(allPages.Select(convertLikedPagesToListBoxDataModel));
                DisplayLikedPagesToListBox(i_ListBoxLikePages, i_Filter: string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                handleNoData(i_ListBoxLikePages, allPages);
            }
        }

        public void FetchCheckInAndDisplayToListBox(ListBox i_ListBoxCheckIn)
        {
            FacebookObjectCollection<Checkin> allCheckin = null;

            try
            {
                initiateListBox(i_ListBoxCheckIn);
                allCheckin = m_TheLoggedInUser.Checkins;
                m_CheckInFilterManager = new ListBoxFilterManager(allCheckin.Select(convertCheckInToListBoxDataModel));
                DisplayCheckInToListBox(i_ListBoxCheckIn, i_Filter: string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                handleNoData(i_ListBoxCheckIn, allCheckin);
            }
        }

        public void FetchAlbumsAndDisplayToListBox(ListBox i_ListBoxAlbums)
        {
            FacebookObjectCollection<Album> allAlbums = null;

            try
            {
                initiateListBox(i_ListBoxAlbums);
                allAlbums = m_TheLoggedInUser.Albums;
                m_AlbumsFilterManager = new ListBoxFilterManager(allAlbums.Select(convertAlbumToListBoxDataModel));
                DisplayAlbumsToListBox(i_ListBoxAlbums, i_Filter: string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                handleNoData(i_ListBoxAlbums, allAlbums);
            }
        }

        public void FetchGroupsAndDisplayToListBox(ListBox i_ListBoxGroups)
        {
            FacebookObjectCollection<Group> allGroups = null;

            try
            {
                initiateListBox(i_ListBoxGroups);
                allGroups = m_TheLoggedInUser.Groups;
                m_GroupsFilterManager = new ListBoxFilterManager(allGroups.Select(convertGroupToListBoxDataModel));
                DisplayGroupsToListBox(i_ListBoxGroups, i_Filter: string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                handleNoData(i_ListBoxGroups, allGroups);
            }
        }

        public void FetchPhotosTaggedInAndDisplayToListBox(ListBox i_ListBoxPhotosTaggedIn)
        {
            FacebookObjectCollection<Photo> allPhotos = null;

            try
            {
                initiateListBox(i_ListBoxPhotosTaggedIn);
                allPhotos = m_TheLoggedInUser.PhotosTaggedIn;
                m_PhotosTaggedInFilterManager = new ListBoxFilterManager(allPhotos.Select(convertPhotoToListBoxDataModel));
                DisplayPhotosTaggedInToListBox(i_ListBoxPhotosTaggedIn, i_Filter: string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                handleNoData(i_ListBoxPhotosTaggedIn, allPhotos);
            }
        }

        public void DisplayPostsToListBox(ListBox i_ListBox, string i_Filter)
        {
            i_ListBox.DataSource = m_PostsFilterManager.FilterData(i_Filter);
        }

        public void DisplayLikedPagesToListBox(ListBox i_ListBox, string i_Filter)
        {
            i_ListBox.DataSource = m_LikedPagesFilterManager.FilterData(i_Filter);
        }

        public void DisplayCheckInToListBox(ListBox i_ListBox, string i_Filter)
        {
            i_ListBox.DataSource = m_CheckInFilterManager.FilterData(i_Filter);
        }

        public void DisplayAlbumsToListBox(ListBox i_ListBox, string i_Filter)
        {
            i_ListBox.DataSource = m_AlbumsFilterManager.FilterData(i_Filter);
        }

        public void DisplayGroupsToListBox(ListBox i_ListBox, string i_Filter)
        {
            i_ListBox.DataSource = m_GroupsFilterManager.FilterData(i_Filter);
        }

        public void DisplayPhotosTaggedInToListBox(ListBox i_ListBox, string i_Filter)
        {
            i_ListBox.DataSource = m_PhotosTaggedInFilterManager.FilterData(i_Filter);
        }

        private void initiateListBox(ListBox i_ListBox)
        {
            i_ListBox.DataSource = null;
            i_ListBox.DisplayMember = "DisplayName";
        }

        private void handleNoData<T>(ListBox i_ListBox, FacebookObjectCollection<T> i_FacebookObject)
        {
            if (i_FacebookObject == null || i_FacebookObject.Count == 0)
            {
                MessageBox.Show("No data to retrieve :(");
            }
        }

        private ListBoxDataModel convertPostToListBoxDataModel(Post i_Post)
        {
            string displayName = "";

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

            return new ListBoxDataModel
            {
                Id = i_Post.Id,
                DisplayName = displayName,
            };
        }

        private ListBoxDataModel convertLikedPagesToListBoxDataModel(Page i_Page)
        {
            return new ListBoxDataModel
            {
                Id = i_Page.Id,
                DisplayName = i_Page.Name,
            };
        }

        private ListBoxDataModel convertCheckInToListBoxDataModel(Checkin i_CheckIn)
        {
            string displayName = "";

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

            return new ListBoxDataModel
            {
                Id = i_CheckIn.Id,
                DisplayName = displayName,
            };
        }

        private ListBoxDataModel convertAlbumToListBoxDataModel(Album i_Album)
        {
            return new ListBoxDataModel
            {
                Id = i_Album.Id,
                DisplayName = i_Album.Name,
            };
        }

        private ListBoxDataModel convertGroupToListBoxDataModel(Group i_Group)
        {
            return new ListBoxDataModel
            {
                Id = i_Group.Id,
                DisplayName = i_Group.Name,
            };
        }

        private ListBoxDataModel convertPhotoToListBoxDataModel(Photo i_Photo)
        {
            return new ListBoxDataModel
            {
                Id = i_Photo.Id,
                DisplayName = i_Photo.Name,
            };
        }
    }
}
