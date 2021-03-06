﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projecto_Esw.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {

        public int ForgotPasswordId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
