using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class PhotoManager
    {

        private FacebookObjectCollection<Album> m_AllPhotos;
        List<string> countries = new List<string>();
        public PhotoManager(FacebookObjectCollection<Album> i_AllPhotos)
        {
            m_AllPhotos = i_AllPhotos;
        }

        public List<string> GetUniqueCountries()
        {
            foreach (Album album in m_AllPhotos)
            {
                foreach (Photo photo in album.Photos)
                {
                    string country = photo.Place?.Location?.Country;
                    if (!string.IsNullOrEmpty(country) && !countries.Contains(country))
                    {
                        countries.Add(country);
                    }

                }

            }


            return countries;
        }

        public List<Photo> GetPhotosTakenInCountry(string countryName)
        {
            List<Photo> photosInCountry = new List<Photo>();

            foreach (Album album in m_AllPhotos)
            {
                foreach (Photo photo in album.Photos)
                {
                    string photoCountry = photo.Place?.Location?.Country;
                    if (string.Equals(photoCountry, countryName, StringComparison.OrdinalIgnoreCase))
                    {
                        photosInCountry.Add(photo);
                    }
                }
            }

            return photosInCountry;
        }
    }
}
