using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp.DataLayers.Entities
{
    public class faceComanda
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Comanda")]
        public int ComandaId { get; set; }
        public User user { get; set; }
        public Comanda comanda { get; set; }

    }
}
