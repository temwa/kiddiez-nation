using System.ComponentModel.DataAnnotations;

namespace Nation1.Models
{
    public class Nanny
    {
        [ScaffoldColumn(false)]
        public int NannyID { get; set; }

        [Required, StringLength(100), Display(Name ="Full Name")]
        public string NannyName { get; set; }

        [Required, Display(Name ="Age")]
        public int Age { get; set; }

        [Required, Display(Name ="Years of Experience")]
        public int ExperienceYears { get; set; }

        [Required, StringLength(100), Display(Name ="Part-Time or Full-Time")]
        public string PartorFull { get; set; }

        [Required, StringLength(1000), Display(Name = "Areas")]
        public string Areas { get; set; }

        [Required, StringLength(12), Display(Name ="Phone Number")]
        public string Phone { get; set; }

        [StringLength(50), Display(Name ="Email")]
        public string Email { get; set; }

        [StringLength(1000), Display(Name ="Extra Information")]
        public string Extra { get; set; }
    }
}