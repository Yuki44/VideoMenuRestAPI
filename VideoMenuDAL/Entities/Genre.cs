using System;
namespace VideoMenuDAL.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreTitle { get; set; }
        public Video Video { get; set; }
    }
}
