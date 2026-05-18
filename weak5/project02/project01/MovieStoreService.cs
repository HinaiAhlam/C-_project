using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using project01.Data;
using project01.Entities;

namespace project01.Services
{
    public class MovieStoreService
    {
        private readonly ApplicationDbContext _context;

        public MovieStoreService()
        {
            _context = new ApplicationDbContext();
        }

        public void AddMovie(Movie movie)
        {
            movie.CreatedAt = DateTime.UtcNow;
            movie.UpdatedAt = DateTime.UtcNow;
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public List<Movie> GetAllMovies()
        {
            return _context.Movies.Include(m => m.Category).ToList();
        }

        public void UpdateMovie(Movie updatedMovie)
        {
            var movie = _context.Movies.Find(updatedMovie.Id);
            if (movie != null)
            {
                movie.Title = updatedMovie.Title;
                movie.Description = updatedMovie.Description;
                movie.ReleaseYear = updatedMovie.ReleaseYear;
                movie.CategoryId = updatedMovie.CategoryId;
                movie.UpdatedAt = DateTime.UtcNow;
                _context.SaveChanges();
            }
        }

        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie != null)
            {
                movie.IsDeleted = true;
                _context.SaveChanges();
            }
        }

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User? GetUserWithWatchlist(int userId)
        {
            return _context.Users
                .Include(u => u.Watchlists)
                .ThenInclude(w => w.Movie)
                .FirstOrDefault(u => u.Id == userId);
        }

        public bool AddMovieToWatchlist(int userId, int movieId)
        {
            bool exists = _context.Watchlists.Any(w => w.UserId == userId && w.MovieId == movieId);
            if (exists) return false;

            _context.Watchlists.Add(new Watchlist { UserId = userId, MovieId = movieId, AddedDate = DateTime.UtcNow });
            _context.SaveChanges();
            return true;
        }

        public void AddReview(Review review)
        {
            _context.Reviews.Add(review);
            _context.SaveChanges();
        }

        public List<Review> GetReviewsPerMovie(int movieId)
        {
            return _context.Reviews
                .Include(r => r.User)
                .Where(r => r.MovieId == movieId)
                .ToList();
        }

        public List<Movie> FilterMoviesByCategory(int categoryId)
        {
            return _context.Movies
                .Include(m => m.Category)
                .Where(m => m.CategoryId == categoryId)
                .ToList();
        }

        public List<Movie> GetTopRatedMovies()
        {
            return _context.Movies
                .Include(m => m.Reviews)
                .Where(m => m.Reviews.Any())
                .OrderByDescending(m => m.Reviews.Average(r => r.Rating))
                .ToList();
        }
    }
}