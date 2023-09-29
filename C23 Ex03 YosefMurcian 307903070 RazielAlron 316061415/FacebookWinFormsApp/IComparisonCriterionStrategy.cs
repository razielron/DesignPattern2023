using FacebookWrapper.ObjectModel;
using ProxyComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IComparisonCriterionStrategy
    {
        bool shouldLeftBeBefore(Photo item1, Photo item2);
    }
}
