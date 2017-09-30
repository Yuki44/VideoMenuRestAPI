using System;
using System.Collections.Generic;

namespace VideoMenuDAL.Entities
{
    public class Video
    {
        #region Properties

        // Id of the video
        public int Id { get; set; }

        // Name of the video
        public string Title { get; set; }


        public int GenreId { get; set; }
        public Genre Genres { get; set; }

        #endregion
    }

}
