using CinemaworldProject.Data;
using CinemaworldProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaworldProject.Services.MoviesService
{
    public class MovieService : IMovieService
    {
        private readonly CinemaworldDbContext db;

        public MovieService(CinemaworldDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Movies> GetMovies()
        {
            var movies = db.Movies
                .Select(x => new Movies
                {
                    Id = x.Id,
                    Name = x.Name,
                    Duration = x.Duration,
                    PremiereDate = x.PremiereDate,
                    Description = x.Description,
                    ImageUrl = x.ImageUrl,
                    GenreId = x.GenreId
                })
                .ToList();

            return movies;
        }
    }
}
