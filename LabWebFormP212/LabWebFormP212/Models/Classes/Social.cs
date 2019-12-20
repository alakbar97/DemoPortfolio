using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabWebFormP212.Models.Classes
{
    public class Social
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50,MinimumLength =5)]
        public string IconName { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 5)]
        public string Link { get; set; }
    }
}