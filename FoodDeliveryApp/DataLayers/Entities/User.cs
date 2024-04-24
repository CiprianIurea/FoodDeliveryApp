using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FoodDeliveryApp.DataLayers.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [NotNull]
        public string Nume { get; set; }
        [MaxLength(10)]
        public string Telefon { get; set; }
        [NotNull]
        public string Adresa { get; set; }
        [NotNull]
        public string Email { get; set; }
        public ICollection<faceComanda> _faceComanda { get; set; }
        public ICollection<AdaugaCos> _adaugaCos { get; set; }

    }
}
