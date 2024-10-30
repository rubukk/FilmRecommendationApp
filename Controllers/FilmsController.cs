using FilmRecommendationApp.Business;
using FilmRecommendationApp.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FilmRecommendationApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmsController : ControllerBase
    {
        private readonly FilmService _filmService;

        public FilmsController(FilmService filmService)
        {
            _filmService = filmService;
        }

        [HttpGet]
        public ActionResult<List<FilmModel>> GetAll() => _filmService.GetAllFilms();
    }
}