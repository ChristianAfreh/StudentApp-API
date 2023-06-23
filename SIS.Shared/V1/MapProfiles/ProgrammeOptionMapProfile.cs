using AutoMapper;
using FeePaymentService;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.MapProfiles
{
    public class ProgrammeOptionMapProfile : Profile
    {
        public ProgrammeOptionMapProfile()
        {
            CreateMap<Programmeoption, ProgrammeOptionGetDTO>();
        }
    }
}
