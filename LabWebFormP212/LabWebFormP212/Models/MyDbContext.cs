using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LabWebFormP212.Models.Classes;

namespace LabWebFormP212.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("myDb") { }
        public DbSet<Models.About> Infos { get; set; }
        public DbSet<Models.Classes.Contact> Contacts { get; set; }
        public DbSet<Models.Classes.Service> Services { get; set; }
        public DbSet<Models.Classes.Social> Socials { get; set; }
        public DbSet<Models.Classes.Project> Projects { get; set; }
        public DbSet<Models.Classes.Picture> Pictures { get; set; }
    }
}