using System;

namespace project01.Entities
{
    public class Watchlist
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.UtcNow;

        public User? User { get; set; }
        public Movie? Movie { get; set; }
    }
}