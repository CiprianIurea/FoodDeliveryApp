using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp.DataLayers.Entities
{
    public class Plata
    {
        [Key]
        public int PlataId { get; set; }
        public string MetodaPlata { get; set; }
        [ForeignKey("Comanda")]
        public int ComandaId { get; set; }
        public Comanda comanda { get; set; }
        [ForeignKey("BonFiscal")]
        public int BonId { get; set; }
        public BonFiscal bon { get; set; }
    }
}
