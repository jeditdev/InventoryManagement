namespace InventoryManagement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public OrderType OrderType { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ItemDiscount { get; set; }
        public decimal Tax { get; set; }
        public decimal Shipping { get; set; }
        public decimal Total { get; set; }
        public string PromoCode { get; set; }
        public decimal Discount { get; set; }
        public decimal DrandTotal { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

namespace InventoryManagement
{
    public enum OrderType
    {
        Checkout,
        Paid,
        Failed,
        Ship,
        Delivered,
        Return,
        Complete
    }

    public enum OrderStatus
    {
        PurchasedOrder,
        Customer
    }
}