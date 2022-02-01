using CinemaworldProject.Services.Cloudinary;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace cinemaworldproject.services.cloudinary
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly Cloudinary cloudinary;

        public CloudinaryService(Cloudinary cloudinary)
        {
            this.cloudinary = cloudinary;
        }

        public string UploadPhoto(IFormFile file, string folder)
        {
            byte[] fileBytes;
            UploadResult uploadResult = null;

            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                fileBytes = memoryStream.ToArray();
            }

            using (var memoryStream = new MemoryStream(fileBytes))
            {
                ImageUploadParams uploadParams = new ImageUploadParams
                {
                    Folder = folder,
                    File = new FileDescription($"{DateTime.UtcNow} - {file.Name}", memoryStream),
                };

                uploadResult = this.cloudinary.Upload(uploadParams);
            }

            return uploadResult?.SecureUri.AbsoluteUri;
        }
    }
}
