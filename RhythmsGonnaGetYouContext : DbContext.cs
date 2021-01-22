using Microsoft.EntityFrameworkCore;

namespace RhythmsGonnaGetYou
{
    public class RhythmsGonnaGetYouContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuidlder.UseNpgsql("server=localhost;database=RhythmsGonnaGetYou");

        }



    }
}