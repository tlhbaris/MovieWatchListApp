using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.DataAccess.DTOs
{
    public class GetMovieListDto
    {
        public int MovieListId { get; set; }
        public string ListName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<int> Movies { get; set; }



    }
}
