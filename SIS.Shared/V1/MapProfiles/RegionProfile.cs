using System;
using AutoMapper;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;

namespace SIS.Shared.V1.MapProfiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile()
        {
            CreateMap<Region, SelectOptionGetDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Regionid))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        }
    }
}
