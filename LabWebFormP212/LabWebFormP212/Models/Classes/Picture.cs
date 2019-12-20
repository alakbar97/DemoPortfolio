using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabWebFormP212.Models.Classes
{
    public class Picture
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public Project Project { get; set; }
        public int ProjectID { get; set; }
    }
}