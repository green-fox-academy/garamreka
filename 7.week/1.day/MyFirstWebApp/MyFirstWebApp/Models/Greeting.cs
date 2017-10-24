using MyFirstWebApp.Controllers;

namespace MyFirstWebApp.Models
{
    public class Greeting
    { 
        public long Id { get; set; }
        public string Content { get; set; }

        public Greeting(string name)
        {
            Id = RESTController.idCounter;
            Content = $"Hello, {name}";
        }
    }
}
