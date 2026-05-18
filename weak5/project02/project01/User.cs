using System.Collections.Generic;

namespace project01.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Watchlist> Watchlists { get; set; } = new List<Watchlist>();
    }
}