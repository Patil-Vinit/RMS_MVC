﻿using System.ComponentModel.DataAnnotations;

namespace Clothings.Models
{
    public class about
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
    }
}
