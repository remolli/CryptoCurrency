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
            var responseDeserialized = await _api.GetTickersAsync();
            return View(responseDeserialized);
        }

        public async Task<IActionResult> Ticker(string symbol)
        {
            if (symbol == null)
            {
                symbol = "BTC";
            }
            var responseDeserialized = await _api.GetTickerAsync(symbol);
            return View(responseDeserialized);
        }

        public async Task<IActionResult> Tickers()
        {
            var responseDeserialized = await _api.GetTickersAsync();
            return View(responseDeserialized);
        }

        // ---------------------------------------

        public async Task<IActionResult> Symbol(string symbol)
        {
            if (symbol == null)
            {
                symbol = "BTC";
            }
            var responseDeserialized = await _api.GetSymbolAsync(symbol);
            return View(responseDeserialized);
        }

        public async Task<IActionResult> Symbols()
        {
            var responseDeserialized = await _api.GetSymbolsAsync();
            return View(responseDeserialized);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}