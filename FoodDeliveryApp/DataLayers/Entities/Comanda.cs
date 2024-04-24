using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp.DataLayers.Entities
{
    public class Comanda
    {
        [Key]
        public int ComandaId { get; set; }
        public ICollection<faceComanda> _faceComanda { get; set; }
        [ForeignKey("Cos")]
        public int CosId { get; set; }
        public Cos cos { get; set; }
        [ForeignKey("Livrator")]
        public int LivratorId { get; set; }
        public Livrator livrator { get; set; }
        [ForeignKey("Plata")]
        public int PlataId { get; set; }
        public Plata plata { get; set; }
    }
}
