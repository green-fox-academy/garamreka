﻿using System;

namespace _02___UrlFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crutial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            url = url.Insert(5, ":").Replace("bots", "odds");

            Console.WriteLine(url);
            Console.ReadLine();
        }
    }
}
