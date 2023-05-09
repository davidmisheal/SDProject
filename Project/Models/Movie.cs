using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Movie
    {
        [Key]
        public int Movie_Id { get; set; }
        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Duration is Required")]
        public int Duration { get; set; }
        [Required(ErrorMessage = "Date is Required")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Rating is Required")]
        public string Rating { get; set; }

        [ForeignKey("AdminID")]
        public Admin? Admin { get; set; }

   

        [ForeignKey("HallID")]
        public Hall? Hall { get; set; }

        [ForeignKey("GenreID")]
        public Genre? Genre { get; set; }
        public virtual ICollection<Genre>? Genres { get; set; }
    }
}
