using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentBody { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;





        public int MovieListId { get; set; }
        public MovieList MovieList { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }


    }
}
