using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheReddit.Entities;
using TheReddit.Models;

namespace TheReddit.Repositories
{
    public class RedditPostRepository
    {
        RedditPostContext RedditPostContext;

        public RedditPostRepository(RedditPostContext redditPostContext)
        {
            this.RedditPostContext = redditPostContext;
        }

        public List<RedditPost> GetPost()
        {
            return RedditPostContext.RedditPosts.ToList();
        }

        public void AddPost(RedditPost post)
        {
            RedditPostContext.RedditPosts.Add(post);
            RedditPostContext.SaveChanges();
        }

        public RedditPost GetID(long id)
        {
            return RedditPostContext.RedditPosts.FirstOrDefault(p => p.Id == id);
        }

        public void UpvotePost(RedditPost oldpost)
        {
            var newpost = RedditPostContext.RedditPosts.FirstOrDefault(p => p.Id == oldpost.Id);
            newpost.UpVote++;
            RedditPostContext.SaveChanges();
        }

        public void DownvotePost(RedditPost oldpost)
        {
            var newpost = RedditPostContext.RedditPosts.FirstOrDefault(p => p.Id == oldpost.Id);
            newpost.DownVote++;
            RedditPostContext.SaveChanges();
        }
    }
}
