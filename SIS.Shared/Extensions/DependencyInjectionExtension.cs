using FeePaymentService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SIS.Shared.Entities.SISContext;
using SIS.Shared.V1.MapProfiles;
using SIS.Shared.V1.Repositories;
using SIS.Shared.V1.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IAcademicRecordService, AcademicRecordService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IFeeService, FeeService>();
            services.AddScoped<FunctionsService>();
            services.AddScoped<VirtualGraduationValidator>();
            services.AddScoped<ILecturerService, LecturerService>();
            services.AddScoped<ILecturerAssessmentService, LecturerAssessmentService>();
            //services.AddScoped<IPaymentService, PaymentServiceClient>();
            services.AddScoped<PaymentServiceClient>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<IRSSFeedService, RSSFeedService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ISelectOptionService, SelectOptionService>();
            services.AddScoped<ITimetableService, TimetableService>();
            services.AddScoped<ReportGenerator>();
        }

        public static void RegisterUnitsOfWork(this IServiceCollection services)
        {
            
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAcademicRecordRepository, AcademicRecordRepository>();
            services.AddScoped<IAcademicRecordOnlineRepository, AcademicRecordOnlineRepository>();
            services.AddScoped<IAssessmentCommentRepository, AssessmentCommentRepository>();
            services.AddScoped<IAssessmentResponseRepository, AssessmentResponseRepository>();
            services.AddScoped<IAssessmentResponseValueRepository, AssessmentResponseValueRepository>();
            services.AddScoped<IAssessmentQuestionRepository, AssessmentQuestionRepository>();
            services.AddScoped<IAssessmentStudentLogRepository, AssessmentStudentLogRepository>();
            services.AddScoped<IDenominationRepository, DenominationRepository>();
            services.AddScoped<IBankRepository, BankRepository>();
            services.AddScoped<IUserPaymentRepository, UserPaymentRepository>();
            services.AddScoped<ILecturerRepository, LecturerRepository>();
            services.AddScoped<ILecturerPhotoRepository, LecturerPhotoRepository>();
            services.AddScoped<ILecturerAssessmentRepository, LecturerAssessmentRepository>();
            services.AddScoped<IProgrammeOptionRepository, ProgrammeOptionRepository>();
            services.AddScoped<IProgrammeSemesterRepository, ProgrammeSemesterRepository>();
            services.AddScoped<IProgrammeStreamRepository, ProgrammeStreamRepository>();
            services.AddScoped<IRegionRepository, RegionRepository>();
            services.AddScoped<IReligionRepository, ReligionRepository>();
            services.AddScoped<IStudentBillRepository, StudentBillRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IStudentPhotoRepository, StudentPhotoRepository>();
            services.AddScoped<IStudentProgrammeRepository, StudentProgrammeRepository>();
            services.AddScoped<IStudentFeeTransactionRepository, StudentFeeTransactionRepository>();
            services.AddScoped<IStudentSemesterRepository, StudentSemesterRepository>();
            services.AddScoped<IViewCourseRepository, ViewCourseRepository>();
            services.AddScoped<IMasterCourseRepository,MasterCourseRepository>();
            services.AddScoped<IGraduateRepository, GraduateRepository>();
            services.AddScoped<IAluminiDetailsRepository, AluminiDetailsRepository>();
            services.AddScoped<IViewGraduateRepository, ViewGraduateRepository>();
            services.AddScoped<ISelectStudentSemesterProgrammeRepository, SelectStudentSemesterProgrammeRepository>();
            services.AddScoped<ICampusRepository, CampusRepository>();
            services.AddScoped<IConnectedDevicesRespository, ConnectedDevicesRespository>();
            services.AddScoped<IViewupdateacademicrecordonlineRepository, ViewupdateacademicrecordonlineRepository>();
            services.AddScoped<IViewacademicrecordonlineregRepository, ViewacademicrecordonlineregRepository>();
            services.AddScoped<ITranSwiftApplicantRepository, TranSwiftApplicantRepository>();
            services.AddScoped<ITranSwiftStudentUserRepository, TranSwiftStudentUserRepository>();
            services.AddScoped<ITranSwiftAspNetUserRepository, TranSwiftAspNetUserRepository>();
            services.AddScoped<IViewStudentphotoRepository, ViewStudentphotoRepository>();

        }


        public static void RegisterConnections<T>(this IServiceCollection services, string connection, string migrationsAssembly) where T : DbContext
        {
            services.AddDbContext<T>(options => options.UseSqlServer(connection, builder => builder.MigrationsAssembly(migrationsAssembly)));
        }

        public static void RegisterAutoMapProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AcademicRecordDetailMapProfile));
            services.AddAutoMapper(typeof(DenominationProfile));
            services.AddAutoMapper(typeof(UserPaymentMapProfile));
            services.AddAutoMapper(typeof(ProgrammeOptionMapProfile));
            services.AddAutoMapper(typeof(RegionProfile));
            services.AddAutoMapper(typeof(ReligionProfile));
            services.AddAutoMapper(typeof(StudentSemesterMapProfile));
            services.AddAutoMapper(typeof(StudentFeeTransactionMapProfile));
            services.AddAutoMapper(typeof(WSFeeItemMapProfile));
            services.AddAutoMapper(typeof(AssessmentLecturerProfile));
        }

        //public static void RegisterAppSettings(this IServiceCollection services, IConfiguration Configuration)
        //{
        //    services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
        //    services.Configure<ReportServerSettings>(Configuration.GetSection("ReportServerSettings"));
        //    services.Configure<PaymentSettings>(Configuration.GetSection("PaymentSettings"));
        //    services.Configure<RegistrationSettings>(Configuration.GetSection("RegistrationSettings"));
        //}
        /// <summary>
        /// Calls the database initialization function
        /// </summary>
        /// <param name="_context"></param>
        public static void InitializeDatabase()
        {
            //AppInitializerExtentions.InitializeDatabases().Wait();
        }
    }
}
