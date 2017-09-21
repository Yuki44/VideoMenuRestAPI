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

        public List<Genre> Genres { get; set; }

        #endregion
    }

}
