namespace FoodDeliveryApp.Models
{
    public class AddToCartModel
    {
        public string Email { get; set; }
        public int MenuItemId { get; set; }
        public int Quantity { get; set; }
    }
}
