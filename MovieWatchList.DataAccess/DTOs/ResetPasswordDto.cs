using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.DataAccess.DTOs
{
    public class ResetPasswordViewModel
    {
        public string Username { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmNewPassword { get; set; }
        public string Token { get; set; }

    }
}
