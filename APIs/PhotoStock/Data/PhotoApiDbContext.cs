using Microsoft.EntityFrameworkCore;
using PhotoStock.Entity;

namespace PhotoStock.Data
{
    public class PhotoApiDbContext : DbContext
    {
        public DbSet<Photo> Photos { get; set; }
        public DbSet<AltText> Texts { get; set; }

        public PhotoApiDbContext (DbContextOptions options)
            : base(options) { }

    }
}
