using AutoMapper;
using FoodDeliveryApp.DataLayers;
using FoodDeliveryApp.DataLayers.Entities;
using FoodDeliveryApp.DTOs;

namespace FoodDeliveryApp.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Comanda, ComandaDTO>().ReverseMap();
            CreateMap<Cos, CosDTO>().ReverseMap();
            CreateMap<Livrator, LivratorDTO>().ReverseMap();
            CreateMap<Produs, ProdusDTO>().ReverseMap();
            CreateMap<AdaugaCos, PuneInCosDTO>().ReverseMap();
            CreateMap<Restaurant, RestaurantDTO>().ReverseMap();
            CreateMap<User, UtilizatorDTO>().ReverseMap();
        }
    }
}
