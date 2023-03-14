using Geolocalizacion.ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Geolocalizacion.ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        #region [Properties]
        private readonly ILogger<HomeController> _logger;
        #endregion

        #region [Constructor]   
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        } 
        #endregion

        #region [Action Result]
        public ActionResult Index()
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
