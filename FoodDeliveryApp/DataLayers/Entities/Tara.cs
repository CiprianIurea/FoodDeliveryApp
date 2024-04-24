using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FoodDeliveryApp.DataLayers.Entities
{
    public class Tara
    {
        [Key]
        public int TaraId { get; set; }
        [NotNull]
        public string Denumire { get; set; }
        public ICollection<Localitate> localitati { get; set; }
    }
}
