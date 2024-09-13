using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PROJECTITI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is Required.")]
        [EmailAddress]
        [DisplayName("User Email")]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
