using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public interface IComparisonCriterionStrategy
    {
        bool ShouldLeftBeBefore(Photo i_Item1, Photo i_Item2);
    }
}
