using System;
using Microsoft.EntityFrameworkCore;
using VideoMenuDAL.Entities;

namespace VideoMenuDAL.Context
{
    class VideoAppContext : DbContext
    {
        static DbContextOptions<VideoAppContext> options =
            new DbContextOptionsBuilder<VideoAppContext>()
                .UseInMemoryDatabase("TheDB").Options;
        //Options we want in memory

        public VideoAppContext() : base(options)
        {

        }

        public DbSet<Video> videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
