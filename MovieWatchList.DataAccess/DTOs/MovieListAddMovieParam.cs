using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.DataAccess.DTOs
{
    public class MovieListAddMovieParam
    {
        public int MovieListId { get; set; }
        public int ExternalApiId { get; set; }

    }
}
