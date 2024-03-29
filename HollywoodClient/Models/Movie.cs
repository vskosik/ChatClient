﻿using System.ComponentModel.DataAnnotations;

namespace HollywoodClient.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Director { get; set; }
    }
}
