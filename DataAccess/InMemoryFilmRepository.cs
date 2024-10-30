using FilmRecommendationApp.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FilmRecommendationApp.DataAccess
{
    public class InMemoryFilmRepository
    {
        private List<FilmModel> _films;
        private int _nextId = 1;

        public InMemoryFilmRepository()
        {
            _films = new List<FilmModel>
            {
                new FilmModel { Id = _nextId++, Title = "Inception", Year = 2010, Genre = "Science Fiction", Description = "A skilled thief is given a chance to erase his past crimes by implanting an idea into a target's subconscious." },
                new FilmModel { Id = _nextId++, Title = "The Matrix", Year = 1999, Genre = "Action", Description = "A computer hacker learns the shocking truth about his reality and his role in a rebellion against its controllers." },
                new FilmModel { Id = _nextId++, Title = "Interstellar", Year = 2014, Genre = "Adventure", Description = "A team of explorers travels through a wormhole in space to ensure humanity's survival." }
            };
        }

        public List<FilmModel> GetAll() => _films;

        public FilmModel? GetById(int id)
        {
            var film = _films.FirstOrDefault(f => f.Id == id);
            return film;
        }

        public void Add(FilmModel film)
        {
            film.Id = _nextId++;
            _films.Add(film);
        }

        public void Remove(int id)
        {
            var film = GetById(id);
            if (film != null)
            {
                _films.Remove(film);
            }
        }
    }
}