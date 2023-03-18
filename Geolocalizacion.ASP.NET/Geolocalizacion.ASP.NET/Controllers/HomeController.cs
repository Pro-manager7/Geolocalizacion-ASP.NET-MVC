using Geolocalizacion.ASP.NET.Context.Interfaces;
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
        private readonly IHomeContext _homeContext;
        #endregion

        #region [Constructor]   
        public HomeController(ILogger<HomeController> logger, IHomeContext homeContext)
        {
            _logger = logger;
            _homeContext = homeContext;
        } 
        #endregion

        #region [Action Result]
        public IActionResult Index()
        {
            var response = _homeContext.GetAllUbicaciones();
            return View(response);
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
