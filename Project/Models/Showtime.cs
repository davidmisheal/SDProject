namespace Project.Models
{
    public class Showtime
    {
        public int Show_Id { get; set; }
        public DateTime Date { get; set; }
        public int Avaliable_Seats  { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual ICollection<Seat> Seats { get; set; }
    }
}
