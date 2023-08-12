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
        FacebookWrapper.ObjectModel.User m_TheLoggedInUser;

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
            i_ListBoxPosts.Items.Clear();
            try
            {
                foreach (Post post in m_TheLoggedInUser.Posts)
                {
                    if (post.Message != null)
                    {
                        i_ListBoxPosts.Items.Add(post.Message);
                    }
                    else if (post.Caption != null)
                    {
                        i_ListBoxPosts.Items.Add(post.Caption);
                    }
                    else
                    {
                        i_ListBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (i_ListBoxPosts.Items.Count == 0)
                {
                    MessageBox.Show("No Posts to retrieve :(");
                }
            }
            
        }
        public void FetchLikePagesAndDisplayToListBox(ListBox i_ListBoxLikePages)
        {
            i_ListBoxLikePages.Items.Clear();
            i_ListBoxLikePages.DisplayMember = "Name";

            try
            {
                foreach (Page page in m_TheLoggedInUser.LikedPages)
                {
                    i_ListBoxLikePages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (i_ListBoxLikePages.Items.Count == 0)
                {
                    MessageBox.Show("No liked pages to retrieve :(");
                }
            }
            
        }
        public void FetchCheckInAndDisplayToListBox(ListBox i_ListBoxCheckIn)
        {
            i_ListBoxCheckIn.Items.Clear();
            i_ListBoxCheckIn.DisplayMember = "Name";
            try
            {
                foreach (Checkin checkin in m_TheLoggedInUser.Checkins)
                {
                    if (checkin.Place != null)
                    {
                        i_ListBoxCheckIn.Items.Add(checkin.Place);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (i_ListBoxCheckIn.Items.Count == 0)
                {
                    MessageBox.Show("No checkins to retrieve :(");
                }
            }

        }
        public void FetchAlbumsAndDisplayToListBox(ListBox i_ListBoxAlbums)
        {
            i_ListBoxAlbums.Items.Clear();
            i_ListBoxAlbums.DisplayMember = "Name";
            try
            {
                foreach (Album album in m_TheLoggedInUser.Albums)
                {
                    i_ListBoxAlbums.Items.Add(album);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (i_ListBoxAlbums.Items.Count == 0)
                {
                    MessageBox.Show("No Albums to retrieve :(");
                }
            }

        }
        public void FetchGroupsAndDisplayToListBox(ListBox i_ListBoxGroups)
        {
            i_ListBoxGroups.Items.Clear();
            i_ListBoxGroups.DisplayMember = "Name";
            try
            {
                foreach (Group group in m_TheLoggedInUser.Groups)
                {
                    i_ListBoxGroups.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (i_ListBoxGroups.Items.Count == 0)
                {
                    MessageBox.Show("No groups to retrieve :(");
                }
            }
            
        }
        public void FetchPhotosTaggedInAndDisplayToListBox(ListBox i_ListBoxPhotosTaggedIn)
        {
            i_ListBoxPhotosTaggedIn.Items.Clear();
            i_ListBoxPhotosTaggedIn.DisplayMember = "Name";

            try
            {
                foreach (Photo photo in m_TheLoggedInUser.PhotosTaggedIn)
                {
                    i_ListBoxPhotosTaggedIn.Items.Add(photo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (i_ListBoxPhotosTaggedIn.Items.Count == 0)
                {
                    MessageBox.Show("No photos tagged in to retrieve :(");
                }
            }

        }
    }
}
