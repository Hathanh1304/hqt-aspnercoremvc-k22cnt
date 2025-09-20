using HqtDay03View.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HqtDay03View.Models;

namespace HqtDay03View.Controllers
{
    public class HqtHomeController : Controller
    {
        private readonly ILogger<HqtHomeController> _logger;

        public HqtHomeController(ILogger<HqtHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult HqtIndex()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult HqtAbout()
        {
            return View();
        }

        public IActionResult HqtViewIf()
        {
            return View();
        }
        public IActionResult HqtViewLoop()
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