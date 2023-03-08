using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.Entities
{
    public class MovieListMovie
    {
        public int MovieListId { get; set; }
        public MovieList MovieList { get; set; }
        
        public int ExternalApiId { get; set; }
        public int MovieId { get; set; } = 1;
        public Movie Movie { get; set; }


    }
}
