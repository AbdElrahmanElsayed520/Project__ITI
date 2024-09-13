using System.ComponentModel.DataAnnotations;

namespace PROJECTITI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [MinLength(20, ErrorMessage = "Description must be more than 20 character")]
        [MaxLength(100, ErrorMessage = "Description be less than 100 character")]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }=new HashSet<Product>();
    }
}
