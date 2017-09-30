using System;
using System.Collections.Generic;

namespace VideoMenuBLL.BusinessObjects
{
    public class GenreBO
    {
        public int Id { get; set; }
        public string GenreTitle { get; set; }

        public List<int> VideoIds { get; set; }
        public List<VideoBO> Videos { get; set; }
    }
}
