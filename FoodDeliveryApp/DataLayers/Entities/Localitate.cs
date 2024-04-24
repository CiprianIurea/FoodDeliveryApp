using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp.DataLayers.Entities
{
    public class Localitate
    {
        [Key]
        public int LocalitateId { get; set; }
        public string Denumire { get; set; }
        public ICollection<Restaurant> restaurante { get; set; }
        [ForeignKey("Tara")]
        public int TaraId { get; set; }
        public Tara tara { get; set; }
    }
}
