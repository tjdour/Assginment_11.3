using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Assginment_11._3.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string? Title { get; set; }
        public int Year { get; set; }
        public int GenreId { get; set; }
        public virtual Genre? Genre { get; set; }
    }
}
