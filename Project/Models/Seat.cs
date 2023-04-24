namespace Project.Models
{
    public class Seat
    {
        public int Seat_Id { get; set; }
        public int Seat_Num { get; set; }
        public int Seat_Row { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
