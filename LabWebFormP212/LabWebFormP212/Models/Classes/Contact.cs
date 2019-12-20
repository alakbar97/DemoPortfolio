using System.ComponentModel.DataAnnotations;

namespace LabWebFormP212.Models.Classes
{
    public class Contact
    {
        public int ID { get; set; }
        [Required]
        [StringLength(30,MinimumLength = 5)]
        public string IconName { get; set; }
        [Required]
        public string Description { get; set; }
    }
}