namespace FoodDeliveryApp.DTOs
{
    public class CosDTO
    {
        public int IdCos { get; set; }
        public float PretTotal { get; set; }
        public ICollection<PuneInCosDTO> PuneInCos { get; set; }
    }
}
