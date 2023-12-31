﻿using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class CategoryPhotoManagerFactory
    {
        public static ICategoryPhotoManager CreateCategoryPhotoManager(string i_Category, List<Photo> i_AllPhotos)
        {
            string countries = Consts.CategoryCountries.ToLower();
            string createdDate = Consts.CategoryCreatedDate.ToLower();
          
            if (i_Category.ToLower() == countries.ToLower())
            {
                return new CountriesPhotoManager(i_AllPhotos);
            }

            if (i_Category.ToLower() == createdDate.ToLower())
            {
                return new CreatedDatePhotoManager(i_AllPhotos);
            }

            return null;
        }
    }
}
