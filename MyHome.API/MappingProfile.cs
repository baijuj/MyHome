using AutoMapper;
using MyHome.Domain;
using MyHome.Shared.Dtos;

namespace MyHome.API
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Property, PropertyDto>().ReverseMap();
            CreateMap<Property, PropertyListDto>()
                .ForMember(dest => dest.PropertyId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Photos, opt => opt.MapFrom(src => src.Photos.Select(obj => obj.PhotoURL).ToList()))
                .ReverseMap();
            CreateMap<BrochureMap, BrochureMapDto>().ReverseMap();
            CreateMap<CustomData, CustomDataDto>().ReverseMap();
            CreateMap<Location, LocationDto>().ReverseMap();
            CreateMap<Negotiator, NegotiatorDto>().ReverseMap();
            CreateMap<Photo, PhotoDto>().ReverseMap();
            //..add other mappings here
        }
    }
}
