using Microsoft.AspNetCore.Mvc;

namespace webApi.Controllers
{
   
        [Route("api/[controller]")]
        [ApiController]
        public class ImagesController : ControllerBase
        {
            [HttpPost]
            [Route("image")]
            public async Task<IActionResult> UploadImage(IFormFile file)
            {
                if (file == null || file.Length == 0)
                    return BadRequest("No file uploaded");

                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "Images");
                if (!Directory.Exists(uploadsFolder))
                    Directory.CreateDirectory(uploadsFolder);

                var filePath = Path.Combine(uploadsFolder, file.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                // מחזיר את ה-URL לצפייה בתמונה
                return Ok(new { imageUrl =file.FileName });
            }
        }


    }

