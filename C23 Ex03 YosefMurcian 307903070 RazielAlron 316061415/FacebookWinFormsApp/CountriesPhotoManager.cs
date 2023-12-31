﻿using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

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

        public IEnumerable<Photo> GetPhotosByItem(string i_SelectedItem)
        {
            foreach (Photo photo in m_AllPhotos)
            {
                string photoCountry = photo.Place?.Location?.Country;

                if (photoCountry?.ToLower() == i_SelectedItem?.ToLower())
                {
                    yield return photo;
                }
            }
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
