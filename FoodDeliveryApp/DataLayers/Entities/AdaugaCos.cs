using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp.DataLayers.Entities
{
    public class AdaugaCos
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Produs")]
        public int ProdusId { get; set; }
        [ForeignKey("Cos")]
        public int CosId { get; set; }
        public User user { get; set; }
        public Produs produs { get; set; }
        public Cos cos { get; set; }
    }
}
