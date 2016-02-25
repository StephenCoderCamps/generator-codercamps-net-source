using System.Collections.Generic;
using Generator_CoderCamps_NET.Models;

namespace Generator_CoderCamps_NET.Services
{
    public interface IGenreService
    {
        Genre FindGenre(int id);
        IList<Genre> ListGenres();
    }
}