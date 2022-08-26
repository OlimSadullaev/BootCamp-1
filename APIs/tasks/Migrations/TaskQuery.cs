using System;
using Microsoft.AspNetCore.Mvc;

namespace tasks.Migrations
{
    public class TaskQuery
    {
        [FromQuery]
        public string Title { get; set; }

        [FromQuery]
        public string Id { get; set; }
        
        [FromQuery]
        public string Priority { get; set; }
        
        [FromQuery]
        public string Status { get; set; }
        
        
        
        
    }
}