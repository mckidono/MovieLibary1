using System.Collections.Generic;
using MovieLibrary.Models;

namespace MovieLibrary.Data
{
    public interface IRepository {
        void Add(Movie movie);
        List<Movie> GetAll();
    }
}
