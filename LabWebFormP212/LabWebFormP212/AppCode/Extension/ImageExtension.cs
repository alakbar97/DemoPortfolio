using System;
using System.IO;
using System.Web;

namespace LabWebFormP212
{
    public static class ImageExtension
    {
        public static string SaveImage(this HttpPostedFile file, string folder)
        {
            if (file == null)
                throw new NullReferenceException("file cant be null");
            string imageName = Guid.NewGuid().ToString().Replace("-", "").ToLower() + Path.GetExtension(file.FileName);
            file.SaveAs(Path.Combine(folder, imageName));
            return imageName;
        }
    }
}