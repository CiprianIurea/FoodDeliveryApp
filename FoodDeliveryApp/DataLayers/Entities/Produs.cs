using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace FoodDeliveryApp.DataLayers.Entities
{
    public class Produs
    {
        [Key]
        public int ProdusId { get; set; }
        [NotNull]
        public float Pret { get; set; }
        [NotNull]
        public string Denumire { get; set; }
        public int Cantitate { get; set; }
        public string Ingrediente { get; set; }
        public ICollection<AdaugaCos> _adaugaCos { get; set; }
        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        public Restaurant restaurant { get; set; }
    }
}
