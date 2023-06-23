using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;
using SIS.Shared.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using SIS.Shared.Entities.AssessmentContext;

namespace SIS.Shared.V1.Repositories
{
    public interface IStudentRepository : IBaseRepository<Student>
    {
        Task<StudentDetail> GetStudentDetailsAsync(string studentId);
        Task<List<procGetLecturersforStudentRegisteredCourses_Result>> GetLecturersforStudentRegisteredCourses(string studentId, int programmeStreamId, int acadYear, int sem, int optionId, int acadLevelId);
        public Task<GraduationPaymentViewModel> GetStudentGraduationPayment(string studentId);

    }

    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(SISContext DbContext) : base(DbContext)
        {
        }

        public async Task<StudentDetail> GetStudentDetailsAsync(string studentId)
        {
            return (await _appContext.LoadStoredProc("procGetStudentDetails2")
                .WithSqlParam("STUDENTID", studentId)
                .ExecuteStoredProcAsync<StudentDetail>()).FirstOrDefault();
        }

        public async Task<List<procGetLecturersforStudentRegisteredCourses_Result>> GetLecturersforStudentRegisteredCourses(string studentId, int programmeStreamId, int acadYear, int sem, int optionId, int acadLevelId)
        {
            return (await _appContext.LoadStoredProc("procGetLecturersforStudentRegisteredCourses")
                        .WithSqlParam("STUDENTID", studentId)
                        .WithSqlParam("PROGRAMMESTREAMID", programmeStreamId)
                        .WithSqlParam("ACADYEAR", acadYear)
                        .WithSqlParam("SEM", sem)
                        .WithSqlParam("OPTIONID", optionId)
                        .WithSqlParam("ACADLEVELID", acadLevelId)
                .ExecuteStoredProcAsync<procGetLecturersforStudentRegisteredCourses_Result>()).ToList();
        }

        public async Task<GraduationPaymentViewModel> GetStudentGraduationPayment(string studentId)
        {
            var res = await _appContext.Database.ExecuteSqlRawAsync("Exec procGraduationPayment @studentId", studentId);
            return (await _appContext.LoadStoredProc("procGraduationPayment")
                       .WithSqlParam("STUDENTID", studentId)
                       .ExecuteStoredProcAsync<GraduationPaymentViewModel>()).FirstOrDefault();
        }
    }
}
