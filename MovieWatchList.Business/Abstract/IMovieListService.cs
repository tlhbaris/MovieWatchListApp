using MovieWatchList.DataAccess.DTOs;
using MovieWatchList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.Business.Abstract
{
    public interface IMovieListService
    {
        void CreateMovieList(MovieList movieList);
        MovieList GetMovieList(int id);
        void UpdateMovieList(MovieListUpdateDto movieList);
        void DeleteMovieList(int id);
        void MovieListAddMovie(int movieListId, int externalApiId);

        List<MovieList> GetMovieListByUserId(string userId);
        void MovieListDeleteMovie(int movieListId, int extarnalApiId);
        



    }
}
