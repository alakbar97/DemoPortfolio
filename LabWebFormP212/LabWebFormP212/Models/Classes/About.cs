using System.ComponentModel.DataAnnotations;

namespace LabWebFormP212.Models
{
    public class About
    {
        public int ID { get; set; }
        [Required]
        [StringLength(30,MinimumLength = 5)]
        public string Title { get; set; }
        [Required]
        [StringLength(110, MinimumLength = 15)]
        public string Description { get; set; }
    }
}