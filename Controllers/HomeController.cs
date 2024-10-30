using Microsoft.AspNetCore.Mvc;
using FilmRecommendationApp.Business;
using FilmRecommendationApp.Entities;
using System.Diagnostics;
using FilmRecommendationApp.Models;

namespace FilmRecommendationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly FilmService _filmService;

        public HomeController(FilmService filmService)
        {
            _filmService = filmService;
        }

        public IActionResult Index()
        {
            var films = _filmService.GetAllFilms();
            return View(films);
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