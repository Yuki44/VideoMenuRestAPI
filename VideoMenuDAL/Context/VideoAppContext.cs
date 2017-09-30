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

        //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    {
        //        if (!optionsBuilder.IsConfigured)
        //        {
        //            optionsBuilder.UseSqlServer(@"Server=tcp:videoapp.database.windows.net,1433;
        //            Initial Catalog=VideoApp;
        //Persist Security Info=False;
        //User ID=carl7755;
        //Password=AbCdE1234;
        //MultipleActiveResultSets=False;
        //Encrypt=True;TrustServerCertificate=False;
        //Connection Timeout=30;");
        //    }
        //}

        public DbSet<Video> videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
