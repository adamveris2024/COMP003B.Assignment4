using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
    public class ReleaseTrailers
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(300)]
        public string Summary { get; set; }
    }
}
