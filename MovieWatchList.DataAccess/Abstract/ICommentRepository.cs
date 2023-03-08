using MovieWatchList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.DataAccess.Abstract
{
    public interface ICommentRepository
    {
        Comment AddComment(string userId, int moveList, string commentBody);
        List<Comment> GetCommentsByMovieListId(int movieListId);


    }
}
