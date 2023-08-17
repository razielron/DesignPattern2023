using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class CountriesPhotoManager : ICategoryPhotoManager
    {
        private List<Photo> m_AllPhotos;
        public List<string> Items { get; private set; }

        public CountriesPhotoManager(List<Photo> i_AllPhotos)
        {
            m_AllPhotos = i_AllPhotos;
            Items = new List<string>();
            updateItems();
        }

        public List<Photo> GetPhotosByItem(string i_SelectedItem)
        {
            List<Photo> photosInCountry = new List<Photo>();

            foreach (Photo photo in m_AllPhotos)
            {
                string photoCountry = photo.Place?.Location?.Country;
                if (photoCountry?.ToLower() == i_SelectedItem?.ToLower())
                {
                    photosInCountry.Add(photo);
                }
            }

            return photosInCountry;
        }

        private void updateItems()
        {
            foreach (Photo photo in m_AllPhotos)
            {
                string country = photo.Place?.Location?.Country;
                if (!string.IsNullOrEmpty(country) && !Items.Contains(country))
                {
                    Items.Add(country);
                }
            }
        }
    }
}
