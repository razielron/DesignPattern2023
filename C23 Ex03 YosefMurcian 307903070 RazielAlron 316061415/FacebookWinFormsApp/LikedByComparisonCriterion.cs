using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class LikedByComparisonCriterion : IComparisonCriterionStrategy
    {
        public bool ShouldLeftBeBefore(Photo i_Item1, Photo i_Item2)
        {
            return i_Item1.LikedBy.Count >= i_Item2.LikedBy.Count;
        }

    }
}
