using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Threading.Tasks;
namespace WebDooreme.Helpers
{
    public static class ImageHelper
    {
        private static IWebHostEnvironment _hostingEnvironment;
        public static IWebHostEnvironment GetWebHostEnvironment()
        {
            var _accessor = new HttpContextAccessor();
            return _accessor.HttpContext.RequestServices.GetRequiredService<IWebHostEnvironment>();
        }
        public static async Task<string> GetUploadImageName(IFormFile imageFile, ImagePaths imagePaths)
        {
            var pathName = ImagePathFactory.GetImagePathName(imagePaths);
            _hostingEnvironment = GetWebHostEnvironment();
            string imageName = "";
            string wwwRootPath = _hostingEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(imageFile.FileName);
            string extension = Path.GetExtension(imageFile.FileName);
            imageName = fileName = fileName + "-" + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/" + pathName + "/", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }
            return imageName;
        }
    }
}