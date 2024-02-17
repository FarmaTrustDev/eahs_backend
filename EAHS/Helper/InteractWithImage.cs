using Microsoft.AspNetCore.Http;
using System.IO;
using System;
using System.Net.Http.Headers;

namespace EAHS.Helper
{
    public class InteractWithImage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <param name="UploadFolder"></param>
        /// <param name="fileName"> Should be with extension</param>
        /// <returns></returns>
        public static string Upload(IFormFile file, string UploadFolder, string fileName = null)
        {
            string applicationFolder = "wwwroot\\Uploads\\" + UploadFolder.Replace(" ", "-");
            var webRootPath = Path.Combine(Directory.GetCurrentDirectory(), applicationFolder);
            if (!Directory.Exists(webRootPath))
            {
                Directory.CreateDirectory(webRootPath);
            }

            string fileNames = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var FileExtension = Path.GetExtension(fileNames);
            string filename = fileName != null ? fileName : Guid.NewGuid().ToString() + FileExtension;

            filename = $"{filename}";// no need to append (.) dot in extension

            var path = Path.Combine(webRootPath, filename);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return $"Uploads/{UploadFolder}/{filename}";
        }
        public static bool Delete(string path)
        {
            var webRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\");
            var OldFile = webRootPath + path;
            if (File.Exists(OldFile))
            {
                File.Delete(OldFile);
            }
            return true;
        }
    }
}
