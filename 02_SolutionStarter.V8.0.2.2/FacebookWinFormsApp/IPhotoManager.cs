﻿using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public interface ICategoryPhotoManager
    {
        List<string> Items { get; }

        List<Photo> GetPhotosByItem(string i_SelectedItem);
    }
}
