using System;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var postByJohnDoe = new BlogPost();
            postByJohnDoe.AuthorName = "John Doe";
            postByJohnDoe.Title = "Lorem Ipsum";
            postByJohnDoe.Text = "Lorem ipsum dolor sit amet.";
            postByJohnDoe.PublicationDate = "2000.05.04.";

            var postByTimUrban = new BlogPost();
            postByTimUrban.AuthorName = "Tim Urban";
            postByTimUrban.Title = "Wait but why";
            postByTimUrban.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
            postByTimUrban.PublicationDate = "2010.10.10.";

            var postByWilliamTurton = new BlogPost();
            postByWilliamTurton.AuthorName = "William Turton";
            postByWilliamTurton.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            postByWilliamTurton.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";
            postByWilliamTurton.PublicationDate = "2017.03.28.";

            Console.WriteLine(postByWilliamTurton.Text);
            Console.ReadLine();
        }
    }
}
