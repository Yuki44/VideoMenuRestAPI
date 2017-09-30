using System;
using System.Collections.Generic;

namespace VideoMenuDAL.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreTitle { get; set; }
        public List<Video> Videos { get; set; }
    }
}
