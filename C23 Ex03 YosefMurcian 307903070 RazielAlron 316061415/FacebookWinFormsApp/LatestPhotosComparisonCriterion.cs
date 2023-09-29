using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class LatestPhotosComparisonCriterion : IComparisonCriterionStrategy
    {
        public bool shouldLeftBeBefore(Photo item1, Photo item2)
        {
            return item1.CreatedTime >= item2.CreatedTime;
        }
    }
}
