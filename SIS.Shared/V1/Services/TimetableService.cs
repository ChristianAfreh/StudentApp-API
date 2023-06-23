using Microsoft.Extensions.Options;

using RestSharp;
using SIS.Shared.DTOs;
using SIS.Shared.Exceptions;
using SIS.Shared.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Services
{
    public interface ITimetableService
    {
        Task<List<CourseScheduleGetDTO>> GetStudentCourseScheduleAsync(string studentId, int acadYear, int semesterId, string accessToken);

        Task<CourseScheduleGetDetailDTO> GetCourseScheduleDetailAsync(int courseScheduleId, string accessToken);
    }

    public class TimetableService : ITimetableService
    {
        private readonly RestClient _restClient;
        private readonly AppSettings _appSettings;

        public TimetableService(IOptionsMonitor<AppSettings> optionsMonitor)
        {
            _appSettings = optionsMonitor.CurrentValue;
            _restClient = new RestClient(_appSettings.TimetableBaseUrl);
        }

        public async Task<CourseScheduleGetDetailDTO> GetCourseScheduleDetailAsync(int courseScheduleId, string accessToken)
        {
            RestRequest restRequest = new RestRequest($"/CourseSchedule/{courseScheduleId}");
            restRequest.AddHeader("Authorization", $"Bearer {accessToken}");
            var response = await _restClient.ExecuteAsync<CourseScheduleGetDetailDTO>(restRequest);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return response.Data;
            }
            else
            {
                throw new CustomException("Unable to retrieve course schedule.");
            }
        }

        public async Task<List<CourseScheduleGetDTO>> GetStudentCourseScheduleAsync(string studentId, int acadYear, int semesterId, string accessToken)
        {
            RestRequest restRequest = new RestRequest($"/Student/{studentId}/Schedule");
            restRequest.AddHeader("Authorization", $"Bearer {accessToken}");
            restRequest.AddQueryParameter("acadYear", acadYear);
            restRequest.AddQueryParameter("semesterId", semesterId);

            var response = await _restClient.ExecuteAsync<List<CourseScheduleGetDTO>>(restRequest);
            if(response.StatusCode == HttpStatusCode.OK)
            {
                return response.Data;
            }   
            else
            {
                throw new CustomException("Unable to retrieve course schedules.");
            }
        }
    }
}
