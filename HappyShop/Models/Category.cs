using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace HappyShop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]

        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display order must be in range of 1 - 100 only!!")]
        public int DisplayOrder { get; set; }

        [DisplayName("Created Date & Time")]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
