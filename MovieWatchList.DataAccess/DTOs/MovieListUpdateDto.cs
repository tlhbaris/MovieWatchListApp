using MovieWatchList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.DataAccess.DTOs
{
    public class MovieListUpdateDto
    {
        public int MovieListId { get; set; }
        public string ListName { get; set; }
        public string Description { get; set; }



    }
}
