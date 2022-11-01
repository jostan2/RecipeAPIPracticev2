using Microsoft.AspNetCore.Mvc;
using RecipeAPIPracticev2.Models;
using System.Diagnostics;

namespace RecipeAPIPracticev2.Controllers
{
    public class HomeController : Controller
    {
        RecipeDAL api = new RecipeDAL();
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Results r = api.SearchRecipe("Pasta");
            return View(r);
        }

        public IActionResult SearchByTitle()
        {
            return View();
        }

        public IActionResult Results(string title)
        {
            Results r = api.SearchRecipe(title);
            return View(r);
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