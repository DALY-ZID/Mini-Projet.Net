﻿using System.ComponentModel.DataAnnotations;
namespace MiniProjet.Net.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
