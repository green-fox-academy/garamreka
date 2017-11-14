using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheReddit.Models
{
    public class RedditPost
    {
        public long Id { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public RedditPost ()
        {
            this.Date = DateTime.Today;
        }
    }
}
