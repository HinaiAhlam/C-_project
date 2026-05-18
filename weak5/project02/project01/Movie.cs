using System;
using System.Collections.Generic;

namespace project01.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public int CategoryId { get; set; }

        public Category? Category { get; set; }
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Watchlist> Watchlists { get; set; } = new List<Watchlist>();

        // Bonus Features: Timestamps & Soft Delete
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
    }
}