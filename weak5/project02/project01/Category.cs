using System.Collections.Generic;

namespace project01.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}