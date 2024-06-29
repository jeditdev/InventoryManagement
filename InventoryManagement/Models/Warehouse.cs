using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public string Description { get; set; }
        [Display(Name = "Branch")]
        public int BranchId { get; set; }
    }
}
