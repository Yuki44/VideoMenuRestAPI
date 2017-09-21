using System;
namespace VideoMenuBLL.BusinessObjects
{
    public class GenreBO
    {
        public GenreBO()
        {
        }

        public int Id { get; set; }
        public string GenreTitle { get; set; }
        public VideoBO Video { get; set; }
    }
}
