using System.Diagnostics;
using Asp.Net.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net.Mvc.Controllers
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

            /*@@if jy1*/
            string str = "jy1 is true" ;
            /*@@else*/
/*tt
            string str = "jy1 is false";
            tt*/
/*@@endif*/

            return View();
        }

        public IActionResult Privacy()
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
