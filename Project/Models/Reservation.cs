namespace Project.Models
{
    public class Reservation
    {
        public int Res_Id { get; set; }
        public int User_Id { get; set; }
        public int M_Id { get; set; }
        public int Seat_Id { get; set; }

        public virtual User User { get; set; }
        public virtual Showtime Showtime { get; set; }
        public virtual ICollection<Seat> Seats { get; set; }
    }
}
