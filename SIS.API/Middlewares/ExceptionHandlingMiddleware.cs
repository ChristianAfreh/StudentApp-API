using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using SIS.Shared.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SIS.API.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        public RequestDelegate requestDelegate;
        public ExceptionHandlingMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }
        public async Task Invoke(HttpContext context, ILogger<ExceptionHandlingMiddleware> logger)
        {
            try
            {
                await requestDelegate(context);
            }
            catch (Exception ex)
            {
                await HandleException(context, ex, logger);
            }
        }
        private static Task HandleException(HttpContext context, Exception exception, ILogger<ExceptionHandlingMiddleware> logger)
        {
            logger.LogError(exception.ToString());
            var result = JsonConvert.SerializeObject(new { error = exception.Message });
            if (exception is CustomException || exception is SecurityTokenException)
            {
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else
            {
                if(context.Response.StatusCode == (int)HttpStatusCode.OK)
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                }
            }

            context.Response.ContentType = "application/json";
            return context.Response.WriteAsync(result);
        }
    }
}
