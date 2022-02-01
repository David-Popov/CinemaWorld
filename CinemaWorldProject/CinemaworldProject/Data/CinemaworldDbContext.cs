using CinemaworldProject.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaworldProject.Data
{
    public class CinemaworldDbContext : IdentityDbContext
    {
        public CinemaworldDbContext(DbContextOptions<CinemaworldDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movies> Movies { get; set; }

        public DbSet<Genre> Genre { get; set; }

    }
}
