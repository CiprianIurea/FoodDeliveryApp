using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace FoodDeliveryApp.DataLayers.Entities
{
    public class BonFiscal
    {
        [Key]
        public int BonId { get; set; }
        [NotNull]
        public int Cod { get; set; }
        public DateTime DataTranzactie { get; set; }
        [ForeignKey("Plata")]
        public int PlataId { get; set; }
        public Plata plata { get; set; }
    }
}
