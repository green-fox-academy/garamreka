using MyFirstWebApp.Controllers;

namespace MyFirstWebApp.Models
{
    public class Greeting
    { 
        public long Id { get; set; }
        public string Content { get; set; }
        public string WebPage = "(It is a web page.)";
        public int LoadCounter = WebController.LoadCounter;

        public Greeting(string name)
        {
            Id = RESTController.idCounter;
            Content = $"Hello, {name}";
        }

        public Greeting()
        {
        }
    }
}
