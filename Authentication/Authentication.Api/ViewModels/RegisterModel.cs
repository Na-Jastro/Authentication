﻿using System.ComponentModel.DataAnnotations;

namespace Authentication.Api.ViewModels
{
    public class RegisterModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string JobTitle { get; set; }
    }
}
