using CinemaworldProject.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaworldProject.Models
{
    public class MovieModel
    {
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
        
        public IEnumerable<Genre>  Genre { get; set; }
    }
}
