using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp.DataLayers.Entities
{
    public class Cos
    {
        [Key]
        public int CosId { get; set; }
        public float PretTotal { get; set; }
        public ICollection<AdaugaCos> _adaugaCos { get; set; }
        [ForeignKey("Comanda")]
        public int ComandaId { get; set; }
        public Comanda comanda { get; set; }
    }
}
