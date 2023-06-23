using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.Extensions.Options;
using SIS.Shared.Settings;

namespace SIS.Shared.V1.Services
{
    public class ReportGenerator
    {
        private readonly ReportServerSettings _reportServerSettings;

        public ReportGenerator(IOptionsMonitor<ReportServerSettings> optionsMonitor)
        {
            _reportServerSettings = optionsMonitor.CurrentValue;
        }

        public byte[] GetReport(string reportName, Dictionary<string, string> parameters)
        {
            //string baseUrl = $"/reportserver?/{_reportServerSettings.ReportFolder}/Reports/{reportName}&rs:Format=PDF&";
            string baseUrl = $"/reportserver?/ARMIS/Reports/{reportName}&rs:Format=PDF&";

            List<string> parameterList = new List<string>();

            foreach (var parameter in parameters)
            {
                string param = parameter.Key + "=" + parameter.Value;
                parameterList.Add(param);
            }

            string parameterStr = string.Join("&", parameterList);
            string reportUrl = _reportServerSettings.ReportServerUrl + baseUrl + parameterStr;


            var reportUri = new Uri(reportUrl);
            var networkCredential = new NetworkCredential(_reportServerSettings.ReportServerUsername, _reportServerSettings.ReportServerPassword);

            var client = new WebClient { Credentials = networkCredential };

            var response = client.DownloadData(reportUri);
            return response;
        }
    }
}

