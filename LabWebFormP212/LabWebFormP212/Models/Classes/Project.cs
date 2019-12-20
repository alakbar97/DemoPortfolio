using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabWebFormP212.Models.Classes
{
    public class Project
    {
        public Project()
        {
            Pictures = new HashSet<Picture>();
        }
        public int ID { get; set; }
        [Required]
        public string SiteName { get; set; }
        [Required]
        public string MainImage { get; set; }
        public ICollection<Picture> Pictures { get; set; }
        [Required]
        [AllowHtml]
        public string Description { get; set; }
    }
}