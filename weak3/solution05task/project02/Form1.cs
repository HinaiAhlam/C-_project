using System;
using System.Windows.Forms;

namespace solution05task
{
    public partial class Form1 : Form
    {
        User currentUser;
        Movie currentMovie;

        public Form1()
        {
            InitializeComponent();

            currentUser = new User("Ahlam");
            currentMovie = new Movie("Inception", "Sci-Fi", 9);
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                currentMovie.Title = textBox1.Text;
            }

            string resultMessage = currentUser.WatchMovie(currentMovie);

            listBox1.Items.Add(resultMessage);
            label3.Text = "Watch Count: " + currentUser.WatchCount;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentUser.WatchCount == 0)
            {
                MessageBox.Show("Please watch a movie first before rating!");
                return;
            }

            int ratingValue = (int)numericUpDown1.Value;
            currentUser.RateMovie(currentMovie, ratingValue);

            MessageBox.Show($"Success! {currentMovie.Title} updated to Rating: {currentMovie.Rating}");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


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
                    _rating = value;
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

        public string WatchMovie(Movie movie)
        {
            WatchCount++; 
            return $"{Name} is watching {movie.Title}";
        }

        public void RateMovie(Movie movie, int rate)
        {
            movie.Rating = rate;
        }
    }
}