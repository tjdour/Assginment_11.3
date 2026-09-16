using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assginment_11._3.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string? GenreName { get; set; }

        public virtual ObservableCollectionListSource<Movie> Movies { get; } = new();

    }
}
