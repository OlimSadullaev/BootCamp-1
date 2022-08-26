using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mvc.ViewModels
{
    public class NewPostViewModel
    {
        [Required]
        [DisplayName("Sarlavxa")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Tags { get; set; }
        
        [FromForm]
        public IFormFile HeaderImage { get; set; }
        
        
    }
}