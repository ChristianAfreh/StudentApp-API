using System;
using AutoMapper;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;

namespace SIS.Shared.V1.MapProfiles
{
    public class AssessmentLecturerProfile : Profile
    {
        public AssessmentLecturerProfile()
        {
            CreateMap<procGetLecturersforStudentRegisteredCourses_Result, AssessmentLecturerGetDTO>()
             //.ForMember(dest => dest.Istrail, opt => opt.MapFrom(src => 1))
                .ForMember(dest => dest.LecturerName, opt => opt.MapFrom(src => src.FULLNAME));
        }
    }
}
