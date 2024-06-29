using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
