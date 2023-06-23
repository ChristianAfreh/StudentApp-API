using System;
using AutoMapper;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;

namespace SIS.Shared.V1.MapProfiles
{
    public class ReligionProfile : Profile
    {
        public ReligionProfile()
        {
            CreateMap<Religion, SelectOptionGetDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Religionid))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        }
    }
}
