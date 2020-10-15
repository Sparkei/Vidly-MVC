using Microsoft.EntityFrameworkCore;
using Vidly.Models;

namespace Vidly.Data
{
    public class VidlyMovieContext : DbContext
    {
        public VidlyMovieContext(DbContextOptions<VidlyMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //  modelBuilder.Seed();
        // }
    }
}
