using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Hs.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]

        [DisplayName("Product Name")]
        public string pname { get; set; }

        [Required]
        [DisplayName("Product Description")]
        public string pdesc { get; set; }

        [Required]
        [DisplayName("Quantity on Hand")]
        [Range(1, 100, ErrorMessage = "Quantity on Hand must be in range of 1 - 100 only!!")]
        public int Quantity { get; set; }

        [Required]
        [DisplayName("Price")]
        [Range(1, 10000, ErrorMessage = "Price out of range")]
        public int price { get; set; }

        [Required]
        [DisplayName("Brand Name")]
        public string brandname { get; set; }

    }
}
