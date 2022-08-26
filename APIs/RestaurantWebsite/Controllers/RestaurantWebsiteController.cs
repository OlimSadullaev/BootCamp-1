 using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebsite.Constollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantWebsiteController : ControllerBase
    {
        public static IWebHostEnvironment _environment; 
        public RestaurantWebsiteController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public class FileUPloadAPI
        {
            public IFormFile files { get; set; }
        }

        public async Task<string> Post(FileUPloadAPI objFile)
        {
            await Task.Delay(2000);
            try
            {
                if (objFile.files.Length > 0)
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Upload\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\Upload\\");
                    }

                    using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Upload\\" + objFile.files.FileName))
                    {
                        objFile.files.CopyTo(fileStream);
                        fileStream.Flush();
                        return "\\Upload\\" + objFile.files.FileName;
                    }
                }
                else
                {
                    return "Failed";
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }
    }
}
