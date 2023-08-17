using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public interface ICategoryPhotoManager
    {
        List<string> Items { get; }

        List<Photo> GetPhotosByItem(string i_SelectedItem);
    }
}
