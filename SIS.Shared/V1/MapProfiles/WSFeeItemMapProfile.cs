using AutoMapper;
using FeePaymentService;
using SIS.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.MapProfiles
{
    public class WSFeeItemMapProfile : Profile
    {
        public WSFeeItemMapProfile()
        {
            CreateMap<FeeItem, WSFeeItemGetDTO>();
        }
    }
}
