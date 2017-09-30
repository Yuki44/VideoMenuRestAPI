using System;
using System.Collections.Generic;
using VideoMenuDAL.Entities;
using VideoMenuDAL.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace VideoMenuDAL.Repositories
{
    class GenreRepository : IGenreRepository
    {
        VideoAppContext _context;

        public GenreRepository(VideoAppContext context)
        {
            _context = context;
        }
        public Genre Create(Genre genre)
        {
            _context.Genres.Add(genre);
            return genre;
        }

        public Genre Delete(int Id)
        {
            var genre = Get(Id);
            _context.Genres.Remove(genre);
            return genre;
        }

        public Genre Get(int Id)
        {
            return _context.Genres.Include(g => g.Videos).FirstOrDefault(g => g.Id == Id);
        }

        public List<Genre> GetAll()
        {
            return _context.Genres.Include(g => g.Videos).ToList();
        }
    }
}
