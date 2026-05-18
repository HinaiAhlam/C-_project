namespace project01.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int Rating { get; set; } 
        public int UserId { get; set; }
        public int MovieId { get; set; }

        public User? User { get; set; }
        public Movie? Movie { get; set; }
    }
}