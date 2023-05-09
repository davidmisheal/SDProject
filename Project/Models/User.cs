using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$", ErrorMessage = "not valid email")]
        public string Email { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9]$", ErrorMessage = "not valid password")]
        public string Password { get; set; }
        public string Phone_NUmber { get; set; }
        public int AdminID { get; set; }

        [ForeignKey("AdminID")]
        public  Admin? Admin { get; set; }


        public virtual ICollection<Reservation>? Reservations { get; set; }
    }
}
