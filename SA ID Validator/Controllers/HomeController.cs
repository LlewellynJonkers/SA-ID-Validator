using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SA_ID_Validator.Controllers
{
    public class HomeController : Controller
    {

        public HomeController():base()
        {
        }

        // GET: /
        public IActionResult Index()
        {
            return View(new Models.ErrorViewModel(){RequestId = HttpContext.TraceIdentifier});
        }
        // GET: /Home/Bulk
        [HttpGet]
        public IActionResult Bulk()
        {
            return View(new Models.ErrorViewModel(){RequestId = HttpContext.TraceIdentifier});
        }

        // GET: /Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // GET: /Home/Contact
        public IActionResult Contact()
        {
            return View();
        }

        // GET: /Home/Error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}