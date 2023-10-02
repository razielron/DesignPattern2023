using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class CommentsComparisonCriterion : IComparisonCriterionStrategy
    {
        public bool ShouldLeftBeBefore(Photo i_Item1, Photo i_Item2)
        {
            return i_Item1.Comments.Count <= i_Item2.Comments.Count;
        }
    }
}
