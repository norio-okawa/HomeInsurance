using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeInsurance.Models {

    [NotMapped]
    public class NewUser {
        [Required]
        [IsStringLengthBelow(20)]
        [IsAlphanumeric]
        public string Username { get; set; }

        [Required]
        [IsStringLengthBelow(20)]
        [IsAlphanumeric]
        public string Password { get; set; }

        [Required]
        [IsStringLengthBelow(20)]
        [IsAlphanumeric]
        [IsPasswordSame]
        [Display(Name = "Re-Enter Password")]
        public string ReEnterPassword { get; set; }
    }

    [NotMapped]
    public class LookupUser {
        [Required]
        [IsStringLengthBelow(20)]
        [IsAlphanumeric]
        public string Username { get; set; }
    }
}