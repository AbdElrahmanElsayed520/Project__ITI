using System.ComponentModel.DataAnnotations;

namespace PROJECTITI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [MinLength(20, ErrorMessage = "Description must be more than 8 character")]
        [MaxLength(100, ErrorMessage = "Description be less than 20 character")]
        public string Description { get; set; }
        [Range(50, 1000, ErrorMessage = "Quantity must be between 50 and 1000.")]
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}
