using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class BestFriend
    {
        const double PointsPerLike = 2;
        const double PointsPerComment = 2.5;
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int LikesCounter { get; set; }
        public int CommentsCounter { get; set; }

        public double TotalPoints 
        {
            get
            {
                return (LikesCounter * PointsPerLike) + (CommentsCounter * PointsPerComment);
            }
        }

    }
}
