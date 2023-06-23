using System;
using AutoMapper;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;

namespace SIS.Shared.V1.MapProfiles
{
    public class StudentSemesterMapProfile : Profile
    {
        public StudentSemesterMapProfile()
        {
            CreateMap<Studentsemester, StudentSemesterGetDTO>();

                  //.ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"Year {src.Acadlevelid}, {src.Sem} Semester"))
                  //.ForMember(dest => dest.SemString, opt => opt.MapFrom(src => $"{src.Sem} Semester"))
                  //  .ForMember(dest => dest.AcadYearString, opt => opt.MapFrom(src => $"{src.Acadyear-1}/{src.Acadyear}"));
        }
    }
}
