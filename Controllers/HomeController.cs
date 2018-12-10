using Microsoft.AspNetCore.Mvc;
namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000
        [HttpGet("")]
        public string HelloFromController()
        {
            return "Hello from controller";
        }

        // localhost:5000/hello
        [HttpGet("hello")]
        public string Hello()
        {
            return "Hi again!";
        }
        // Localhost:5000/users/??
        [HttpGet("users/{username}/{location}")]
        public string HelloUser(string username, string location)
        {
            return $"Hello {username} from {location}";
        }
    }
}