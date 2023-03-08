using MovieWatchList.Business.Abstract;
using MovieWatchList.DataAccess.Abstract;
using MovieWatchList.DataAccess.DTOs;
using MovieWatchList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.Business.Concrete
{
    public class MovieListManager : IMovieListService
    {
        private readonly IMovieListRepository _movieListRepository;

        public MovieListManager(IMovieListRepository movieListRepository)
        {
            _movieListRepository = movieListRepository;
        }

        public void CreateMovieList(MovieList movieList)
        {
            _movieListRepository.CreateMovieList(movieList);
        }

        public void DeleteMovieList(int id)
        {
            _movieListRepository.DeleteMovieList(id);
        }

        public MovieList GetMovieList(int id)
        {
          return _movieListRepository.GetMovieList(id);
        }

        public void UpdateMovieList(MovieListUpdateDto movieList)
        {
            _movieListRepository.UpdateMovieList(movieList);
        }

        public void MovieListAddMovie(int movieListId, int externalApiId)
        {
            _movieListRepository.MovieListAddMovie(movieListId, externalApiId);
        }

        public List<MovieList> GetMovieListByUserId(string userId)
        {
            return _movieListRepository.GetMovieListByUserId(userId);
        }
        public void MovieListDeleteMovie(int movieListId, int extarnalApiId)
        {
            _movieListRepository.MovieListDeleteMovie(movieListId, extarnalApiId);
        }
    }
}
