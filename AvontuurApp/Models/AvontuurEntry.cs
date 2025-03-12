using System.ComponentModel.DataAnnotations;

namespace AvontuurApp.Models
{
    public class AvontuurEntry
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Title needs to be between 3 and 100 characters!")]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty;
        public string Location { get; set; }
        [Required(ErrorMessage = "Select a vaild date!")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
