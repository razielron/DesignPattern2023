namespace BasicFacebookFeatures
{
    public class BestFriend
    {
        private const double k_PointsPerLike = 2;
        private const double k_PointsPerComment = 2.5;

        public string UserId { get; set; }

        public string UserName { get; set; }

        public int LikesCounter { get; set; }

        public int CommentsCounter { get; set; }

        public double TotalPoints 
        {
            get
            {
                return (LikesCounter * k_PointsPerLike) + (CommentsCounter * k_PointsPerComment);
            }
        }
    }
}
