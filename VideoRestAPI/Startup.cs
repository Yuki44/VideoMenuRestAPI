﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using VideoMenuBLL;
using VideoMenuBLL.BusinessObjects;

namespace VideoRestAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                var facade = new BLLFacade();

                var genreRock = facade.GenreService.Create(new GenreBO()
                {
                    GenreTitle = "Rock"
                });
                var genreBlues = facade.GenreService.Create(new GenreBO()
                {
                    GenreTitle = "Blues"
                });
                var genreJazz = facade.GenreService.Create(new GenreBO()
                {
                    GenreTitle = "Jazz"
                });
                var genreBossa = facade.GenreService.Create(new GenreBO()
                {
                    GenreTitle = "Bossa Nova"
                });


                facade.VideoService.Create(new VideoBO()
                {
                    Title = "Development Video Test",
                    GenreId = genreRock.Id
                });
                facade.VideoService.Create(new VideoBO()
                {
                    Title = "Development Video Test 2",
                    GenreId = genreJazz.Id
                });
                facade.VideoService.Create(new VideoBO()
                {
                    Title = "Development Video Test 3",
                    GenreId = genreBossa.Id
                });


            }

            app.UseMvc();
        }
    }
}
