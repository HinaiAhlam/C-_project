
namespace MiniNetflixSystem
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        private int _rating;

        public int Rating
        {
            get { return _rating; }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    _rating = value;
                }
                else
                {
                    Console.WriteLine("Invalid rating. Must be between 1 and 10.");
                }
            }
        }

        public Movie(string title, string genre, int rating)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int WatchCount { get; private set; }

        public User(string name)
        {
            Name = name;
            WatchCount = 0;
        }

        public void WatchMovie(Movie movie)
        {
            WatchCount++;
            Console.WriteLine($"{Name} is watching {movie.Title}");
        }

        public void RateMovie(Movie movie, int rate)
        {
            if (rate >= 1 && rate <= 10)
            {
                movie.Rating = rate;
                Console.WriteLine($"{Name} rated {movie.Title} as {rate}");
            }
            else
            {
                Console.WriteLine("Error: Rating must be between 1 and 10.");
            }
        }
    }

    public class WatchSession
    {
        public string UserName { get; set; }
        public string MovieTitle { get; set; }

        public WatchSession(string userName, string movieTitle)
        {
            UserName = userName;
            MovieTitle = movieTitle;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie("Inception", "Sci-Fi", 9);
            User u1 = new User("Ali");

            u1.WatchMovie(m1);
            u1.RateMovie(m1, 10);

            Console.WriteLine("\n--- Status ---");
            Console.WriteLine($"User: {u1.Name}, Movies Watched: {u1.WatchCount}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}