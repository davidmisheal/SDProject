namespace Project.Models
{
    public class Movie
    {
        public int Movie_Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }  
        public string Genre { get; set; }
        public string Rating { get; set; }
        public virtual ICollection<Showtime> Showtimes { get; set; }
    }
}
