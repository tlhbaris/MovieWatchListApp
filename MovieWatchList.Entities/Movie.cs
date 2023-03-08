using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.Entities
{
   

    public class Movie
    {


        public int  Id { get; set; }
        public int ExternalApiId { get; set; }
       




        //Navigation Property
        public List<MovieListMovie> MovieListMovies { get; set; }
        
    }
}
