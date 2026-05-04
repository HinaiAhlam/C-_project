using System.Collections.Generic;

namespace MovieWebsiteSystem
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        private int _rating;

        public int Rating
        {
            get => _rating;
            set => _rating = (value >= 1 && value <= 10) ? value : 5;
        }

        public Movie(string title, string genre, int year, int rating = 5)
        {
            Title = title;
            Genre = genre;
            Year = year;
            Rating = rating;
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Welcome {Name}!");
        }
    }

    public class Review
    {
        public string UserName { get; set; }
        public string MovieTitle { get; set; }
        public string Comment { get; set; }
        public int Rate { get; set; }

        public Review(string userName, string movieTitle, string comment, int rate)
        {
            UserName = userName;
            MovieTitle = movieTitle;
            Comment = comment;
            Rate = rate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User("ahlam", 32);

            List<Movie> movies = new List<Movie>
            {
                new Movie("Inception", "Sci-Fi", 2010, 9),
                new Movie("Titanic", "Romance", 1997, 8),
                new Movie("Interstellar", "Sci-Fi", 2014, 10)
            };

            Console.WriteLine("\nMovies:");
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Title} - {movie.Rating}");
            }

            List<Review> reviews = new List<Review>();
            Review r1 = new Review(u1.Name, "Inception", "Great movie!", 10);
            reviews.Add(r1);

            Console.WriteLine("\nReviews:");
            foreach (var review in reviews)
            {
                Console.WriteLine($"{review.UserName} rated {review.MovieTitle}: {review.Rate} {review.Comment}");
            }

            Console.ReadKey();
        }
    }
}