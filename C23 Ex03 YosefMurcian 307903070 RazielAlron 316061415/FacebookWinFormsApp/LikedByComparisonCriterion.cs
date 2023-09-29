using FacebookWrapper.ObjectModel;
using ProxyComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class LikedByComparisonCriterion : IComparisonCriterionStrategy
    {
        public bool shouldLeftBeBefore(Photo item1 , Photo item2)
        {
            return item1.LikedBy.Count >= item2.LikedBy.Count;
        }

    }
}
