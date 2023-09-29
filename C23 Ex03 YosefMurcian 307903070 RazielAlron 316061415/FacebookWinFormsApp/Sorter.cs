using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class Sorter
    {
        public IComparisonCriterionStrategy ComparisonStrategy { get; set; }

        public Sorter()
        {
            ComparisonStrategy = new LikedByComparisonCriterion();
        }

        public void Sort(List<Photo> i_Collections)
        {
            mergeSortAlgorithm(i_Collections, 0, i_Collections.Count - 1);
        }

        private void mergeSortAlgorithm(List<Photo> i_Collections, int i_Left, int i_Right)
        {
            if (i_Left < i_Right)
            {
                int middle = (i_Left + i_Right) / 2;
                mergeSortAlgorithm(i_Collections, i_Left, middle);
                mergeSortAlgorithm(i_Collections, middle + 1, i_Right);
                merge(i_Collections, i_Left, middle, i_Right);
            }
        }

        private void merge(List<Photo> i_Collections, int i_Left, int middle, int i_Right)
        {
            int firstIndex = middle - i_Left + 1;
            int lastIndex = i_Right - middle;

            List<Photo> leftCollections = i_Collections.GetRange(i_Left, firstIndex);
            List<Photo> rightCollections = i_Collections.GetRange(middle + 1, lastIndex);

            int x = 0, y = 0;
            int k = i_Left;

            while (x < firstIndex && y < lastIndex)
            {
                if (ComparisonStrategy.shouldLeftBeBefore(leftCollections[x], rightCollections[y]))
                {
                    i_Collections[k] = leftCollections[x];
                    x++;
                }
                else
                {
                    i_Collections[k] = rightCollections[y];
                    y++;
                }
                k++;
            }

            while (x < firstIndex)
            {
                i_Collections[k] = leftCollections[x];
                x++;
                k++;
            }

            while (y < lastIndex)
            {
                i_Collections[k] = rightCollections[y];
                y++;
                k++;
            }
        }
    }
}
