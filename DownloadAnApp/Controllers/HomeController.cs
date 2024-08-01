using DownloadAnApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DownloadAnApp.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Download method
        public IActionResult GetMyApp()
        {
            //Get the file path of application
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "app-release.apk");

            //Read the bytes
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            //find the bytes
            var fileName = "app-release.apk";

            //Return files
            return File(fileBytes, "application/octet-stream", fileName);

        }
    }
}
