using Microsoft.AspNetCore.Mvc;

namespace intro.Controllers{

[Route("")]
    public class BlogsConroller : Controller{

        [HttpGet("blogs")]
        public IActionResult GetBlogs()
        {
            return View();
        }
    }
}