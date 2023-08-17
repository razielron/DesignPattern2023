using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class CreatedDatePhotoManager : ICategoryPhotoManager
    {
        private List<Photo> m_AllPhotos;
        public List<string> Items { get; private set; }

        public CreatedDatePhotoManager(List<Photo> allPhotos)
        {
            m_AllPhotos = allPhotos;
            Items = new List<string>();
            updateItems();
        }

        public List<Photo> GetPhotosByItem(string i_SelectedItem)
        {
            List<Photo> photosByCreatedDate = new List<Photo>();

            foreach (Photo photo in m_AllPhotos)
            {
                string createdDate = photo.CreatedTime?.ToString();
                if (createdDate == i_SelectedItem)
                {
                    photosByCreatedDate.Add(photo);
                }
            }

            return photosByCreatedDate;
        }

        private void updateItems()
        {
            foreach (Photo photo in m_AllPhotos)
            {
                string createdDate = photo.CreatedTime?.ToString();
                if (!string.IsNullOrEmpty(createdDate) && !Items.Contains(createdDate))
                {
                    Items.Add(createdDate);
                }
            }
        }
    }
}
