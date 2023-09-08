using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class BestFriendsManager
    {
        private List<Post> m_Posts;

        public List<BestFriend> BestFriends { get; }

        public BestFriendsManager(List<Post> i_Posts)
        {
            m_Posts = i_Posts;
            BestFriends = new List<BestFriend>();
            updateBestFriends();
        }

        public List<string> GetLikeAndCommentsStatistics(BestFriend i_BestFriend)
        {
            List<string> statistics = new List<string>();

            statistics.Add($"Likes: {i_BestFriend.LikesCounter}");
            statistics.Add($"Comments: {i_BestFriend.CommentsCounter}");
            statistics.Add($"Total Points: {i_BestFriend.TotalPoints}");

            return statistics;
        }

        private void updateBestFriends()
        {
            foreach (Post post in m_Posts)
            {
                countLikesPerFriend(post);
                countCommentsPerFriend(post);
            }

            BestFriends.Sort((f1, f2) => f2.TotalPoints.CompareTo(f1.TotalPoints));
        }

        private void countLikesPerFriend(Post i_Post)
        {
            foreach (User liker in i_Post.LikedBy)
            {
                BestFriend bestFriend = addOrGetBestFriend(liker);
   
                bestFriend.LikesCounter += 1; 
            }
        }

        private void countCommentsPerFriend(Post i_Post)
        {
            foreach (Comment comment in i_Post.Comments)
            {
                User commenter = comment.From;
                BestFriend bestFriend = addOrGetBestFriend(commenter);
                
                bestFriend.CommentsCounter += 1; 
            }
        }

        private BestFriend addOrGetBestFriend(User i_User)
        {
            BestFriend bestFriend = BestFriends.FirstOrDefault(f => f.UserId == i_User.Id);

            if (bestFriend == null)
            {
                bestFriend = new BestFriend
                {
                    UserId = i_User.Id,
                    UserName = i_User.Name
                };
                BestFriends.Add(bestFriend);
            }

            return bestFriend;
        }
    }
}
