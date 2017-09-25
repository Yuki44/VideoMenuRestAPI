using System;
using VideoMenuBLL.BusinessObjects;
using VideoMenuDAL.Entities;

namespace VideoMenuBLL.Converters
{
    class GenreConverter
    {
        internal Genre Convert(GenreBO genre)
        {
            if (genre == null) { return null; }
            return new Genre()
            {
                Id = genre.Id,
                GenreTitle = genre.GenreTitle,
                VideoId = genre.VideoId
            };
        }

        internal GenreBO Convert(Genre genre)
        {
            if (genre == null) { return null; }
            return new GenreBO()
            {
                Id = genre.Id,
                GenreTitle = genre.GenreTitle,
                Video = new VideoConverter().Convert(genre.Video),
                VideoId = genre.VideoId
            };
        }
    }
}
