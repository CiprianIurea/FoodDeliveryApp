namespace FoodDeliveryApp.Models
{
    public class OrderItemModel
    {
        public int MenuItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
