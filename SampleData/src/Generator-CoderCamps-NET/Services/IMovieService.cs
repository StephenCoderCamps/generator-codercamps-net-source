using System.Collections.Generic;
using Generator_CoderCamps_NET.Models;

namespace Generator_CoderCamps_NET.Services
{
    public interface IMovieService
    {
        void DeleteMovie(int id);
        Movie FindMovie(int id);
        IList<Movie> ListMovies();
        void SaveMovie(Movie movie);
    }
}