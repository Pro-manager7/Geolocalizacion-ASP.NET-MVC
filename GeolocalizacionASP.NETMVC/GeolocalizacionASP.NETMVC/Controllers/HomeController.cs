using GeolocalizacionASP.NETMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GeolocalizacionASP.NETMVC.Controllers
{
    public class HomeController : Controller
    {
        #region [Properties]
        private readonly ILogger<HomeController> _logger;
        #endregion

        #region [Constrcutor]
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        #endregion

        #region [ActionResult]
        public IActionResult Index()
        {
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
        #endregion
    }
}