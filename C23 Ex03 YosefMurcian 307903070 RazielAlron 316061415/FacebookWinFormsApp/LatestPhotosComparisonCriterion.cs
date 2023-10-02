using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class LatestPhotosComparisonCriterion : IComparisonCriterionStrategy
    {
        public bool ShouldLeftBeBefore(Photo i_Item1, Photo i_Item2)
        {
            return i_Item1.CreatedTime >= i_Item2.CreatedTime;
        }
    }
}
