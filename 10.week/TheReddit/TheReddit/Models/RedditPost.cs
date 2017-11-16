using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheReddit.Models
{
    public class RedditPost
    {
        [Key]
        public long Id { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }

        [MinLength (5, ErrorMessage = "Title must contain at least 5 character")]
        [MaxLength (30)]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public RedditPost ()
        {
            this.Date = DateTime.Today;
        }
    }
}
