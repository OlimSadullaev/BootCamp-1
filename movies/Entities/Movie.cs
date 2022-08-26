using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace movies.Entities
{
    public class Movie
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [MaxLength(255)]
        public string Title { get; set; }
        
        
        
        
    }
}
