using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace FoodDeliveryApp.DataLayers.Entities
{
    public class Livrator
    {
        [Key]
        public int LivratorId { get; set; }
        [NotNull]
        [MaxLength(8)]
        public string SerieNumarCI { get; set; }
        [NotNull]
        public string Nume { get; set; }
        public ICollection<Comanda> comenzi { get; set; }
    }
}
