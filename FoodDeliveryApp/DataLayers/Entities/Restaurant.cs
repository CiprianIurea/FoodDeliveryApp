using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace FoodDeliveryApp.DataLayers.Entities
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string TipRestaurant { get; set; }
        public ICollection<Produs> produse { get; set; }
        [ForeignKey("Localitate")]
        public int LocalitateId { get; set; }
        public Localitate localitate { get; set; }
    }
}
