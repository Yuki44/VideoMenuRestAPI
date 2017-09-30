using System;
using System.Collections.Generic;
using System.Linq;
using VideoMenuBLL.BusinessObjects;
using VideoMenuBLL.Converters;
using VideoMenuDAL;
using VideoMenuDAL.Entities;

namespace VideoMenuBLL.Services
{
    class GenreService : IGenreService
    {
        GenreConverter conv = new GenreConverter();
        VideoConverter vConv = new VideoConverter();
        private DALFacade _facade;
        public GenreService(DALFacade facade)
        {
            _facade = facade;
        }

        public GenreBO Create(GenreBO genre)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var genreEntity = uow.GenreRepository.Create(conv.Convert(genre));
                uow.Complete();
                return conv.Convert(genreEntity);
            }
        }

        public GenreBO Delete(int Id)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var genreEntity = uow.GenreRepository.Delete(Id);
                uow.Complete();
                return conv.Convert(genreEntity);
            }
        }

        public GenreBO Get(int Id)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var genreEntity = uow.GenreRepository.Get(Id);
                var genreBO = conv.Convert(genreEntity);
                genreBO.Videos = genreEntity.Videos?.Select(v => vConv.Convert(v)).ToList();
                return genreBO;
            }
        }

        public List<GenreBO> GetAll()
        {
            using (var uow = _facade.UnitOfWork)
            {
                return uow.GenreRepository.GetAll().Select(conv.Convert).ToList();
            }
        }

        public GenreBO Update(GenreBO genre)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var genreEntity = uow.GenreRepository.Get(genre.Id);
                if (genreEntity == null)
                {
                    throw new InvalidOperationException("Order not found");
                }
                genreEntity.GenreTitle = genre.GenreTitle;
                genreEntity.Videos = genre.VideoIds.Select(id => new Video() { Id = id }).ToList();
                uow.Complete();
                // BLL choice
                //genreEntity.Videos = uow.VideoRepository.Get(genreEntity.VideoId);
                return conv.Convert(genreEntity);
            }
        }
    }
}
