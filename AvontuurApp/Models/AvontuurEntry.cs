namespace AvontuurApp.Models
{
    public class AvontuurEntry
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.empty;
        [Required]
        public string Content { get; set; } = string.empty;
        public string Location { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
