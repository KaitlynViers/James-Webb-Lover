using James_Webb_Lover.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;


namespace James_Webb_Lover.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
      

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       
        public IActionResult Index()
        { 


            return View();
        }

       
        [Route("/Gallery")]
        public IActionResult Gallery()
        {
            return View();
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}