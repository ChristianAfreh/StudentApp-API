using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SIS.Shared.Exceptions;

namespace SIS.API.Middlewares
{
    public class AuthorizationMiddleware
    {
        public RequestDelegate requestDelegate;
        public AuthorizationMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }
        public async Task Invoke(HttpContext context)
        {
            if (context.User.Identity.IsAuthenticated)
            {;
                var accountType = context.User.FindFirstValue("account_type");
                if (accountType.ToLower() != "student")
                {
                    throw new CustomException("You are not authorised to access this app.");
                }
                var studentId = context.User.FindFirstValue("account_id");
                object requestStudentId = null;
                var hasStudentId = context.Request.RouteValues.Any(x => x.Key.ToLower() == "studentid");
                if (hasStudentId)
                {
                     requestStudentId = context.Request.RouteValues.FirstOrDefault(x => x.Key.ToLower() == "studentid")!.Value;
                }
                else
                {
                    hasStudentId = context.Request.Query.Any(x => x.Key.ToLower() == "studentid");
                    if (hasStudentId)
                    {
                        requestStudentId = context.Request.Query.FirstOrDefault(x => x.Key.ToLower() == "studentid")!.Value;
                    }
                }

                if(requestStudentId != null)
                {
                    if (studentId != requestStudentId.ToString())
                    {
                        throw new CustomException("You are not authorised to access this data.");
                    }
                }               
            }
            await requestDelegate(context);

        }
    }
}
