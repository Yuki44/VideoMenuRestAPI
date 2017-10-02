using System;
using System.Collections.Generic;
using VideoMenuDAL.Entities;

namespace VideoMenuDAL
{
    public interface IGenreRepository
    {
        //C
        Genre Create(Genre genre);
        //R
        List<Genre> GetAll();
        Genre Get(int Id);
        //U
        /// No Update here!
        //D
        Genre Delete(int Id);
    }
}
