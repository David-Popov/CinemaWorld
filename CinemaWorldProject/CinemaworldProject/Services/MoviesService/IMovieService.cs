using CinemaworldProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaworldProject.Services.MoviesService
{
    public interface IMovieService
    {
        public IEnumerable<Movies> GetMovies();

    }
}
