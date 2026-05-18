using System;
using System.Collections.Generic;
using System.Linq;
using project01.Data;
using project01.Entities;
using project01.Services;

namespace project01
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieStoreService service = new MovieStoreService();

            Console.WriteLine("--- Setting up Automatic Database ---");
            using (var db = new ApplicationDbContext())
            {
                db.Database.EnsureCreated();

                if (!db.Categories.Any())
                {
                    db.Categories.Add(new Category { Name = "Action" });
                    db.Categories.Add(new Category { Name = "Sci-Fi" });
                    db.Categories.Add(new Category { Name = "Drama" });
                    db.SaveChanges();
                    Console.WriteLine("--> Base categories initialized successfully!\n");
                }
            }

            Console.WriteLine("--- Processing Rich Demo Data ---");
            using (var db = new ApplicationDbContext())
            {
                if (!db.Users.Any())
                {
                    Console.WriteLine("--> Seeding 10 users...");
                    var usersList = new List<User>
                    {
                        new User { Name = "Mona", Email = "mona@example.com" },
                        new User { Name = "Ahmed", Email = "ahmed@example.com" },
                        new User { Name = "Fatma", Email = "fatma@example.com" },
                        new User { Name = "Ali", Email = "ali@example.com" },
                        new User { Name = "Omer", Email = "omer@example.com" },
                        new User { Name = "Sara", Email = "sara@example.com" },
                        new User { Name = "Sultan", Email = "sultan@example.com" },
                        new User { Name = "Aisha", Email = "aisha@example.com" },
                        new User { Name = "Hamed", Email = "hamed@example.com" },
                        new User { Name = "Khadija", Email = "khadija@example.com" }
                    };
                    db.Users.AddRange(usersList);
                    db.SaveChanges();
                }

                if (!db.Movies.Any())
                {
                    Console.WriteLine("--> Seeding multiple movies across categories...");
                    var actionId = db.Categories.FirstOrDefault(c => c.Name == "Action")?.Id ?? 1;
                    var sciFiId = db.Categories.FirstOrDefault(c => c.Name == "Sci-Fi")?.Id ?? 2;
                    var dramaId = db.Categories.FirstOrDefault(c => c.Name == "Drama")?.Id ?? 3;

                    var moviesList = new List<Movie>
                    {
                        new Movie { Title = "Inception", Description = "Dream-sharing tech thief.", ReleaseYear = 2010, CategoryId = sciFiId },
                        new Movie { Title = "Interstellar", Description = "A team of explorers travel through a wormhole.", ReleaseYear = 2014, CategoryId = sciFiId },
                        new Movie { Title = "The Dark Knight", Description = "Batman fights Joker in Gotham.", ReleaseYear = 2008, CategoryId = actionId },
                        new Movie { Title = "Gladiator", Description = "A former Roman General sets out to exact vengeance.", ReleaseYear = 2000, CategoryId = actionId },
                        new Movie { Title = "The Prestige", Description = "Two stage magicians engage in competitive battle.", ReleaseYear = 2006, CategoryId = dramaId },
                        new Movie { Title = "The Godfather", Description = "The aging patriarch of an organized crime dynasty transfers control.", ReleaseYear = 1972, CategoryId = dramaId }
                    };
                    db.Movies.AddRange(moviesList);
                    db.SaveChanges();
                }

                if (!db.Watchlists.Any() && !db.Reviews.Any())
                {
                    Console.WriteLine("--> Generating realistic Watchlists and Reviews for all 10 users...");
                    var allUsers = db.Users.ToList();
                    var allMovies = db.Movies.ToList();

                    if (allUsers.Count >= 10 && allMovies.Count >= 6)
                    {
                        for (int i = 0; i < allUsers.Count; i++)
                        {
                            var user = allUsers[i];

                            var firstMovie = allMovies[i % allMovies.Count];
                            var secondMovie = allMovies[(i + 2) % allMovies.Count];

                            db.Watchlists.Add(new Watchlist { UserId = user.Id, MovieId = firstMovie.Id, AddedDate = DateTime.UtcNow.AddDays(-i) });
                            db.Watchlists.Add(new Watchlist { UserId = user.Id, MovieId = secondMovie.Id, AddedDate = DateTime.UtcNow.AddDays(-i) });

                            int rating = (i % 2 == 0) ? 5 : 4; 
                            string comment = rating == 5 ? "Absolutely amazing movie!" : "Very good, highly recommended.";

                            db.Reviews.Add(new Review { Comment = comment, Rating = rating, UserId = user.Id, MovieId = firstMovie.Id });
                        }
                        db.SaveChanges();
                        Console.WriteLine("--> Database is now fully populated and perfectly matched!\n");
                    }
                }
            }

            // =========================================================================
            // DISPLAYING OUTPUT BASED ON TASK REQUIREMENTS
            // =========================================================================

            Console.WriteLine("==================================================");
            Console.WriteLine("         MOVIE STREAMING MANAGEMENT SYSTEM        ");
            Console.WriteLine("==================================================");

            Console.WriteLine("\n[Requirement 1: All Available Movies in System]");
            var allMoviesInSystem = service.GetAllMovies();
            foreach (var m in allMoviesInSystem)
            {
                Console.WriteLine($"* Movie: {m.Title,-17} | Year: {m.ReleaseYear} | Category: {m.Category?.Name}");
            }

            Console.WriteLine("\n[Requirement 2: Sample User Profiles & Watchlists]");
            using (var db = new ApplicationDbContext())
            {
                var sampleUsers = db.Users.Take(2).ToList(); 
                foreach (var user in sampleUsers)
                {
                    var userWithWatchlist = service.GetUserWithWatchlist(user.Id);
                    Console.WriteLine($"\nUser: {userWithWatchlist?.Name} ({userWithWatchlist?.Email})");
                    Console.WriteLine("Saved Watchlist Items:");
                    foreach (var item in userWithWatchlist?.Watchlists ?? Enumerable.Empty<Watchlist>())
                    {
                        Console.WriteLine($"  - {item.Movie?.Title} (Added on: {item.AddedDate.ToShortDateString()})");
                    }
                }
            }

            Console.WriteLine("\n[Requirement 3: Movie Reviews & Feedback]");
            var targetMovie = allMoviesInSystem.FirstOrDefault(m => m.Title == "Inception");
            if (targetMovie != null)
            {
                Console.WriteLine($"Reviews for '{targetMovie.Title}':");
                var reviews = service.GetReviewsPerMovie(targetMovie.Id);
                foreach (var r in reviews)
                {
                    Console.WriteLine($"  - [{r.Rating}/5 Stars] {r.User?.Name}: \"{r.Comment}\"");
                }
            }

            Console.WriteLine("\n[Bonus Feature: Filtered Movies (Category: Sci-Fi)]");
            var sciFiMovies = service.FilterMoviesByCategory(2);
            foreach (var m in sciFiMovies)
            {
                Console.WriteLine($"  - {m.Title} ({m.ReleaseYear}) - Created At: {m.CreatedAt.ToLocalTime()}");
            }

            Console.WriteLine("\n==================================================");
            Console.WriteLine("--- All core operations printed out perfectly! ---");
            Console.ReadLine();
        }
    }
}