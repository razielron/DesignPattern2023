using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class BestFriendsFeature
    {
        public List<BestFriend> FetchAndSortBestFriends(User i_LoggedInUser)
        {
            List<BestFriend> bestFriends = new List<BestFriend>();

            var postsResponse = i_LoggedInUser.Posts;
            var postsData = postsResponse;

            foreach (Post post in postsData)
            {
                countLikesPerFriend(post, bestFriends);
                countCommentsPerFriend(post, bestFriends); 
            }

            bestFriends.Sort((f1, f2) => f2.TotalPoints.CompareTo(f1.TotalPoints));

            return bestFriends;
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
