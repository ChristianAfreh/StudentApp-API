using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using MimeKit;
using SIS.Shared.DTOs;
using SIS.Shared.Entities.SISContext;
using SIS.Shared.Exceptions;
using SIS.Shared.Helpers;
using SIS.Shared.Settings;
using SIS.Shared.V1.Repositories;

namespace SIS.Shared.V1.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequestDTO mailRequest);
        Task SendRegistrationReportAsync(string studentId, int acadYear, int sem, byte[] reportData);
        //public void Send(string[] to, string subject, string content, bool isHtml = false, string from = null);
    }

    public class EmailService : IEmailService
    {
        private readonly MailSettings _mailSettings;
        private IStudentRepository _studentRepository;

        public EmailService(IOptions<MailSettings> mailSettings, IStudentRepository studentRepository)
        {
            _mailSettings = mailSettings.Value;
            _studentRepository = studentRepository;
        }

        public async Task SendRegistrationReportAsync(string studentId, int acadYear, int sem, byte[] reportData)
        {
            string subject = $"Registration slip for {studentId} ({GlobalFunction.GetAcadYearString(acadYear)} Sem {sem})";//, studentId, GlobalFunction.GetAcadYearString(acadYear), sem);
            string messageBody = "Please find attached registration slip for " + GlobalFunction.GetAcadYearString(acadYear) + " academic year, semester " + sem + ".";
            StudentDetail student = await _studentRepository.GetStudentDetailsAsync(studentId);

            string studentEmail = student.EMAIL;
            //string studentEmail = "christian.afreh@knust.edu.gh";

            if (student == null)
            {
                throw new CustomException($"Student with reference number {studentId} was not found.");
            }

            string acadYearString = acadYear - 1 + "-" + acadYear;

            var file = new MailRequestAttachmentDTO()
            {
                FileName = $"{acadYearString} Sem {sem} Reg Slip.pdf",
                ContentType = System.Net.Mime.MediaTypeNames.Application.Pdf,
                FileData = reportData
            };

            MailRequestDTO mailRequest = new()
            {
                Body = messageBody,
                Subject = subject,
                RecipientEmails = new string[] { studentEmail },
                Attachments = new List<MailRequestAttachmentDTO> { file }
            };

            await SendEmailAsync(mailRequest);
        }

        public async Task SendEmailAsync(MailRequestDTO mailRequest)
        {
            var builder = new BodyBuilder();
            if (mailRequest.Attachments != null)
            {
                foreach (var file in mailRequest.Attachments)
                {
                    if (file.FileData.Length > 0)
                    {
                        builder.Attachments.Add(file.FileName, file.FileData, ContentType.Parse(file.ContentType));
                    }
                }
            }
            builder.HtmlBody = mailRequest.Body;

            var email = new MimeMessage
            {
                Sender = MailboxAddress.Parse(_mailSettings.From),
                Subject = mailRequest.Subject,
                Body = builder.ToMessageBody()
            };
            email.To.AddRange(mailRequest.RecipientEmails.Select(email => MailboxAddress.Parse(email)).ToList());

            email.From.Add(MailboxAddress.Parse(_mailSettings.From));

            using var smtp = new SmtpClient();
            smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSettings.From, _mailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }





        //public string GetHtmlBody(string fileName)
        //{

        //    string webrootPath = _webHostEnvironment.WebRootPath;
        //    string htmlPath = fileName;
        //    var comboPath = Path.Combine(webrootPath, htmlPath);

        //    if (File.Exists(comboPath))
        //    {
        //        string htmlText = File.ReadAllText(comboPath);
        //        return htmlText;
        //    }

        //    return null;

        //}

        //public void ConfirmEmailMail(string recipientEmail, string callBackUrl)
        //{
        //    try
        //    {
        //        string htmlBody = GetHtmlBody("confirmEmailTemplate.html");
        //        string subject = $"Confirm Email - {_settings.Value.InstitutionShortName}";

        //        if (string.IsNullOrEmpty(htmlBody))
        //        {
        //            htmlBody = "Please click <a href='{url}' target='_blank'>here</a> to confirm your email.";
        //        }

        //        htmlBody = htmlBody.Replace("{url}", callBackUrl);

        //        Send(recipientEmail, subject, htmlBody);

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //public void ResetPasswordEmail(string recipientEmail, string callBackUrl)
        //{
        //    try
        //    {
        //        string htmlBody = GetHtmlBody("passwordResetTemplate.html");
        //        string subject = $"Reset Password - {_settings.Value.InstitutionShortName}";

        //        if (string.IsNullOrEmpty(htmlBody))
        //        {
        //            htmlBody = "Please click <a href='{url}' target='_blank'>here</a> to reset your password.";
        //        }

        //        htmlBody = htmlBody.Replace("{url}", callBackUrl);

        //        Send(recipientEmail, subject, htmlBody);

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //public void VerifyAlumnusMail(AlumnusRefereeNotificationViewModel data, string callBackUrl)
        //{
        //    try
        //    {
        //        string htmlBody = GetHtmlBody("verifyAlumnusTemplate.html");
        //        string subject = $"Verify Fellow Alumnus - {_settings.Value.InstitutionShortName}";

        //        if (string.IsNullOrEmpty(htmlBody))
        //        {
        //            return;
        //        }

        //        htmlBody = htmlBody.Replace("{refereeFullName}", data.RefereeFullName);
        //        htmlBody = htmlBody.Replace("{alumnusFullName}", data.AlumnusFullName);
        //        htmlBody = htmlBody.Replace("{alumnusCompletionYear}", data.AlumnusCompletionYear);
        //        htmlBody = htmlBody.Replace("{alumnusCourseCombination}", data.AlumnusCourseCombination);
        //        htmlBody = htmlBody.Replace("{alumnusClass}", data.AlumnusClass);
        //        htmlBody = htmlBody.Replace("{alumnusHouse}", data.AlumnusHouse);

        //        htmlBody = htmlBody.Replace("{acceptUrl}", callBackUrl + "&response=true");
        //        htmlBody = htmlBody.Replace("{declineUrl}", callBackUrl + "&response=false");

        //        Send(data.RefereeEmail, subject, htmlBody);

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //public void AlertVerifiedAlumnus(string recipientEmail, string fullname)
        //{
        //    try
        //    {
        //        string htmlBody = GetHtmlBody("verifiedAlumnusTemplate.html");
        //        string subject = $"Alumnus Claim - {_settings.Value.InstitutionShortName}";

        //        if (string.IsNullOrEmpty(htmlBody))
        //        {
        //            return;
        //        }

        //        htmlBody = htmlBody.Replace("{fullName}", fullname);

        //        Send(recipientEmail, subject, htmlBody);

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
    }
}
