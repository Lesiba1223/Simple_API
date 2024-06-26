﻿using System.ComponentModel.DataAnnotations;

namespace Simple_API_Assessment.Models
{
    public class Applicant
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";

        public ICollection<Skill>? Skills { get; set; }
    }
}
