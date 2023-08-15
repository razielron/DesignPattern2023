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
        private ListBoxFilterManager<Post> m_PostsFilterManager;
        private ListBoxFilterManager<Page> m_LikedPagesFilterManager;
        private ListBoxFilterManager<Checkin> m_CheckInFilterManager;
        private ListBoxFilterManager<Album> m_AlbumsFilterManager;
        private ListBoxFilterManager<Group> m_GroupsFilterManager;
        private ListBoxFilterManager<Photo> m_PhotosTaggedInFilterManager;

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
                m_PostsFilterManager = new ListBoxFilterManager<Post>(allPosts.Select(convertPostToListBoxDataModel));
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
                m_LikedPagesFilterManager = new ListBoxFilterManager<Page>(allPages.Select(convertLikedPagesToListBoxDataModel));
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
                m_CheckInFilterManager = new ListBoxFilterManager<Checkin>(allCheckin.Select(convertCheckInToListBoxDataModel));
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
                m_AlbumsFilterManager = new ListBoxFilterManager<Album>(allAlbums.Select(convertAlbumToListBoxDataModel));
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
                m_GroupsFilterManager = new ListBoxFilterManager<Group>(allGroups.Select(convertGroupToListBoxDataModel));
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
                m_PhotosTaggedInFilterManager = new ListBoxFilterManager<Photo>(allPhotos.Select(convertPhotoToListBoxDataModel));
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

        public void DisplayImageInPictureBox(PictureBox i_PictureBox, string i_PictureURL)
        {
            i_PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            i_PictureBox.ImageLocation = i_PictureURL;
        }

        public void DisplayPostComments(ListBox i_SourceListBox, ListBox i_DestListBox)
        {
            ListBoxDataModel<Post> selectedPost = (ListBoxDataModel<Post>)i_SourceListBox.SelectedItem;

            try
            {
                Post post = selectedPost.Data;
                i_DestListBox.DisplayMember = "Message";
                i_DestListBox.DataSource = post.Comments;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplayAlbumPhoto(ListBox i_SourceListBox, ListBox i_DestListBox)
        {
            ListBoxDataModel<Album> selectedAlbum = (ListBoxDataModel<Album>)i_SourceListBox.SelectedItem;

            try
            {
                Album album = selectedAlbum.Data;
                i_DestListBox.DataSource = album.Photos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplayBestFriends(List<BestFriend> i_BestFriends, ListBox i_ListBox)
        {
            try
            {
                i_ListBox.DataSource = i_BestFriends;
                i_ListBox.DisplayMember = "DisplayName"; 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private ListBoxDataModel<Post> convertPostToListBoxDataModel(Post i_Post)
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
