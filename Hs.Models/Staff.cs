
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Hs.Models
{
	public class Staff
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[DisplayName("Name")]
		public string Name { get; set; }

		[Required]
		[DisplayName("Street Addrress")]
		public string StreetAddress { get; set; }

		[Required]
		[DisplayName("City")]
		public string City { get; set; }

		
		[DisplayName("State")]
		public string State { get; set; }

        [Required]
        [DisplayName("Email")]
		public string Email { get; set; }

  
        [DisplayName("Password")]
        public string Password { get; set; }


        [DisplayName("Phone Number")]
		public int PhoneNumber { get; set; }

       
    }
}
