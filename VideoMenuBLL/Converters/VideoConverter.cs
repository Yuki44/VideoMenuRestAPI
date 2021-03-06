﻿using System;
using VideoMenuBLL.BusinessObjects;
using VideoMenuDAL.Entities;

namespace VideoMenuBLL.Converters
{
    class VideoConverter
    {
        internal Video Convert(VideoBO vid)
        {
            if (vid == null) { return null; }
            return new Video()
            {
                Id = vid.Id,
                Title = vid.Title,
                GenreId = vid.Genre != null ? vid.Genre.Id : vid.GenreId
            };
        }

        internal VideoBO Convert(Video vid)
        {
            if (vid == null) { return null; }
            return new VideoBO()
            {
                Id = vid.Id,
                Title = vid.Title,
                GenreId = vid.GenreId
            };
        }
    }
}
