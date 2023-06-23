using System;
using AutoMapper;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;

namespace SIS.Shared.V1.MapProfiles
{
    public class AcademicRecordDetailMapProfile : Profile
    {
        public AcademicRecordDetailMapProfile()
        {
            CreateMap<Academicrecord, AcademicRecordDetailGetDTO>();
            CreateMap<AcademicRecordAddDTO, Academicrecordonline>()
                .ForMember(dest => dest.Istrail, opt => opt.MapFrom(src => 1))
                .ForMember(dest => dest.Iscalc, opt => opt.MapFrom(src => 0));
        }
    }
}
