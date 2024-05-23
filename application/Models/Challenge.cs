using System;
using System.ComponentModel.DataAnnotations;

namespace application.Models
{
    public class Challenge
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Category { get; set; } = string.Empty;

        [Required]
        public string DifficultyLevel { get; set; } = string.Empty;

        public DateTime StartDate { get; set; } = DateTime.Now;

        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(7);

        public string UserId { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;
    }
}