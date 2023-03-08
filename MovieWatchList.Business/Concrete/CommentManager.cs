using MovieWatchList.Business.Abstract;
using MovieWatchList.DataAccess.Abstract;
using MovieWatchList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        public CommentManager(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public Comment AddComment(string userId, int moveList, string commentBody)
        {
            return _commentRepository.AddComment(userId, moveList, commentBody);
        }

        public List<Comment> GetCommentsByMovieListId(int movieListId)
        {
            return _commentRepository.GetCommentsByMovieListId(movieListId);
        }
    }
}
