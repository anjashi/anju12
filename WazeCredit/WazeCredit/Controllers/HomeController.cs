using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using wazeCredit.Models;
using wazeCredit.Service;

namespace wazeCredit.Controllers
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
            HomeVM homeVM = new HomeVM();
            MarketForcaster marketForcaster= new MarketForcaster(); 

            MarketResult   currrentMarket= new MarketResult();


            switch (currrentMarket.MarketCondition)
            {
                case MarketCondition.StableDown:
   homeVM.MarketForcast = "Market shown shows down";
                    break;

            }
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

    internal class HomeVM
    {
        public string MarketForcaster { get; internal set; }
        public string MarketForcast { get; internal set; }
    }
}