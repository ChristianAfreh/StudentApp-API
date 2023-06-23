﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace SIS.Shared.Extensions
{
    public static class CoreExtensions
    {
        private static Random random = new Random();

        public static string InterceptException(Exception ex, string source, StackTrace stackTrace)
        {
            if (!Debugger.IsAttached)
            {
                int code = RandomNumber();
                ExceptionLogger(code, source, ex, stackTrace);
                return ExceptionMessage(code);
            }
            else
            {
                int code = RandomNumber();
                ExceptionLogger(code, source, ex, stackTrace);
                return ExceptionMessage(code);
            }
        }

        private static int RandomNumber(int min = 1001, int max = 9999)
        {
            random = new Random();
            return random.Next(min, max);
        }

        //TODO: add username parameter to ExceptionLogger

        /// <summary>
        /// Logs Caught Exceptions in Text File.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="ex"></param>
        private static void ExceptionLogger(int code, string source, Exception ex, StackTrace trace)
        {
            string directory = $@"{Directory.GetCurrentDirectory()}\wwwroot\SIS.SharedLogs\Exceptions";
            string fileDirectory = $@"{directory}\Log-{DateTime.Now.ToString("yyyy-dd-M")}.txt";
            var timeOfDay = DateTime.Now;
            try
            {

                //create directory
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                //create file

                using (StreamWriter fs = File.AppendText(fileDirectory))
                {
                    fs.WriteLine($"{code}--{timeOfDay.TimeOfDay}");
                    fs.WriteLine($"User = ");
                    fs.WriteLine($"Source = {source}");
                    fs.WriteLine($"Exception ({ex?.GetType().Name}) Message = {ex?.Message}");
                    fs.WriteLine($"Inner Exception ({ex?.InnerException?.GetType().Name}) = {ex?.InnerException?.Message}");
                    fs.WriteLine("");
                    fs.WriteLine("====================================================");
                    fs.WriteLine("");

                }
                StackTraceLogger(code, timeOfDay, trace);
            }
            catch (Exception e)
            {
                using (StreamWriter fs = File.AppendText(fileDirectory))
                {
                    fs.WriteLine("");
                    fs.WriteLine("====================================================");
                    fs.WriteLine("");
                }
                StackTraceLogger(code, timeOfDay, new StackTrace(true));
                //"Logging Failed - Contact System Admin."
            }
        }

        /// <summary>
        /// Logs Caught Exceptions' StackTrace in Text File.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="ex"></param>
        private static void StackTraceLogger(int code, DateTime timeOfDay, StackTrace trace)
        {
            string directory = $@"{Directory.GetCurrentDirectory()}\wwwroot\SIS.SharedLogs\Exceptions\Log-StackTrace-{DateTime.Now.ToString("yyyy - dd - M")}";
            string fileDirectory = $@"{directory}\{code}-StackTrace.txt";

            try
            {

                //create directory
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                //create file

                using (StreamWriter fs = File.AppendText(fileDirectory))
                {
                    fs.WriteLine($"{code}--{timeOfDay.TimeOfDay}");
                    fs.WriteLine($"User = ");
                    foreach (var item in trace.GetFrames())
                    {
                        fs.WriteLine("...............");
                        fs.WriteLine($"Filename = {item.GetFileName()}");
                        fs.WriteLine($"Method = {item.GetMethod()}");
                        fs.WriteLine($"Line = {item.GetFileLineNumber()}");
                        fs.WriteLine($"Column = {item.GetFileColumnNumber()}");
                        fs.WriteLine("...............");
                    }
                    fs.WriteLine("");
                    fs.WriteLine("====================================================");
                    fs.WriteLine("");

                }

            }
            catch (Exception e)
            {
                using (StreamWriter fs = File.AppendText(fileDirectory))
                {
                    fs.WriteLine("");
                    fs.WriteLine("====================================================");
                    fs.WriteLine("");
                }
                //Logging Failed - Contact System Admin.
            }
        }

        public static void PaymentGatewayTransactionLogger(string httpResponseContent, string provider, int applicantRequestId, string username)
        {
            string directory = $@"{Directory.GetCurrentDirectory()}\wwwroot\SIS.SharedLogs\PaymentGatewayLogs";
            string fileDirectory = $@"{directory}\{applicantRequestId}-Dump-{DateTime.Now.ToString("yyyy-dd-M")}.txt";
            var timeOfDay = DateTime.Now;
            try
            {

                //create directory
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                //create file

                using (StreamWriter fs = File.AppendText(fileDirectory))
                {
                    fs.WriteLine($"User = {username}");
                    fs.WriteLine($"Provider = {provider}");
                    fs.WriteLine("================================================================");
                    fs.WriteLine($"{httpResponseContent}");

                }
            }
            catch (Exception e)
            {
                using (StreamWriter fs = File.AppendText(fileDirectory))
                {
                    fs.WriteLine("");
                    fs.WriteLine("====================================================");
                    fs.WriteLine("");
                }
                //"Logging Failed - Contact System Admin."
            }
        }

        /// <summary>
        /// Returns user friendly message
        /// </summary>
        /// <param name="code"></param>
        private static string ExceptionMessage(int code)
        {
            return $"Error with code: #{code} occured. Contact System Administrator with error code.";
        }
    }
}
