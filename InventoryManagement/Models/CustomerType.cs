using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models
{
    public class CustomerType
    {
        public int CustomerTypeId { get; set; }
        [Required]
        public string CustomertypeName { get; set; }
        public string Description { get; set; }
    }
}
