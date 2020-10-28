using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RedRiver.Test.Models;

namespace RedRiver.Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDrinksMachine _drinksMachine;

        public HomeController(ILogger<HomeController> logger, IDrinksMachine drinksMachine)
        {
            _logger = logger;
            _drinksMachine = drinksMachine;
        }

        public IActionResult Index()
        {
            var model = _drinksMachine.GetAvailableDrinks();
            return View(model);
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
