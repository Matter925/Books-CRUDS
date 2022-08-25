using System.ComponentModel.DataAnnotations;

namespace Books.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }
}
