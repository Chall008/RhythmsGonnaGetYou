using System;

namespace RhythmsGonnaGetYou
{
    public class Albums
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsExplicit { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ArtistId { get; set; }
        public Artists Artist { get; set; }
    }
}