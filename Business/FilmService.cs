using FilmRecommendationApp.DataAccess;
using FilmRecommendationApp.Entities;
using System.Collections.Generic;

namespace FilmRecommendationApp.Business
{
    public class FilmService
    {
        private readonly InMemoryFilmRepository _repository;

        public FilmService()
        {
            _repository = new InMemoryFilmRepository();
        }

        public List<FilmModel> GetAllFilms() => _repository.GetAll();

        public void AddFilm(FilmModel film) => _repository.Add(film);

        public void DeleteFilm(int id) => _repository.Remove(id);
    }
}