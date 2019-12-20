using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabWebFormP212.Models.Classes
{
    public class Service
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string IconName { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string Title { get; set; }
        [Required]
        [StringLength(110, MinimumLength = 15)]
        public string Description { get; set; }
    }
}