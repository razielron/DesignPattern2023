using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class BestFriendsManager
    {
        private List<Post> m_Posts;
        public List<BestFriend> BestFriends;

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
                countLikesPerFriend(post, BestFriends);
                countCommentsPerFriend(post, BestFriends);
            }

            BestFriends.Sort((f1, f2) => f2.TotalPoints.CompareTo(f1.TotalPoints));
        }

        private void countLikesPerFriend(Post post, List<BestFriend> bestFriends)
        {
            foreach (User liker in post.LikedBy)
            {
                BestFriend bestFriend = bestFriends.FirstOrDefault(f => f.UserId == liker.Id);
                if (bestFriend == null)
                {
                    bestFriend = new BestFriend
                    {
                        UserId = liker.Id,
                        UserName = liker.Name
                    };
                    bestFriends.Add(bestFriend);
                }

                bestFriend.LikesCounter += 1; 
            }
        }

        private void countCommentsPerFriend(Post post, List<BestFriend> bestFriends)
        {
            foreach (Comment comment in post.Comments)
            {
                User commenter = comment.From;

                BestFriend bestFriend = bestFriends.FirstOrDefault(f => f.UserId == commenter.Id);
                if (bestFriend == null)
                {
                    bestFriend = new BestFriend
                    {
                        UserId = commenter.Id,
                        UserName = commenter.Name,
                        
                    };
                    bestFriends.Add(bestFriend);
                }

                bestFriend.CommentsCounter += 1; 
            }
        }
    }
}
