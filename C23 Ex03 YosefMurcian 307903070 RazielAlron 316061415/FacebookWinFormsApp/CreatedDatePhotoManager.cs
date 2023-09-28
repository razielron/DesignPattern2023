using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

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

        public IEnumerable<Photo> GetPhotosByItem(string i_SelectedItem)
        {
            foreach (Photo photo in m_AllPhotos)
            {
                string createdDate = photo.CreatedTime?.ToString();
                if (createdDate == i_SelectedItem)
                {
                    yield return photo;
                }
            }
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
