using System.Collections.Generic;
using MovieLibrary.Models;

namespace MovieLibrary.Data
{
    public interface IContext
    {
        void AddMovie(Movie movie);
        List<Movie> GetMovies();
    }
}