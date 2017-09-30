using System;
using VideoMenuBLL.BusinessObjects;
using VideoMenuDAL.Entities;
using System.Linq;

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
                Videos = genre.VideoIds?.Select(id => new Video() { Id = id }).ToList()
            };
        }

        internal GenreBO Convert(Genre genre)
        {
            if (genre == null) { return null; }
            return new GenreBO()
            {
                Id = genre.Id,
                GenreTitle = genre.GenreTitle,
                VideoIds = genre.Videos?.Select(v => v.Id).ToList()
            };
        }
    }
}
