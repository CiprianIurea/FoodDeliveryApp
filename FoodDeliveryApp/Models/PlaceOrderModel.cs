namespace FoodDeliveryApp.Models
{
    public class PlaceOrderModel
    {
        public string Email { get; set; }
        public List<OrderItemModel> OrderItems { get; set; }
    }
}
