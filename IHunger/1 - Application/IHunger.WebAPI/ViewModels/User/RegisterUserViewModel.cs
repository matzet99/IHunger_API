﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IHunger.WebAPI.ViewModels.User
{
    public class RegisterUserViewModel
    {
        [Required(ErrorMessage = "The field {0} is required")]
        [EmailAddress(ErrorMessage = "The field {0} is invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(255, ErrorMessage = "The field {0} need to have between {2} and {1} characters", MinimumLength = 6)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        public Domain.Models.User ToDomain()
        {
            var entity = new Domain.Models.User();

            entity.UserName = Email;
            entity.Email = Email;
            entity.EmailConfirmed = true;

            return entity;
        }
    }
}
