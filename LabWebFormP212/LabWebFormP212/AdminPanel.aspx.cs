using LabWebFormP212.Models;
using LabWebFormP212.Models.Classes;
using Microsoft.Security.Application;
using System;
using System.Web;

namespace LabWebFormP212
{
    public partial class AdminPanel : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void ProjectClicked(object sender, EventArgs e)
        {
            var file = Request.Files.GetMultiple("Image2");

            Project project = new Project();
            project.Description = Sanitizer.GetSafeHtmlFragment(Description.InnerHtml); ;
            project.MainImage = MainImage.PostedFile.SaveImage(Server.MapPath("~/Images"));
            project.SiteName = sitename.Value;
            using (MyDbContext dbcontext = new MyDbContext())
            {
                dbcontext.Projects.Add(project);
                dbcontext.SaveChanges();
                foreach (HttpPostedFile item in file)
                {
                    dbcontext.Pictures.Add(new Picture
                    {
                        Name = item.SaveImage(Server.MapPath("~/Images")),
                        ProjectID = project.ID
                    });
                }
                dbcontext.SaveChanges();
            }
        }


    }
}