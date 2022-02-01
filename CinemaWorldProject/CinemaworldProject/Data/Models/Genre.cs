using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaworldProject.Data.Models
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        IEnumerable<Movies> Movies { get; init; } = new List<Movies>();
    }
}
