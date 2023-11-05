using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace HappyShop.Models
{
    public class register
    {
        [Key]
        public int Id { get; set; }

        [Required]

        [DisplayName("First Name")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "First Name Should be min 5 and max 20 length")]
        public string fname { get; set; }

        [DisplayName("Last Name")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Last Name Should be min 5 and max 20 length")]
        public string lname { get; set; }

        [DisplayName("Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please Provide Valid Email")]
        public string email { get; set; }

        [DisplayName("Phone Number")]
        public string number { get; set; }

        [DisplayName("Username")]
        public string uname { get; set; }

        [DisplayName("Password")]
        public string pass { get; set; }


        [DisplayName("Created Date & Time")]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}