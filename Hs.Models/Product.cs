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

        [DisplayName("Product Description")]
        public string pdesc { get; set; }

        [DisplayName("Quantity on Hand")]
        [Range(1, 100, ErrorMessage = "Quantity on Hand must be in range of 1 - 100 only!!")]
        public int Quantity { get; set; }

        [DisplayName("Price")]
        
        public int price { get; set; }

        [DisplayName("Brand Name")]
        public string brandname { get; set; }

        [DisplayName("Created Date & Time")]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
