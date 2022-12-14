using Microsoft.EntityFrameworkCore;
using movies.Entities;

namespace movies.Data
{
    public class MoviesContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        
        public MoviesContext(DbContextOptions options)
            :base(options) { }
        
    }
}