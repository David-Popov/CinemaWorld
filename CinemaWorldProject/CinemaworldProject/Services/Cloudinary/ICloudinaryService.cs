using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaworldProject.Services.Cloudinary
{
    public interface ICloudinaryService
    {
        public string UploadPhoto(IFormFile file, string folder);
    }
}
