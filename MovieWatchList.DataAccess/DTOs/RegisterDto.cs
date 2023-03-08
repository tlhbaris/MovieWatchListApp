﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.DataAccess.DTOs
{
    public class RegisterViewModel
    {


        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Password { get; set; }


        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string ConfirmPassword { get; set; }




    }
}
