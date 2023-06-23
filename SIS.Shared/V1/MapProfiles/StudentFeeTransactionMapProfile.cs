using System;
using AutoMapper;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;

namespace SIS.Shared.V1.MapProfiles
{
    public class StudentFeeTransactionMapProfile : Profile
    {
        public StudentFeeTransactionMapProfile()
        {
            CreateMap<ProcStudentFeeTransactionResult, FeeTransactionGetDTO>()
                .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CURRENCYID))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.AMOUNTSOURCECURRENCY))
                .ForMember(dest => dest.CBalance, opt => opt.MapFrom(src => (decimal)src.CUMULATIVETOTAL))
                .ForMember(dest => dest.ExchangeRate, opt => opt.MapFrom(src => src.XRATE))
                .ForMember(dest => dest.TransType, opt => opt.MapFrom(src => src.TRANSACTIONTYPE))
                .ForMember(dest => dest.AcadLevelId, opt => opt.MapFrom(src => src.ACADLEVELID))
                .ForMember(dest => dest.SemString, opt => opt.MapFrom(src => src.SEMESTER))
                .ForMember(dest => dest.CanPrintReceipt, opt => opt.MapFrom(src => src.OFID == null ? false : true));

        }
    }
}
