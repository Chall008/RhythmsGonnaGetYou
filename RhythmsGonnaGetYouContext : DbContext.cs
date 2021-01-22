namespace RhythmsGonnaGetYou
{
    public class RhythmsGonnaGetYouContext : DbContext
    {
        public Dbset<Artist> Artists { get; set; }
        public Dbset<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuidlder.UseNpgsql("server=localhost;database=RhythmsGonnaGetYou");

        }



    }
}