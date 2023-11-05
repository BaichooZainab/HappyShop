using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace HappyShop.Models
{
    public class login
    {
        [Key]
        public int Id { get; set; }

        [Required]

        [DisplayName("Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please Provide Valid Email")]

        public string email { get; set; }

        [DisplayName("Password")]
        public string pass { get; set; }


    }
}