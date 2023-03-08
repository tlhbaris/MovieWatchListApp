 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.Entities
{
    public class MovieList
    {
        
        public int MovieListId { get; set; }
        public string ListName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;



        //Navigation property
        public List<MovieListMovie> MovieListMovies { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }

        //public List<Comment> Comments { get; set; }

    }
}
