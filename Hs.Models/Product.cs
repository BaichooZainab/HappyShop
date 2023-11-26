using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;


namespace Hs.Models
{
    public class Product
    {
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }


        [Key]
        public int Id { get; set; }

        [Required]

        [DisplayName("Product Name")]
        public string Productname { get; set; }

        [Required]
        [DisplayName("Product Description")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Quantity on Hand")]
        [Range(1, 1000, ErrorMessage = "Quantity on Hand must be in range of 1 - 1000 only!!")]
        public double Quantities { get; set; }

        [Required]
        [DisplayName("Price")]
        [Range(1, 10000, ErrorMessage = "Price out of range")]
        public double Prices { get; set; }

        [Required]
        [DisplayName("Brand Name")]
        public string Brandname { get; set; }

        [ValidateNever]
        public string ImageUrl { get; set; }

    }
}
