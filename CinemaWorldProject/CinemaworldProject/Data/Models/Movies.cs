using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaworldProject.Data.Models
{
    public class Movies
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string PremiereDate { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string GenreId { get; set; }
        [Required]
        public Genre Genre { get; set; }
    }
}
