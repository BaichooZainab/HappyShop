using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;


namespace Hs.Models
{
    public class Testimonial
    {
        [Key]
        public int Id { get; set; }

        [Required]

        [DisplayName("Name")]
        public string Name { get; set; }

        public string ApplicationUserId { get; set; }

        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        [DisplayName("Testimonial")]
        public string Testimonials { get; set; }

        [ValidateNever]
        public string Image { get; set; }

        [DisplayName("Date")]
        public DateTime Date { get; set; } = DateTime.Now;

    }
}
