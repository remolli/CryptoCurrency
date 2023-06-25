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

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ExchangeRate(string asset_id_base)
        {
            if (asset_id_base == null)
            {
                asset_id_base = "BTC";
            }
            var responseDeserialized = await _api.GetExchangeRateAsync(asset_id_base);
            return View(responseDeserialized);
        }

        public async Task<IActionResult> Assets(string filter)
        {
            if (filter == null)
            {
                var responseDeserialized = await _api.GetAssetsAsync();
                return View(responseDeserialized);
            }
            else
            {
                var responseDeserialized = await _api.GetAssetsFilterAsync(filter);
                return View(responseDeserialized);
            }

        }

        public async Task<IActionResult> Asset(string asset_id_base)
        {
            if (asset_id_base == null)
            {
                asset_id_base = "BTC";
            }
            var responseDeserialized = await _api.GetAssetAsync(asset_id_base);
            return View(responseDeserialized);
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