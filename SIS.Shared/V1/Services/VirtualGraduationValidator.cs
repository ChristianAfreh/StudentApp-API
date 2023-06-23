using FeePaymentService;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;
using SIS.Shared.Extensions;
using SIS.Shared.Settings;
using SIS.Shared.V1.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Services
{
    public class VirtualGraduationValidator
    {
        private readonly SISContext dbContext;
        private readonly FunctionsService functionsService;
        private readonly IStudentRepository studentRepository;
        private readonly IConfiguration configuration;

        public VirtualGraduationValidator(SISContext dbContext,
            FunctionsService functionsService, IStudentRepository studentRepository,
            IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.functionsService = functionsService;
            this.studentRepository = studentRepository;
            this.configuration = configuration;
        }
        public async Task<decimal> GetStudentFeeBalance(string studentid)
        {
            var student = dbContext.Students.Where(x => x.Studentid == studentid).FirstOrDefault();
            decimal studentFeeBalance = await functionsService.GetStudentTotalBalance(studentid, (int)student.Programmestreamid);
            return studentFeeBalance;
        }

        public async Task<GraduationPaymentViewModel> GetStudentGraduationPayment(string studentId)
        {
            var grad =(await dbContext.LoadStoredProc("procGraduationPayment")
                        .WithSqlParam("STUDENTID", studentId)
                        .ExecuteStoredProcAsync<GraduationPaymentViewModel>()).FirstOrDefault();
            return grad;
        }

        public async Task<bool> CanRegister(string studentid)
        {
            bool canRegister = false;
            var virtualGraduationSettings = configuration.GetSection("VirtualGraduationSettings").Get<VirtualGraduationSettings>();

            if (virtualGraduationSettings.CheckFeesForVirtualGraduation.Equals("true"))
            {
                var balance = await GetStudentFeeBalance(studentid);
                //var graduationPaymentRecord = GetStudentGraduationPaymentRecord(studentid);

                //if (balance >= 0 && graduationPaymentRecord != null)
                //{
                //    canRegister = true;
                //}

                var graduationPayment = await GetStudentGraduationPayment(studentid);
                if (balance >= 0 && graduationPayment.IsPaid == true)
                {
                    canRegister = true;
                }
            }
            else
            {
                canRegister = true;
            }

            return canRegister;
        }



    }

}
