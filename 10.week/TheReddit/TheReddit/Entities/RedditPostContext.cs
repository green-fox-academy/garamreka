using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheReddit.Models;

namespace TheReddit.Entities
{
    public class RedditPostContext : DbContext
    {
        public RedditPostContext(DbContextOptions<RedditPostContext> options) : base(options)
        {

        }

        public DbSet<RedditPost> RedditPosts { get; set; }
    }
}
