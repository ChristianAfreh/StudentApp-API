using System;
using AutoMapper;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;

namespace SIS.Shared.V1.MapProfiles
{
    public class DenominationProfile : Profile
    {
        public DenominationProfile()
        {
            CreateMap<Denomination, SelectOptionGetDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Denominationid))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        }
    }
}
