﻿using System;
using System.Collections.Generic;

namespace MovieLibrary.DataModels
{
    public class Movie
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }

        
        public virtual ICollection<MovieGenre> MovieGenres {get;set;}
    }
}
