namespace InventoryManagement.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int AvailQuantity { get; set; }
        public Status Status { get; set; }
    }
}

namespace InventoryManagement
{
    public enum Status
    {
        Ok, 
        Defective
    }
}