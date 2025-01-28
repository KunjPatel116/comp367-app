using Microsoft.AspNetCore.Mvc;

namespace HelloWorldWebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello Kunj Patel!";
        }
    }
}