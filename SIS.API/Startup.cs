using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SIS.API.Middlewares;
using SIS.API.Swagger;
using SIS.Shared;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.AssessmentContext;
using SIS.Shared.Entities.SISContext;
using SIS.Shared.Extensions;
using SIS.Shared.Settings;
using Swashbuckle.AspNetCore.SwaggerGen;


namespace SIS.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddApiVersioning(options =>
            {
                options.ReportApiVersions = true;
                options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
            });

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });

            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlFilePath = Path.Combine(AppContext.BaseDirectory, xmlFile);

            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, SwaggerConfigureOptions>();
            services.AddSwaggerGen(options =>
            {
                options.IncludeXmlComments(xmlFilePath);
            });

            services.AddAuthentication("Bearer")
            .AddJwtBearer("Bearer", options =>
            {
                options.Authority = "https://login.knust.edu.gh";
                //options.Sc
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false
                };
            });

            services.RegisterServices();
            services.RegisterRepositories();
            services.RegisterUnitsOfWork();
            services.RegisterAutoMapProfiles();
            //services.RegisterAppSettings(Configuration);

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.Configure<MobileAppSettingDTO>(Configuration.GetSection("MobileAppSettings"));            
            services.Configure<ReportServerSettings>(Configuration.GetSection("ReportServerSettings"));
            services.Configure<PaymentSettings>(Configuration.GetSection("PaymentSettings"));
            services.Configure<RegistrationSettings>(Configuration.GetSection("RegistrationSettings"));
            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));

            services.RegisterConnections<SISContext>(
            Configuration.GetConnectionString("SISConnection"), GetType().Assembly.FullName);

            services.RegisterConnections<AssessmentContext>(
            Configuration.GetConnectionString("AssessmentConnection"), GetType().Assembly.FullName);




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider apiVersionDescriptionProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseSwagger();
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SIS.API v1"));
            }

            app.UseSwagger(options =>
            {
                options.PreSerializeFilters.Add((swagger, req) =>
                {
                    swagger.Servers = new List<OpenApiServer>() { new OpenApiServer() { Url = $"https://{req.Host}" } };
                });
            });

            app.UseSwaggerUI(options =>
            {
                foreach (var desc in apiVersionDescriptionProvider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint($"../swagger/{desc.GroupName}/swagger.json", desc.ApiVersion.ToString());
                    options.DefaultModelsExpandDepth(-1);
                    options.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
                }
            });

            //app.UseExceptionHandler(a => a.Run(async context =>
            //{
            //    var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
            //    var exception = exceptionHandlerPathFeature.Error;


            //    //File.AppendAllText(@"D:\Dev\Visual Studio\KNUSTTimetable\KNUSTTimeTable.API\bin\Debug\net5.0" + DateTime.Now.ToString("yyyyMMdd") + ".txt", exception.Message + Environment.NewLine + Environment.NewLine);

            //    var result = JsonConvert.SerializeObject(new { error = exception.Message });
            //    if (exception is CustomException || exception is SecurityTokenException)
            //    {
            //        context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            //    }

            //    context.Response.ContentType = "application/json";
            //    await context.Response.WriteAsync(result);
            //}));

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseMiddleware(typeof(ExceptionHandlingMiddleware));
            app.UseMiddleware(typeof(AuthorizationMiddleware));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
