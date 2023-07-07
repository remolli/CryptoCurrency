using CryptoCurrency.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CryptoCurrency.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        API _api = new API();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var responseDeserialized = await _api.GetAssetsAsync();
            return View(responseDeserialized);
        }

        public async Task<IActionResult> Symbol(string id)
        {
            var requestDeserialized = await _api.GetAssetAsync(id);
            return View(requestDeserialized);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
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