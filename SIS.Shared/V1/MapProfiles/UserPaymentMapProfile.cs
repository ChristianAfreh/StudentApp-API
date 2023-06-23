using System;
using AutoMapper;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;

namespace SIS.Shared.V1.MapProfiles
{
    public class UserPaymentMapProfile : Profile
    {
        public UserPaymentMapProfile()
        {
            CreateMap<ViewUserpayment, UserPaymentGetDTO>();
        }
    }
}
