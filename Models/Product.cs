using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
    public class Product
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
