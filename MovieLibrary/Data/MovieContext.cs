using System.Collections.Generic;
using MovieLibrary.Models;

namespace MovieLibrary.Data
{
    public class MovieContext : IContext
    {
        private readonly IRepository _repository;

        public MovieContext(IRepository repository)
        {
            _repository = repository;
        }

        public void AddMovie(Movie movie)
        {
            _repository.Add(movie);
        }

        public List<Movie> GetMovies()
        {
            return _repository.GetAll();
        }
    }
}