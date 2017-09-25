using System;

namespace Post_it
{
    public struct PostIt
    {
        public string BackgroundColor;
        public string Text;
        public string TextColor;
    }
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postIt1;
            postIt1.BackgroundColor = "orange";
            postIt1.Text = "Idea 1";
            postIt1.TextColor = "blue";

            PostIt postIt2;
            postIt2.BackgroundColor = "pink";
            postIt2.Text = "Awesome";
            postIt2.TextColor = "black";

            PostIt postIt3;
            postIt3.BackgroundColor = "yellow";
            postIt3.Text = "Superb";
            postIt3.TextColor = "green";

            Console.WriteLine(postIt1.BackgroundColor + " " + postIt1.Text + " " + postIt1.TextColor);
            Console.WriteLine(postIt2.BackgroundColor + " " + postIt2.Text + " " + postIt2.TextColor);
            Console.WriteLine(postIt3.BackgroundColor + " " + postIt3.Text + " " + postIt3.TextColor);
            Console.ReadLine();
        }
    }
}
