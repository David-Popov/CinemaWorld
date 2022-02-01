using CinemaworldProject.Data;
using CinemaworldProject.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaworldProject.Infrastructure
{
    public static class ApplicationBuilderContext
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<CinemaworldDbContext>();

            data.Database.Migrate();

            SeedGenres(data);

            return app;
        }

        private static void SeedGenres(CinemaworldDbContext db)
        {
            if (db.Genre.Any())
            {
                return;
            }

            db.Genre.AddRange(new[]
            {
                new Genre {Name = "Action"},
                new Genre {Name = "Comedy"},
                new Genre {Name = "Drama"},
                new Genre {Name = "Fantasy"},
                new Genre {Name = "Horror "},
                new Genre {Name = "Mystery  "},
                new Genre {Name = "Romance "},
                new Genre {Name = "Thriller "},
                new Genre {Name = "Western "},
                new Genre {Name = "Crime Thriller "},
                new Genre {Name = "Disaster Thriller"},
                new Genre {Name = "Techno Thriller"},
        });

            db.SaveChanges();
        }
    }

   
}
